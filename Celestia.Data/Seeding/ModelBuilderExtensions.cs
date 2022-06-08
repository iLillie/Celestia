using Celestia.Models;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Data.Seeding;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var testAccount = new Account()
        {
            Id = 1,
            Name = "Lillie",
            Address = "Oslo, Norway",
            Auth0Id = "",
            CreatedAt = DateTime.UtcNow
        };
        FakeData.Init();
        var fakeCompanyList = FakeData.FakeCompanyList(15, testAccount.Id);
        var fakeJobList = FakeData.FakeJobList(30, testAccount.Id, fakeCompanyList);
        var fakeContactList = FakeData.FakeContactList(15, testAccount.Id);
        
        modelBuilder.Entity<Account>().HasData(testAccount);
        modelBuilder.Entity<Company>().HasData(fakeCompanyList);
        modelBuilder.Entity<Job>().HasData(fakeJobList);
        modelBuilder.Entity<Contact>().HasData(fakeContactList);
    }
}