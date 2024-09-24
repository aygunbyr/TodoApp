using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ConsoleUI.Models
{
    public sealed class User : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            
        }

        public User(int id, string name, string surname, int age, string email, string password) : base(id)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}, Email: {Email}, Password: {Password}";
        }
    }
}
