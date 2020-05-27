using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrialAppStruct3.Core.Domain.Entities;

namespace TrialAppStrruct3.Infrastructure.Persistence.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.Property(p => p.PublisherID)
                .HasColumnName("PublisherID");

            builder.Property(p => p.PublishingHouse)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Address)
                .HasMaxLength(250);
        }
    }
}