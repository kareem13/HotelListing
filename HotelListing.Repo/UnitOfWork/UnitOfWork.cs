using HotelListing.Data.Entity;
using HotelListing.IRepository;
using HotelListing.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Repo.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Country> _Countries;
        private IGenericRepository<Hotel> _Hotels;
        public UnitOfWork(ApplicationDbContext context)
        {
            context = _context;
        }
        public IGenericRepository<Country> Countries => _Countries ??= new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _Hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
         await _context.SaveChangesAsync();
        }
    }
}
