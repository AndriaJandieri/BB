using System.Collections.Generic;
using System.Reflection.Emit;
using BB_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace BB_Razor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Category> CategoriesRazor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ActionR", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFiR", DisplayOrder = 2 },
                new Category { Id = 3, Name = "HistoryR", DisplayOrder = 3 }
            );
        }
    }
}
