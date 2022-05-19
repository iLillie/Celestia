using Celestia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace Celestia.Data;

public class ApplicationDbContext : DbContext
{
    private readonly string _connectionString;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
        IOptions<PostgresConfiguration> postgresConfiguration)
        : base(options)
    {
        _connectionString = postgresConfiguration.Value.ConnectionString!;
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, string connectionString)
        : base(options)
    {
        _connectionString = connectionString;
    }

    public DbSet<Account> Accounts => Set<Account>();
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<Job> Jobs => Set<Job>();
    public DbSet<Folder> Folders => Set<Folder>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(_connectionString).UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.UseIdentityColumns();
        modelBuilder.Entity<Company>().Navigation(c => c.Contacts).AutoInclude();
        modelBuilder.Entity<Folder>().Navigation(f => f.Jobs).AutoInclude();
    }
}

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder
            .UseNpgsql(args[0])
            .UseSnakeCaseNamingConvention();
        return new ApplicationDbContext(optionsBuilder.Options, args[0]);
    }
}