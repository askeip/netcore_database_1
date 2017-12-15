using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Extreme_DI.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }

        public StudentContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>().HasKey(x => x.StudentID); ;
        }
    }
}
