using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ConsoleUI.Models;
using TodoApp.ConsoleUI.Repositories;

namespace TodoApp.ConsoleUI.Services
{
    public class TodoService : IService<Todo>
    {
        private readonly ITodoRepository _todoRepository;
        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }
        public Todo Add(Todo todo)
        {
            Todo addedTodo = _todoRepository.Add(todo);
            return addedTodo;
        }

        public Todo? Delete(int id)
        {
            Todo? deletedTodo = _todoRepository.Delete(id);
            return deletedTodo;
        }

        public List<Todo> GetAll()
        {
            List<Todo> todos = _todoRepository.GetAll();
            return todos;
        }

        public Todo? GetById(int id)
        {
            Todo? todo = _todoRepository.GetById(id);
            return todo;
        }

        public Todo? Update(Todo todo)
        {
            Todo updatedTodo = _todoRepository.Update(todo);
            return updatedTodo;
        }
    }
}
