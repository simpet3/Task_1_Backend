using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task_1_Backend.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _db;
        private readonly DbSet<TEntity> _dbSet;
        public BaseRepository()
        {
        }
         
        public BaseRepository(DbContext db)
        {
            this._db = db;
            this._dbSet = db.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Add(entity);
            }

        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }


        public TEntity Get(int Id)
        {
            return _dbSet.Find(Id);
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void update(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
            }

        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
