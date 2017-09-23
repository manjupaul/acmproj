using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM_management;

namespace ACM_management
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string productId)
        {
            this.productId = productId;
        }
        public string productName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? price { get; set; }
        public string productId { get; set; }

        public void save()
        {

        }
        public void retrive()
        {

        }
        public bool validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(productName)) isValid = false;
            if (string.IsNullOrWhiteSpace(productId)) isValid = false;
            return isValid;


        }
    }
}
