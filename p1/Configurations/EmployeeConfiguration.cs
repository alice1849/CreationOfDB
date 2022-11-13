using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HomeWork1
{
    public sealed class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.Id);
            builder.Property(e => e.Id).IsRequired().HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(e => e.HiredDate).IsRequired().HasColumnName("HireDate").HasColumnType("datetime2(7)");
            builder.Property(e => e.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date");
           
        }
    }
}

