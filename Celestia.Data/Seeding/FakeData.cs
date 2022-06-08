using Bogus;
using Celestia.Models;

namespace Celestia.Data.Seeding;

public static class FakeData
{
    private static Faker _faker;

    public static void Init()
    {
        _faker = new Faker();
    }
    
    public static List<Contact> FakeContactList(int id, int contactCount, Account author)
    {
        var contacts = new List<Contact>();
        var contactId = id;
        for (var i = 0; i < contactCount; i++, contactId++)
        {
            var contact = new Contact()
            {
                Id = contactId,
                AuthorId = author.Id,
                Author = author,
                CreatedAt = _faker.Date.Recent(),
                Email = _faker.Person.Email,
                Name = _faker.Person.FirstName,
                Phone = _faker.Phone.PhoneNumber()
            };
            contacts.Add(contact);
        }

        return contacts;
    }
    
}