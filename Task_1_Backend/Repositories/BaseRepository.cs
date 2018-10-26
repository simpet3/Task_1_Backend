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

        public BaseRepository()
        {
        }

        public BaseRepository(DbContext db)
        {
            this._db = db;
        }

        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _db.Set<TEntity>().Find(id);
            _db.Set<TEntity>().Remove(entity);
        }


        public TEntity Get(int Id)
        {
            return _db.Set<TEntity>().Find(Id);
        }

        public List<TEntity> GetAll()
        {
            return _db.Set<TEntity>().ToList();
        }

        public void update(TEntity entity)
        {
            _db.Set<TEntity>().Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
