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
        GameDBContext _context;

        public UnitOfWork(GameDBContext context)
        {
            _context = context;
        }

        IRepository<Entity> _entity;
        IRepository<Map> _map;
        IRepository<Player> _player;
        IRepository<WallsAndDots> _wallsAndDots;

        public IRepository<Entity> entity
        {
            get { return _entity ??= new GameRepository<Entity>(_context); }
        }

        public IRepository<Map> map
        {
            get { return _map ??= new GameRepository<Map>(_context); }
        }

        public IRepository<Player> player
        {
            get { return _player ??= new GameRepository<Player>(_context); }
        }

        public IRepository<WallsAndDots> wallsAndDots
        {
            get { return _wallsAndDots ??= new GameRepository<WallsAndDots>(_context); }
        }
    }
}
