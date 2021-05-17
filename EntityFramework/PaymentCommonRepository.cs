using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class PaymentCommonRepository<TEntity> : IPaymentCommonRepository<TEntity> where TEntity : class
    {
        internal OrderProcessingContext _context;
        internal DbSet<TEntity> dbSet;

        public PaymentCommonRepository(OrderProcessingContext context)
        {
            _context = context;
            dbSet = context.Set<TEntity>();
        }

        IEnumerable<TEntity> IPaymentCommonRepository<TEntity>.GetAll()
        {
            return dbSet.ToList();
        }

        TEntity IPaymentCommonRepository<TEntity>.GetByID(object id)
        {
            return dbSet.Find(id);
        }

        void IPaymentCommonRepository<TEntity>.Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        void IPaymentCommonRepository<TEntity>.Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
