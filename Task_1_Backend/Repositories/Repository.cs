using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_1_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Task_1_Backend.Repository
{
    public class Repository: DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Post> Records { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(@"Data Source = d:\Sample.db");
        }
    }   
}
