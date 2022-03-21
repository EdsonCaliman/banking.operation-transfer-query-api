using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Net.Core.Template.Domain.Abstractions.Repositories
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> Get();
        Task<T> FindOne(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
