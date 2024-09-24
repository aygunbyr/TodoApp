using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ConsoleUI.Repositories
{
    public interface IRepository<Entity>
    {
        public Entity? GetById(int id);
        public List<Entity> GetAll();
        public Entity Add(Entity entity);
        public Entity? Update(Entity entity);
        public Entity? Delete(int id);
    }
}
