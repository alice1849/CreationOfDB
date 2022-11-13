using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork1
{
	public class ClientConfiguration : IEntityTypeConfiguration<Client>
	{
		public ClientConfiguration()
		{
		}

		public void Configure(EntityTypeBuilder<Client> builder)
		{
			builder.ToTable("Client").HasKey(c => c.Id);
			builder.Property(c => c.Id).IsRequired().HasColumnName("ClientId").ValueGeneratedOnAdd();
			builder.Property(c => c.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
			builder.Property(c => c.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
		}
	}
}


