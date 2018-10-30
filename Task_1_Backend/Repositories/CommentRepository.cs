using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_1_Backend.DataBase;
using Task_1_Backend.Models;
using Task_1_Backend.ViewModels;

namespace Task_1_Backend.Repositories
{
    public class CommentRepository:BaseRepository<Comment>
    {
        public CommentRepository(MainDbContext dbContext) : base(dbContext)
        {
        }

        public override List<Comment> GetAll()
        {          
            return _dbSet.Include(p => p.Post).ToList();
        }
    }
}
