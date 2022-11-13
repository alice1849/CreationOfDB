using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HomeWork1
{
	public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
	{
		public ApplicationContextFactory()
		{
		}

        public ApplicationContext CreateDbContext(string[] args)
        {
            var connectionString = "Data Source = 127.0.0.1; User ID = SA; Password = MyPass@word; Initial Catalog = Application";
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            return new ApplicationContext(options);
        }
    }
}


