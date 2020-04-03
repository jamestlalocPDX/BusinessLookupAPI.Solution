using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BusinessLookup.Models
{
  public class BusinessLookupFactory : IDesignTimeDbContextFactory<BusinessLookupContext>
  {

    BusinessLookupContext IDesignTimeDbContextFactory<BusinessLookupContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BusinessLookupContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new BusinessLookupContext(builder.Options);
    }
  }
}