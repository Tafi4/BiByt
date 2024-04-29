using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BiByt.Database
{
    public class ApplicationContext : DbContext
    {
        protected readonly IConfiguration IConfig;

        public ApplicationContext(IConfiguration configuration)
        {
            IConfig = configuration;
            // Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // var host = ConfigurationManager.AppSettings["PG_HOST"];
            // var port = ConfigurationManager.AppSettings["PG_PORT"];
            // var username = ConfigurationManager.AppSettings["PG_USERNAME"];
            // var password = ConfigurationManager.AppSettings["PG_PASSWORD"];
            // var path = ConfigurationManager.AppSettings["PG_PATH"];
            if (!optionsBuilder.IsConfigured)
                // optionsBuilder.UseNpgsql($"Host={host}; Port={port}; Username={username}; Password={password}; Database={path}");
                optionsBuilder.UseNpgsql(IConfig.GetConnectionString("Database"));
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<User>(entity =>
        //     {
        //         // entity.ToTable( "quote_data", "crypto_data");
        //         entity.Property(b => b.Id)
        //             .HasColumnName("id")
        //             .IsRequired();
        //         entity.Property(b => b.Username)
        //             .HasColumnName("username");
        //     });
        // }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}