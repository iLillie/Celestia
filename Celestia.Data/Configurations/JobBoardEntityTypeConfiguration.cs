using Celestia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Celestia.Data.Configurations;

public class JobBoardEntityTypeConfiguration : IEntityTypeConfiguration<JobBoard>
{
    public void Configure(EntityTypeBuilder<JobBoard> builder)
    {
        builder.ToTable("job_boards");

        builder
            .Property(j => j.Name)
            .HasMaxLength(80)
            .IsRequired();
        
        builder
            .HasOne(j => j.Author)
            .WithMany(a => a.JobBoards)
            .HasForeignKey(j => j.AuthorId);
    }
}