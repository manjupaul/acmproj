using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM_management;

namespace ACM_management
{
    public class AddressRepository
    {
        public void AddressSave()
        {

        }
        public Address AddressRetrive(int AddressId)
        {
            var AddressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = "1",
                Streetline1 = "9991",
                Streetline2 = "Larks st1",
                City = "Midddle Earth1",
                State = "NC1",
                Postalcode = "22221",
                Country = "US",
            };
           
            AddressList.Add(address);
           address = new Address(2)
            {
                AddressType = "2",
                Streetline1 = "9991",
                Streetline2 = "Larks st1",
                City = "Midddle Earth1",
                State = "NC1",
                Postalcode = "22221",
                Country = "US",
            };
            AddressList.Add(address);
            return address;
        } 
        public List<Address> AddressRetrive()
        {
            return new List<Address>();
        }
    }
}
