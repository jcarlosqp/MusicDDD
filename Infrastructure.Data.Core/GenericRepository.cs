using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Infrastructure.Data.Core
{
    
    public abstract class GenericRepository<T> : IRepository<T>
        where T : class, new()
    {
        //System.Data.Entity.Infrastucture _context;
        //public GenericRepository(MainModuleContext pContext)
        //{
        //    this._context = pContext;
        //}
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Modify(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
