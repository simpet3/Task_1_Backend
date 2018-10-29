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

        protected BaseRepository()
        {
        }

        protected BaseRepository(DbContext db)
        {
            this._db = db;
            this._dbSet = db.Set<TEntity>();
        }

        public int Add(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(TEntity));

            _dbSet.Add(entity);
            return _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            Save();
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
                Save();
            }

        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
