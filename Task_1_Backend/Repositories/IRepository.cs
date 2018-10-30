using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_1_Backend.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> Get(int id);
        Task<TEntity> Add(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
        Task<bool> Save();
    }
}