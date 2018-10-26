using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1_Backend.Services
{
    public interface IBaseService<TEntity> where TEntity: class
    {
        List<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Delete(int id);
        void update(TEntity entity);
    }
}
