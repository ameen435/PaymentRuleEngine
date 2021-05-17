using System;
using System.Runtime.Serialization;

namespace EntityFramework.Entity
{
    public class Payment
    {
        [DataMember]
        public Guid PaymentId { get; set; }
    }
}