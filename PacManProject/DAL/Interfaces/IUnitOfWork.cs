using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManProject.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<GameCharacter> gameCharacter { get; }
        IRepository<Map> map { get; }
        IRepository<Player> player { get; }
        IRepository<MapObject> mapObject { get; }
    }
}
