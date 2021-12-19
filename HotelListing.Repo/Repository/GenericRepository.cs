using HotelListing.Data.Entity;
using HotelListing.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext Context;
        private readonly DbSet<T> _db;
        public GenericRepository(ApplicationDbContext _context)
        {
            _context = Context;
            _db = _context.Set<T>();
        }
        public async void Delete(int id)
        {
         var entity=await _db.FindAsync(id);
            Context.Remove(entity); 
        }

        public void Deletebulk(IEnumerable<T> entity)
        {
           _db.RemoveRange(entity);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> include = null)
        {
            IQueryable<T> query = _db;
            if (include != null) 
            {foreach (var includeprop in include)
                    query = query.Include(includeprop);
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderedby = null, List<string> include = null)
        {
            IQueryable<T> query = _db;
            if (expression != null)
            { query = query.Where(expression);}
            
            if (include != null)
            {
                foreach (var includeprop in include)
                    query = query.Include(includeprop);
            }
            if (orderedby != null) 
            { query = orderedby(query); }
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(T entity)
        {
          await _db.AddAsync(entity);
        }

        public async Task Insertbulk(IEnumerable<T> entity)
        {
           await _db.AddRangeAsync(entity);
        }

        public void Update(T entity)
        {
           _db.Attach(entity);
           Context.Entry(entity).State = EntityState.Modified; 
        }
    }
}
