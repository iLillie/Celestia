using Celestia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace Celestia.Data;

public class ApplicationDbContext : DbContext
{
    private readonly string _connectionString;
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
        => options.UseNpgsql(_connectionString);
}

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseNpgsql(args[0]);
        return new ApplicationDbContext(optionsBuilder.Options, args[0]);
    }
    
}