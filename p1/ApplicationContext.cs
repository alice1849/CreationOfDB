using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWork1
{
    public class ApplicationContext : DbContext
    {
        
        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        
        public DbSet<Ofice> Ofices { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Title> Titles { get; set; }

        public DbSet<Client> Clients { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
        }
    }   
}

