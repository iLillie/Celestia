using Celestia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celestia.Data.Configurations;

public class AccountEntityTypeConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("accounts");

        builder
            .Property(a => a.Name)
            .IsRequired()
            .HasMaxLength(40);
        builder
            .Property(a => a.LastName)
            .HasMaxLength(40);
        builder
            .Property(a => a.Alias)
            .HasMaxLength(80);
        builder
            .Property(a => a.AliasPreferred)
            .HasDefaultValue(false)
            .IsRequired();
        builder
            .Property(a => a.ImageUrl)
            .HasMaxLength(2000)
            .IsRequired();
        builder
            .Property(a => a.Email)
            .HasMaxLength(254)
            .IsRequired();

        builder
            .HasOne(a => a.Address);
    }
}