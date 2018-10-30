using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task_1_Backend.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected BaseRepository()
        {
        }

        protected BaseRepository(DbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(TEntity));
            var entry = Db.Entry(entity);
            await DbSet.AddAsync(entity);
            await Save();
            return entry.Entity;
        }

        public async void Delete(int id)
        {
            var entity = await DbSet.FindAsync(id);
            DbSet.Remove(entity);
            await Save();
        }

        public async Task<TEntity> Get(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async void Update(TEntity entity)
        {
            if (entity == null) return;
            await DbSet.AddAsync(entity);
            Db.Entry(entity).State = EntityState.Modified;
            await Save();
        }

        public async Task<bool> Save()
        {
            return await Db.SaveChangesAsync() > 0;
        }
    }
}