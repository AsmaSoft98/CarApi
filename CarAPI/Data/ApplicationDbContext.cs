
using CarAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Model)
                                   .HasMaxLength(100)
                                   .HasColumnName("model");
                entity.Property(e => e.Marque)
                                   .HasMaxLength(50)
                                   .HasColumnName("marque");
                entity.Property(e => e.Color)
                                   .HasMaxLength(50)
                                   .HasColumnName("color");

            });
            
        }
        public DbSet<Car> Cars { get; set; } = default!;
    }
}
