using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Entity> entity { get; }
        IRepository<Map> map { get; }
        IRepository<Player> player { get; }
        IRepository<WallsAndDots> wallsAndDots { get; }
    }
}
