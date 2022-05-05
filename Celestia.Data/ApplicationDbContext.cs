using Celestia.Models;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Position> Positions { get; set; }
}