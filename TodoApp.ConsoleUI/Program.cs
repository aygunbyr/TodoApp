using TodoApp.ConsoleUI.Models;
using TodoApp.ConsoleUI.Repositories;
using TodoApp.ConsoleUI.Services;
using UserApp.ConsoleUI.Services;

UserRepository userRepository = new UserRepository();
UserService userService = new UserService(userRepository);

TodoRepository todoRepository = new TodoRepository();
TodoService todoService = new TodoService(todoRepository);

User user = new User(1, "Aygün", "Bayır", 29, "turkoaygun@gmail.com", "123456");

Todo todo = new Todo(1, "Walk dog", "Walk dog", DateTime.Now, "24-09-2024", "30-09-2024", user.Id, false, "High");
todoService.Add(todo);

Todo? todoById = todoService.GetById(1);
Console.WriteLine(todoById);