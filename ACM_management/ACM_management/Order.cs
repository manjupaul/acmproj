using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_management
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int OrderId)
        {
            this.OrderId = OrderId;
        }
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public string OrderAddress { get; set; }
        
        public bool validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(OrderAddress)) isValid = false;
           // if (string.IsNullOrWhiteSpace(OrderId)) isValid = false;
            return isValid;


        }
    }
}
