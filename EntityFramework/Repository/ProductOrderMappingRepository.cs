using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework.Entity;

namespace EntityFramework.Repository
{
    public class ProductOrderMappingRepository : PaymentCommonRepository<ProductOrderMapping>, IOrderRepository
    {
        public ProductOrderMappingRepository(OrderProcessingContext context) : base(context)
        {

        }
    }
}
