using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HomeWork1
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public ProjectConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.Id);
            builder.Property(p => p.Id).IsRequired().HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnName("Budget").HasColumnType("money");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2(7)");
            

        }
    }
}

