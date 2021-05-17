using System;
using System.Runtime.Serialization;

namespace Model.Request
{
    public class PaymentRequest
    {
        [DataMember]
        public Guid PaymentId { get; set; }

        [DataMember]
        public int PaymentProductId { get; set; }

        [DataMember]
        public string Product { get; set; }
    }
}