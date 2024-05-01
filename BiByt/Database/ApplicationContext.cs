using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiByt.Database;

public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var host = ConfigurationManager.AppSettings["PG_HOST"];
            var port = ConfigurationManager.AppSettings["PG_PORT"];
            var username = ConfigurationManager.AppSettings["PG_USERNAME"];
            var password = ConfigurationManager.AppSettings["PG_PASSWORD"];
            var path = ConfigurationManager.AppSettings["PG_PATH"];
            optionsBuilder.UseNpgsql(
                $"Host={host}; Port={port}; Username={username}; Password={password}; Database={path}");
            // optionsBuilder.UseNpgsql(config.GetConnectionString("Database"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.Entity<User>(UserConfigure);
        modelBuilder.Entity<Transaction>(TransactionConfigure);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    private static void UserConfigure(EntityTypeBuilder<User> builder)
    {
        builder.Property(c => c.Id)
            .HasColumnName("id");
        builder.Property(c => c.Username)
            .HasColumnName("username")
            .IsRequired();
        builder.Property(c => c.Password)
            .HasColumnName("password")
            .HasMaxLength(16);
    }

    private static void TransactionConfigure(EntityTypeBuilder<Transaction> builder)
    {
        builder.Property(c => c.Id)
            .HasColumnName("id");
        builder.Property(c => c.UserId)
            .HasColumnName("user_id");
        builder.Property(c => c.Cost)
            .HasColumnName("cost");
        builder.Property(c => c.Type)
            .HasColumnName("type");
    }
}

// public class UserConfiguration : IEntityTypeConfiguration<User>
// {
//     public void Configure(EntityTypeBuilder<User> builder)
//     {
// builder.Property(c => c.Id)
//     .HasColumnName("id");
// builder.Property(c => c.Username)
//     .HasColumnName("username")
//     .IsRequired();
// builder.Property(c => c.Password)
//     .HasColumnName("password")
//     .HasMaxLength(16);
//     }
// }