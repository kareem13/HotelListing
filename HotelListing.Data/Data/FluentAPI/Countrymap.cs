using HotelListing.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Data.FluentAPI
{
    public class Countrymap
    {
        public Countrymap(EntityTypeBuilder<Country> typeBuilder)
        {
         typeBuilder.HasKey(i => i.Id);    
         typeBuilder.Property(i =>i.Name).IsRequired();
         typeBuilder.Property(i => i.Shortname).IsRequired();
            typeBuilder.HasData(
                new Country() { Id = 1, Name = "egypt", Shortname = "egp" },
                new Country() { Id = 2, Name = "italy", Shortname = "ity" },
                new Country() { Id = 3, Name = "german", Shortname = "ger" });
        }
    }
}
