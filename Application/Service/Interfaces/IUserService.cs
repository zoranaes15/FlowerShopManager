using Application.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.Interfaces
{
    public interface IUserService
    {
        public List<User> GetAll();
        public User? GetById(int id);
        public User Authenticate(string username, string password);
        public User Register(User user);
        public void Delete(int id);
        public User Update(User user);
    }
}
