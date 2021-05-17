using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework.Entity;

namespace EntityFramework.Repository
{
    public class OrderRepository : PaymentCommonRepository<Order>, IOrderRepository
    {
        public OrderRepository(OrderProcessingContext context) : base(context)
        {

        }
    }
}
