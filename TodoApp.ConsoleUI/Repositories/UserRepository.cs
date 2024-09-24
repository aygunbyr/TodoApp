using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ConsoleUI.Models;

namespace TodoApp.ConsoleUI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users;

        public UserRepository()
        {
            users = new List<User>();
        }

        public User Add(User user)
        {
            users.Add(user);
            return user;
        }

        public User? Delete(int id)
        {
            User? userById = users.FirstOrDefault(x => x.Id == id);
            if (userById != null)
            {
                users.Remove(userById);
            }
            return userById;
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User? GetById(int id)
        {
            User? userById = users.FirstOrDefault(x => x.Id == id);
            return userById;
        }

        public User Update(User user)
        {
            User? userById = users.FirstOrDefault(x => x.Id == user.Id);
            int index = users.IndexOf(userById);

            if (userById != null)
            {
                users[index] = user;
            }
            return users[index];
        }
    }
}
