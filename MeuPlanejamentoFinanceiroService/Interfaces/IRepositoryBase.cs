using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MeuPlanejamentoFinanceiroService.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
        T Find(params object[] keyValues);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
