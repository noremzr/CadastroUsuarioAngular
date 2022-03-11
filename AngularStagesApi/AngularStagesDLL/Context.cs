using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularStagesDLL.Users;
using Microsoft.EntityFrameworkCore;

namespace AngularStagesDLL
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public string DbPath { get; } = @"Server = localhost\SQLEXPRESS; Database=AngularStages;User Id = sa; Password=sa12345";

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(p => p.UserName);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(DbPath);
    }

}
