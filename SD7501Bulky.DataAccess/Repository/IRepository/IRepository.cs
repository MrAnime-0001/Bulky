using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SD7501Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T - Category
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        // We will remove the Update method as the user might update a few properties and not all.
        // void Update(T entity);
    }
}
