using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UsersForm : Form
    {
        private readonly IUserService _userService;
        private DataTable usersTable;

        public UsersForm()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            this.Load += UsersForm_Load;
            _userService = new UserService();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            usersTable = new DataTable("Users");

            var btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Change";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Name = "EditCol";

            var btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Name = "DeleteCol";


            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            usersTable.Columns.Add("Id", typeof(int));
            usersTable.Columns.Add("First Name", typeof(string));
            usersTable.Columns.Add("Last Name", typeof(string));
            usersTable.Columns.Add("Email", typeof(string));
            usersTable.Columns.Add("Joined At", typeof(DateTime));
            usersTable.Columns.Add("Role", typeof(string));

            List<User> users = _userService.GetAll();

            foreach (var user in users)
            {
                usersTable.Rows.Add(
                    user.Id,
                    user.FirstName,
                    user.LastName,
                    user.Email,
                    user.CreatedAt,
                    user.Role.ToString());
            }

            dataGridView1.DataSource = usersTable;
            dataGridView1.Columns.Add(btnEdit);
            dataGridView1.Columns.Add(btnDelete);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteCol")
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                object? targetValue = selectedRow.Cells["Id"].Value;

                int id = Convert.ToInt32(targetValue);

                _userService.Delete(id);
                UsersForm_Load(this, EventArgs.Empty);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "EditCol")
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                object? targetValue = selectedRow.Cells["Id"].Value;

                int id = Convert.ToInt32(targetValue);
                User user = _userService.GetById(id)!;
                
                UserEditForm userEditForm = new UserEditForm(user);
                if (userEditForm.ShowDialog() == DialogResult.OK)
                {
                    UsersForm_Load(this, EventArgs.Empty);
                }


            }
        }

    }
}
