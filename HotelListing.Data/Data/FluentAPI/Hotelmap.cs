using HotelListing.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Data.FluentAPI
{
    public class Hotelmap
    {
        public Hotelmap(EntityTypeBuilder<Hotel> typeBuilder)
        {
            typeBuilder.HasKey(i => i.Id);
            typeBuilder.Property(i => i.Name).IsRequired();
            typeBuilder.HasData(
                new Hotel() { Id = 1, Name = "king", Address = "downtown" , Rating = 2.0 ,Countryid=1},
                new Hotel() { Id = 2, Name = "master", Address = "east", Rating = 3.0, Countryid = 2 },
                new Hotel() { Id = 3, Name = "legend", Address = "north", Rating = 5.0, Countryid = 3 });

        }
    }
}
