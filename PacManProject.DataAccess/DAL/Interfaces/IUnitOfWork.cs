using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManProject.DataAccess.DAL.Models;

namespace PacManProject.DataAccess.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<GameCharacter> GameCharacters { get; }
        IRepository<Map> Maps { get; }
        IRepository<Player> Players { get; }
        IRepository<MapObject> MapObjects { get; }
        void Save();
    }
}
