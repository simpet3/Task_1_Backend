using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_1_Backend.DataBase;
using Task_1_Backend.Models;

namespace Task_1_Backend.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(MainDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<List<Comment>> GetAll()
        {
            return await DbSet.Include(p => p.Post).ToListAsync();
        }

        public async Task<List<Comment>> GetCommentsByPostId(int postId)
        {
            return await DbSet.Include(p => p.Post).Where(c => c.PostId == postId).ToListAsync();
        }
    }
}