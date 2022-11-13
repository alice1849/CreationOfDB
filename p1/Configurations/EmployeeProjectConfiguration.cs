using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork1
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
       
    {
        public EmployeeProjectConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.Id);
            builder.Property(e => e.Id).IsRequired().HasColumnName("EmployeeProjectid").ValueGeneratedOnAdd();
            builder.Property(e => e.Rate).IsRequired().HasColumnName("Rate").HasColumnType("money");
            builder.Property(e => e.StartDate).IsRequired().HasColumnName("StartDate").HasColumnType("datetime2(7)");

        }
    }
}

