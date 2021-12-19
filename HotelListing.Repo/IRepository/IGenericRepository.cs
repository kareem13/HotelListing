using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(Expression<Func<T, bool>> expression, List<string> include = null);
        Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null
            , Func<IQueryable<T>,
            IOrderedQueryable<T>> orderedby = null,List<string> include = null);
        Task Insert(T entity);
        Task Insertbulk(IEnumerable<T> entity);
        void Delete(int id);
        void Deletebulk(IEnumerable<T> entity); 

        void Update(T entity);
                
    }
}
