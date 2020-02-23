using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TeduCoreApp.Infrastructure.Interfaces
{
    /// <summary>
    /// Thực hiện cac thao tác với database
    /// </summary>
    /// <typeparam name="T"> Là một class entity</typeparam>
    /// <typeparam name="K">Là Key của Entity đó</typeparam>
    public interface IRepository<T,K> where T:class
    {
        T FindById(K id, params Expression<Func<T, object>>[] includeProperties);
        T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// Lấy tất cả object trong bảng về
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// Lấy tất cả object theo điều kiện
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(K id);
        void RemoveMultiple(List<T> entities);
    }
}
