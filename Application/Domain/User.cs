using System;
using System.Collections.Generic;
using System.Linq;
namespace Application.Domain
{
    public enum UserRole
    {
        Admin,
        Staff,
        Customer
    }

    public class User : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public UserRole Role { get; private set; }

        public User()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            CreatedAt = DateTime.MinValue;
            Role = UserRole.Customer;
        }

        public User(string firstName, string lastName, string email, string password, DateTime createdAt, UserRole role)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            CreatedAt = createdAt;
            Role = role;
        }

        public User(int id, string firstName, string lastName, string email, string password, DateTime createdAt, UserRole role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            CreatedAt = createdAt;
            Role = role;
        }

        public void UpdateProfile(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ResetPassword(string newPassword)
        {
            Password = newPassword;
        }

    }
}
