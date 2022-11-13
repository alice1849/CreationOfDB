using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HomeWork1
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public TitleConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.Id);
            builder.Property(t => t.Id).IsRequired().HasColumnName("TitleId").ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
        }
    }
}

