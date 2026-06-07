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
        public UserService()
        {
            _userRepository = new UserDatabaseRepository(AppDb.CreateContext());
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll().Cast<User>().ToList();
        }

        public User? GetById(int id)
        {
            return _userRepository.Get(id);
        }

        public User Authenticate(string email, string password)
        {
            return _userRepository.GetUserByCredentials(email, password);
        }

        public User Register(User user)
        {
            var existing = _userRepository.GetAll().Cast<User>().FirstOrDefault(u => u.Email == user.Email);
            if (existing != null)
                throw new Exception("A user with this email already exists.");
            return _userRepository.Create(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public User Update(User user)
        {
            return _userRepository.Update(user);
        }
    }
}
