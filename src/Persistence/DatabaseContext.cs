namespace pottencial_dev_week.src.Persistence;

using Microsoft.EntityFrameworkCore;
using pottencial_dev_week.src.Models;

public class DatabaseContext : DbContext 
{
    public DatabaseContext
    (
        DbContextOptions<DatabaseContext> options
    ) : base (options)
    {
        
    }

    public DbSet<Person> Persons { get; set; }

    public DbSet<Contract> Contracts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Person>(e => {
            e.HasKey( e => e.Id);
            e.HasMany(e => e.Contracts )
                .WithOne()
                .HasForeignKey(contract => contract.PersonId);
        });

        modelBuilder.Entity<Contract>(e => {
            e.HasKey (e => e.Id );
        });
    }
}