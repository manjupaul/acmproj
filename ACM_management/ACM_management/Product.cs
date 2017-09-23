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
        public Product(int productId)
        {
            this.productId = productId;
        }
        public string productName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? price { get; set; }        
        public int productId { get; private set; }


        public bool validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(productName)) isValid = false;
            //if (string.IsNullOrWhiteSpace(productId)) isValid = false;
            return isValid;


        }
    }
}
