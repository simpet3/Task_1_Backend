using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1_Backend.DataBase;
using Task_1_Backend.Models;

namespace Task_1_Backend.Repositories
{
    public class CommentRepository:BaseRepository<Comment>
    {
        public CommentRepository(MainDbContext dbContext) : base(dbContext)
        {
        }

    }
}
