using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            RegistrationForm form2 = new RegistrationForm();
            form2.Show();
            this.Hide();
        }

       
    }
}
