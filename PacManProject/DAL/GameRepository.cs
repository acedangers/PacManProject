using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacManProject.DAL.Interfaces;
using System.Data.Entity;

namespace PacManProject.DAL
{
    public class GameRepository<T> : IRepository<T> where T : class
    {
        GameDBContext gameContext;

        public GameRepository(GameDBContext context)
        {
            gameContext = context;
        }

        public IEnumerable<T> GetAll()
        {
            return gameContext.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return gameContext.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            gameContext.Set<T>().Add(entity);
            gameContext.SaveChanges();
        }

        public void Update(T entity)
        {
            gameContext.Entry(entity).State = EntityState.Modified;
            gameContext.SaveChanges();
        }

        public void Delete(int id)
        {
            T entityToRemove = gameContext.Set<T>().Find(id);
            gameContext.Set<T>().Remove(entityToRemove);
            gameContext.SaveChanges();
        }
        public void Save()
        {
            gameContext.SaveChanges();
        }
    }
}
