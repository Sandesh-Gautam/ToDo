using Microsoft.EntityFrameworkCore;
using System.Globalization;
using ToDo.Models;

namespace ToDo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {
            
        }
        public DbSet<Todo> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData
                (
               new Todo
               {
                   Id = 1,
                   Title = "Sample",
                   Description = "",
                   DueDate = DateTime.ParseExact("2050-01-01 00:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                   IsCompleted = false,
                   Priority = Priority.High
               }

                );
        }
    }
}
