using Application.Domain;
using Application.Service.Interfaces;
using Application.Repository;
using Application.Repository.Interfaces;
using Application.Database;

namespace Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll().Cast<User>().ToList();
        }

        public User Authenticate(string username, string password)
        {
            return _userRepository.GetUserByCredentials(username, password);
        }
    }
}
