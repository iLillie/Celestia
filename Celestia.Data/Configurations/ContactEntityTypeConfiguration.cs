using Celestia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celestia.Data.Configurations;

public class ContactEntityTypeConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder
            .HasOne(j => j.Author)
            .WithMany(a => a.Contacts)
            .HasForeignKey(j => j.AuthorId);

        builder
            .Property(c => c.Name)
            .HasMaxLength(40)
            .IsRequired();
        builder
            .Property(c => c.LastName)
            .HasMaxLength(40);
        builder
            .Property(c => c.Phone)
            .HasMaxLength(30);
        builder
            .Property(c => c.Email)
            .HasMaxLength(255);
        builder
            .Property(c => c.AdditionalNotes)
            .HasMaxLength(2000);
        
    }
}