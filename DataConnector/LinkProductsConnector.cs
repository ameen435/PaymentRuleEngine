using System;
using EntityFramework;

namespace DataConnector
{
    public class LinkProductsConnector
    {
        public OrderProcessingContext context;

        public LinkProductsConnector(OrderProcessingContext context)
        {
            this.context = context;
        }
    }
}
