using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1_Backend.Models;

namespace Task_1_Backend.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity Get(int id);
        int Add(TEntity entity);
        void Delete(int id);
        void update(TEntity entity);
        void Save();
    }
}
