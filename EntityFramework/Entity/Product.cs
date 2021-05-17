using System;
using System.Runtime.Serialization;
using Model.Enum;

namespace EntityFramework.Entity
{
    public class Product
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public Guid ProductId { get; set; }

        [DataMember]
        public ProductType ProductType { get; set; }
    }
}