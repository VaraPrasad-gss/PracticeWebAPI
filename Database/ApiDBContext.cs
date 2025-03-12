using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options) { }
        public DbSet<Student> students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, name = "Saketh", address = "Ongole" },
                new Student { Id = 2, name = "Prem", address = "Ongole" },
                new Student { Id = 3, name = "Jaswanth", address = "Chittoor" }
                );
        }
    }
}
