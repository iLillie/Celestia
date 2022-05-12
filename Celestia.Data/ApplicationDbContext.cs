using Celestia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace Celestia.Data;

public class ApplicationDbContext : DbContext
{
    private readonly string _connectionString;

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<JobBoard> JobBoards { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IOptions<PostgresConfiguration> postgreConfiguration)
        : base(options)
    {
        _connectionString = postgreConfiguration.Value.ConnectionString!;
    }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, string connectionString)
        : base(options)
    {
        _connectionString = connectionString;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql(_connectionString).UseSnakeCaseNamingConvention();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.UseIdentityColumns();
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