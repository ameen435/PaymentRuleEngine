using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public interface IPaymentCommonRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
        TEntity GetByID(object id);
        IEnumerable<TEntity> GetAll();
    }
}
