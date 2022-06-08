using Bogus;
using Celestia.Models;

namespace Celestia.Data.Seeding;

public static class FakeData
{
    private static Faker _faker;
    private static int _contactId = 0; 
    private static int _companyId = 0; 
    private static int _jobId = 0; 

    public static void Init()
    {
        _faker = new Faker("nb_NO");
    }

    public static List<Contact> FakeContactList(int contactCount, Account author)
    {
        var contactList = new List<Contact>();
        for (var i = 0; i < contactCount; i++, _contactId++)
        {
            var contact = new Contact()
            {
                Id = _contactId,
                AuthorId = author.Id,
                Author = author,
                CreatedAt = _faker.Date.Recent(),
                Email = _faker.Person.Email,
                Name = _faker.Person.FirstName,
                Phone = _faker.Phone.PhoneNumber()
            };
            contactList.Add(contact);
        }

        return contactList;
    }
    
    public static List<Job> FakeJobList(int jobCount, Account author, List<Company> companyList)
    {
        var jobList = new List<Job>();
        for (var i = 0; i < jobCount; i++, _companyId++)
        {
            var company = _faker.PickRandom(companyList);
            var isDraft = Convert.ToBoolean(Random.Shared.Next(0, 1));
            var randomDeadline = _faker.Date.Soon(Random.Shared.Next(14));
            var job = new Job()
            {
                Id = _companyId,
                AuthorId = author.Id,
                Author = author,
                CreatedAt = _faker.Date.Recent(),
                Title = _faker.Lorem.Sentence(),
                Description = _faker.Lorem.Paragraph(),
                PostingUrl = _faker.Image.LoremFlickrUrl(),
                Address = _faker.Address.FullAddress(),
                Company = company,
                CompanyId = company.Id,
                Deadline = randomDeadline,
                Status = isDraft ? JobStatus.Draft : JobStatus.Applied,
            };
            jobList.Add(job);
        }
        return jobList;
    }
    
    public static List<Company> FakeCompanyList(int companyCount, Account author)
    {
        var companyList = new List<Company>();
        for (var i = 0; i < companyCount; i++, _companyId++)
        {
            var company = new Company()
            {
                Id = _companyId,
                AuthorId = author.Id,
                Author = author,
                CreatedAt = _faker.Date.Recent(),
                Name = _faker.Company.CompanyName(),
                WebsiteUrl = _faker.Image.LoremFlickrUrl(),
                Address = _faker.Address.FullAddress(),
                IconUrl = _faker.Image.LoremFlickrUrl()
            };
            companyList.Add(company);
        }

        return companyList;
    }



}