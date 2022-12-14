using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Object
{
    internal class DeliveryObject
    {
        String id, status, payment;

        public string Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public string Payment { get => payment; set => payment = value; }

        public DeliveryObject() { }

        public DeliveryObject(string id, string status, string payment)
        {
            Id = id;
            Status = status;
            Payment = payment;
        }
    }
}
