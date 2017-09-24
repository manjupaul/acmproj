using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_management
{

    public class Address
    {
        public Address()
        {

        }
        public Address(int AddressId)
        {
            this.AddressId = AddressId;

        }    
        public int AddressId { get; set; }
        public string AddressType { get; set; }
        public string Streetline1 { get; set; }
        public string Streetline2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postalcode { get; set; }
        public string Country { get; set; }
    }
}

