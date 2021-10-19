using PacManProject.DAL.Interfaces;
using System;

namespace PacManProject.DAL
{
    public class UnitOfWork : IUnitOfWork
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

        public IRepository<GameCharacter> GameCharacters
        {
            get { return _gameCharacter ??= new BaseRepository<GameCharacter>(_context); }
        }

        public IRepository<Map> Maps
        {
            get { return _map ??= new BaseRepository<Map>(_context); }
        }

        public IRepository<Player> Players
        {
            get { return _player ??= new BaseRepository<Player>(_context); }
        }

        public IRepository<MapObject> MapObjects
        {
            get { return _mapObject ??= new BaseRepository<MapObject>(_context); }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
