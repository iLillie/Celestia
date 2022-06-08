using Bogus;
using Celestia.Models;

namespace Celestia.Data.Seeding;

public static class FakeData
{
    private static Faker _faker;
    private static int _contactId = 1; 
    private static int _companyId = 1; 
    private static int _jobId = 1; 

    public static void Init()
    {
        _faker = new Faker("nb_NO");
    }

    public static List<Contact> FakeContactList(int contactCount, int authorId)
    {
        var contactList = new List<Contact>();
        for (var i = 0; i < contactCount; i++, _contactId++)
        {
            var person = new Bogus.Person("nb_NO");
            var contact = new Contact()
            {
                Id = _contactId,
                AuthorId = authorId,
                CreatedAt = _faker.Date.Recent().ToUniversalTime(),
                Email =  person.Email,
                Name = person.FirstName,
                Phone = person.Phone
            };
            contactList.Add(contact);
        }

        return contactList;
    }
    
    public static List<Job> FakeJobList(int jobCount, int authorId, List<Company> companyList)
    {
        var jobList = new List<Job>();
        for (var i = 0; i < jobCount; i++, _companyId++)
        {
            var company = _faker.PickRandom(companyList);
            var isDraft = Convert.ToBoolean(Random.Shared.Next(0, 1));
            var randomDeadline = _faker.Date.Soon(Random.Shared.Next(14)).ToUniversalTime();
            var job = new Job()
            {
                Id = _companyId,
                AuthorId = authorId,
                CreatedAt = _faker.Date.Recent().ToUniversalTime(),
                Title = _faker.Lorem.Sentence(3),
                Description = _faker.Lorem.Paragraph(),
                PostingUrl = _faker.Image.LoremFlickrUrl(),
                Address = _faker.Address.FullAddress(),
                CompanyId = company.Id,
                Deadline = randomDeadline,
                Status = isDraft ? JobStatus.Draft : JobStatus.Applied,
            };
            jobList.Add(job);
        }
        return jobList;
    }
    
    public static List<Company> FakeCompanyList(int companyCount, int authorId)
    {
        var companyList = new List<Company>();
        for (var i = 0; i < companyCount; i++, _companyId++)
        {
            var company = new Company()
            {
                Id = _companyId,
                AuthorId = authorId,
                CreatedAt = _faker.Date.Recent().ToUniversalTime(),
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