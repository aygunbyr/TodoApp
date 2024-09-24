using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.ConsoleUI.Models;

namespace TodoApp.ConsoleUI.Repositories
{
    public interface ITodoRepository : IRepository<Todo>
    {
    }
}
