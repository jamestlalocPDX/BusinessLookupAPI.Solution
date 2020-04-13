using Microsoft.EntityFrameworkCore;

namespace BusinessLookup.Models
{
  public class BusinessLookupContext : DbContext
  {
    public BusinessLookupContext(DbContextOptions<BusinessLookupContext> options)
        : base(options)
    {
    }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
      .HasData(
        new Business { BusinessId = 1, Name = "Hooligans", Description = "We sell tom foolery items.", Established = "2004", Owner = "John" },
        new Business { BusinessId = 2, Name = "Golf N Stuff", Description = "We sell golfing equipment and more.", Established = "1993", Owner = "Ernesto" },
        new Business { BusinessId = 3, Name = "Phones and More", Description = "We sell the latest tech cell phones.", Established = "2007", Owner = "George" },
        new Business { BusinessId = 4, Name = "Surfboards R Us", Description = "We sell the gnarliest surfboards.", Established = "1978", Owner = "Andy" }
    );
    }
  }
}