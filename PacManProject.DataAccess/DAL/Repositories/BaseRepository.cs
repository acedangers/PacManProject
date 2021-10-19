using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManProject.DAL.Interfaces;

namespace PacManProject.DAL
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        AppDBContext _context;

        public BaseRepository(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            T entityToRemove = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entityToRemove);
            _context.SaveChanges();
        }
    }
}
