using ConsoleApp90.Model;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp90.Context
{
    internal class ApplicationDbContext:DbContext
    {
       public DbSet<Tasks> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-R2G8DEC\\SQLEXPRESS;Initial Catalog=Task_503;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Task_Configuration());
        }

    }
}
