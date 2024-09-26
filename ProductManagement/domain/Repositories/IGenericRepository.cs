using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIDAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        void AddAsync(T entity);

        void AddRangeAsync(IEnumerable<T> entities);

        void RemoveAsync(T entity);

        void RemoveRangeAsync(IEnumerable<T> entities);
    }
}
