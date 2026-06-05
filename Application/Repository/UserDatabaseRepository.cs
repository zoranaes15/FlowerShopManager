using Application.Domain;
using Application.Database;
using Application.Repository.Base;
using Application.Repository.Interfaces;

namespace Application.Repository
{
    public class UserDatabaseRepository : CrudDatabaseRepository<User, FlowerShopManagerDbContext>
    {
        public UserDatabaseRepository(FlowerShopManagerDbContext dbContext) : base(dbContext) {}

        public User GetUserByCredentials(string email, string password)
        {
            var user = DbContext.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
                throw new Exception($"Invalid username or password");
            return user;
        }
    }
}
