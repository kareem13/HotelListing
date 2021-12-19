using HotelListing.Data.FluentAPI;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {}

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new Hotelmap(modelBuilder.Entity<Hotel>());
            new Countrymap(modelBuilder.Entity<Country>()); 
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
