using System.Collections.Generic;
using System.Threading.Tasks;
using Task_1_Backend.Models;

namespace Task_1_Backend.Repositories
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<List<Comment>> GetCommentsByPostId(int postId);
    }
}