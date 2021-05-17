using System;
using System.Runtime.Serialization;
using Model.Enum;

namespace EntityFramework.Entity
{
    public class Order
    {
        [DataMember]
        public Guid OrderId { get; set; }

        [DataMember]
        public OrderType OrderType { get; set; }
    }
}