namespace HotelListing.Data.Entity
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public Country country { get; set; }
        public int Countryid { get; set; }
    }
}
