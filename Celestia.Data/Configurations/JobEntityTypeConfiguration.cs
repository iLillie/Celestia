using Celestia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celestia.Data.Configurations;

public class JobEntityTypeConfiguration : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder)
    {
        builder.ToTable("jobs");

        builder
            .Property(j => j.Title)
            .HasMaxLength(100)
            .IsRequired();
        
        builder
            .Property(j => j.Description)
            .HasMaxLength(5000)
            .IsRequired();

        builder
            .Property(j => j.PostingUrl)
            .HasMaxLength(2000);
        
        builder
            .Property(j => j.ApplicationUrl)
            .HasMaxLength(2000);
        
        builder
            .Property(j => j.AdditionalNotes)
            .HasMaxLength(2000);

        builder.Property(j => j.Status)
            .HasConversion<string>();

        builder.HasOne(j => j.Address);

        builder
            .HasMany(j => j.Tags);

        builder
            .HasOne(j => j.JobBoard)
            .WithMany(a => a.Jobs)
            .HasForeignKey(j => j.JobBoardId);
        
        builder
            .HasOne(j => j.Author)
            .WithMany(a => a.Jobs)
            .HasForeignKey(j => j.AuthorId);
    }
}