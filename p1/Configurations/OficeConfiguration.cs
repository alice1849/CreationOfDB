using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HomeWork1

{
    public class OficeConfiguration : IEntityTypeConfiguration<Ofice>
    {

        public void Configure(EntityTypeBuilder<Ofice> builder)
        {
            builder.ToTable("Ofice").HasKey(o => o.Id);
            builder.Property(o => o.Id).IsRequired().HasColumnName("OficeId").ValueGeneratedOnAdd();
            builder.Property(o => o.Title).IsRequired().HasColumnName("Title").HasMaxLength(100);
            builder.Property(o => o.Location).IsRequired().HasColumnName("Location").HasMaxLength(100);
        }
    }
}

