using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        /*
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Procurar(params object[] key);
        T Primeiro(Expression<Func<T, bool>> predicate);
        */
        void Add(T entity);
        void Modify(T entity);
        void Delete(T entity);

    }
}
