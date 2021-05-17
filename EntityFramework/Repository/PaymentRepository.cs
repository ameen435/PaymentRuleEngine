using EntityFramework.Entity;

namespace EntityFramework.Repository
{
    public class PaymentRepository : PaymentCommonRepository<Payment>, IOrderRepository
    {
        public PaymentRepository(OrderProcessingContext context) : base(context)
        {

        }
    }
}
