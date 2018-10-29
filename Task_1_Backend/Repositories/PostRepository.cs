using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_1_Backend.DataBase;
using Task_1_Backend.Models;

namespace Task_1_Backend.Repositories
{
    public class PostRepository:BaseRepository<Post>
    {
        public PostRepository(MainDbContext dbContext) : base(dbContext)
        {

        }
    }
}
