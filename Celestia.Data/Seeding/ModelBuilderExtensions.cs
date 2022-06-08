using Celestia.Models;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Data.Seeding;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var testAccount = new Account()
        {
            Id = 0,
            Name = "Lillie",
            Address = "Oslo, Norway",
            Auth0Id = "",
            CreatedAt = new DateTime()
        };
        
        var fakeCompanyList = FakeData.FakeCompanyList(15, testAccount);
        var fakeJobList = FakeData.FakeJobList(30, testAccount, fakeCompanyList);
        var fakeContactList = FakeData.FakeCompanyList(15, testAccount);
        
        modelBuilder.Entity<Account>().HasData(testAccount);
        modelBuilder.Entity<Company>().HasData(fakeCompanyList);
        modelBuilder.Entity<Job>().HasData(fakeJobList);
        modelBuilder.Entity<Contact>().HasData(fakeContactList);
    }
}