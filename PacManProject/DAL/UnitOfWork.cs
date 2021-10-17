using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManProject.DAL.Interfaces;

namespace PacManProject.DAL
{
    public class UnitOfWork: IUnitOfWork
    {
        AppDBContext _context;

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
        }

        IRepository<GameCharacter> _gameCharacter;
        IRepository<Map> _map;
        IRepository<Player> _player;
        IRepository<MapObject> _mapObject;

        public IRepository<GameCharacter> gameCharacter
        {
            get { return _gameCharacter ??= new BaseRepository<GameCharacter>(_context); }
        }

        public IRepository<Map> map
        {
            get { return _map ??= new BaseRepository<Map>(_context); }
        }

        public IRepository<Player> player
        {
            get { return _player ??= new BaseRepository<Player>(_context); }
        }

        public IRepository<MapObject> mapObject
        {
            get { return _mapObject ??= new BaseRepository<MapObject>(_context); }
        }
    }
}
