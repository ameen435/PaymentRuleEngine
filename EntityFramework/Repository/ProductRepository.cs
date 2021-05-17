using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework.Entity;

namespace EntityFramework.Repository
{
    public class ProductRepository : PaymentCommonRepository<Product>, IOrderRepository
    {
        public ProductRepository(OrderProcessingContext context) : base(context)
        {

        }
    }
}