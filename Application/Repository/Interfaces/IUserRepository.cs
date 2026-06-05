using Application.Domain;
using Application.Repository.Base;

namespace Application.Repository.Interfaces
{
    public interface IUserRepository : ICrudRepository<User>
    {
        User GetUserByCredentials(string email, string password);
    }
}
