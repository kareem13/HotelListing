using AutoMapper;
using HotelListing.Data.Entity;
using HotelListing.Service.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Service
{
    public class AutoMappers :Profile
    {
        public AutoMappers()
        {
            CreateMap<Country, InputCreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, InputCreateCountryDTO>().ReverseMap();
        }
    }
}
