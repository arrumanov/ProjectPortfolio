using Microsoft.EntityFrameworkCore;

namespace ProjectPortfolio.Data
{
    public class ProjectPortfolioDbContext : DbContext
    {
        public ProjectPortfolioDbContext(DbContextOptions<ProjectPortfolioDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Project>()
                .HasIndex(a => a.Name)
                .IsUnique();
        }

        public DbSet<Project> Projects { get; set; } = default!;
    }
}