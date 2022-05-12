using Celestia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celestia.Data.Configurations;

public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {

        builder.ToTable("companies");

        builder
            .Property(c => c.Name)
            .HasMaxLength(80)
            .IsRequired();

        builder
            .Property(c => c.Description)
            .HasMaxLength(5000);

        builder
            .Property(c => c.HomepageUrl)
            .HasMaxLength(2000)
            .IsRequired();
        
        builder
            .Property(c => c.LogoUrl)
            .HasMaxLength(2000)
            .IsRequired();

        builder.HasMany(c => c.Locations);

        builder
            .HasMany(c => c.Contacts)
            .WithOne(c => c.Company)
            .HasForeignKey(c => c.CompanyId);

        builder
            .HasOne(j => j.Author)
            .WithMany(a => a.Companies)
            .HasForeignKey(j => j.AuthorId);
    }
}