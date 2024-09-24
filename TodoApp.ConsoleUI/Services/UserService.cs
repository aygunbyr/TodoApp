using TodoApp.ConsoleUI.Models;
using TodoApp.ConsoleUI.Repositories;
using TodoApp.ConsoleUI.Services;

namespace UserApp.ConsoleUI.Services
{
    public class UserService : IService<User>
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Add(User user)
        {
            User addedUser = _userRepository.Add(user);
            return addedUser;
        }

        public User? Delete(int id)
        {
            User? deletedUser = _userRepository.Delete(id);
            return deletedUser;
        }

        public List<User> GetAll()
        {
            List<User> users = _userRepository.GetAll();
            return users;
        }

        public User? GetById(int id)
        {
            User? user = _userRepository.GetById(id);
            return user;
        }

        public User? Update(User user)
        {
            User updatedUser = _userRepository.Update(user);
            return updatedUser;
        }
    }
}
