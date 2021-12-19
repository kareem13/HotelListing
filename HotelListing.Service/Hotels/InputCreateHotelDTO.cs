using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Service.Hotels
{
    public class InputCreateHotelDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        [Required]
        public int Countryid { get; set; }
    }
}
