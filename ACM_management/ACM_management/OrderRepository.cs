using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM_management;

namespace ACM_management
{
   public class OrderRepository
    {
        public void OrderSave()
        {

        }
        public Order OrderRetive(int OrderId)
        {
            Order order = new Order(2);
            if (order.OrderId == 1)
            {
                order.OrderAddress = "Washington";
                //order.OrderDate = "9"/"23"/"2017";
               
            }

            return order;

        }
        public List<Order> OrderRetrive()
        {
            return new List<Order>();
        }

    }


    
   

    
}
