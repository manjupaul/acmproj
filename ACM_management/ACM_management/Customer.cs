﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_management
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailId { get; set; }
        public int custId { get; private set; }
        
        public Customer():this(0)
        {

        }
        public Customer(int custId)
        {
            this.custId = custId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public string fullName
        {
            get
            {
                return firstName +" "+ lastName;
            }
        }
        public bool validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(lastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(emailId)) isValid = false;
            return isValid;
            
        }
        
    }
}
