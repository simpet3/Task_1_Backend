using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1_Backend.Repositories;

namespace Task_1_Backend.Services
{
    public class BaseService<TEntity> :IBaseService<TEntity> where TEntity: class
    {
        private readonly IRepository<TEntity> repository;

        public BaseService(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public List<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity Get(int id)
        {
            return repository.Get(id);
        }

        public void Add(TEntity entity)
        {
            repository.Add(entity);
            repository.Save();
        }

        public void Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
        }

        public void update(TEntity entity)
        {
            repository.update(entity);
            repository.Save();
        }
    }
}
