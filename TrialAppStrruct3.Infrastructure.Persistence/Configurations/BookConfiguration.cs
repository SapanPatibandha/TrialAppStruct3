using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrialAppStruct3.Core.Domain.Entities;

namespace TrialAppStrruct3.Infrastructure.Persistence.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.BookID)
                .HasColumnName("BookID");

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}