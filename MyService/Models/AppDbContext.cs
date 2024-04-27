namespace MyService.Models
{
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databasePath = "app.db";
            optionsBuilder.UseSqlite($"Filename={databasePath}");

            base.OnConfiguring(optionsBuilder);

        }
    }
}
