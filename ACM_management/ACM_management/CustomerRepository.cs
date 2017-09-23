using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_management
{
   public class CustomerRepository
    {
        public void CustSave()
        {

        }
        public Customer CustRetrive(int CustomerId)
        {
            Customer customer = new Customer(1);
            if(CustomerId == 1)
            {                
                customer.firstName = "Jhon";
                customer.lastName = "Smith";
                customer.emailId = "jhon.smith@GMAIL.com";
            }
            return customer;
        }
        public List<Customer> CustRetrive()
        {
            return new List<Customer>();
        }
    }
}
