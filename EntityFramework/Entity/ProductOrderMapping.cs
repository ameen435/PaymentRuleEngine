using System;
using System.Runtime.Serialization;

namespace EntityFramework.Entity
{
    public class ProductOrderMapping
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public Guid OrderId { get; set; }

        [DataMember]
        public Guid ProductId { get; set; }
    }
}