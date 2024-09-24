using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ConsoleUI.Models;

namespace TodoApp.ConsoleUI.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private List<Todo> todos;

        public TodoRepository()
        {
            todos = new List<Todo>();
        }

        public Todo Add(Todo todo)
        {
            todos.Add(todo);
            return todo;
        }

        public Todo? Delete(int id)
        {
            Todo? todoById = todos.FirstOrDefault(x => x.Id == id);
            if (todoById != null)
            {
                todos.Remove(todoById);
            }
            return todoById;
        }

        public List<Todo> GetAll()
        {
            return todos;
        }

        public Todo? GetById(int id)
        {
            Todo? todoById = todos.FirstOrDefault(x => x.Id == id);
            return todoById;
        }

        public Todo? Update(Todo todo)
        {
            Todo? todoById = todos.FirstOrDefault(x => x.Id == todo.Id);
            int index = todos.IndexOf(todoById);

            if(todoById != null)
            {
                todos[index] = todo;
                return todos[index];
            }
            return null;
            
        }
    }
}
