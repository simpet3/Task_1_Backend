using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_1_Backend.DataBase;
using Task_1_Backend.Models;

namespace Task_1_Backend.Repositories
{
    public class PostRepository : BaseRepository<Post>
    {
        public PostRepository(MainDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<List<Post>> GetAll()
        {
            return await DbSet.Include(c => c.Comments).ToListAsync();
        }
    }
}