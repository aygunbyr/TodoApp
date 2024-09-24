using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ConsoleUI.Models
{
    public abstract class Entity
    {
        public int Id;

        protected Entity() { }

        protected Entity(int id) : this() 
        {
            Id = id;
        }
    }
}
