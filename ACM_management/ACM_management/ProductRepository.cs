using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_management
{
    public class ProductRepository
    {
        public void ProductSave()
        {

        }
        public Product ProductRetrive(int ProductId)
        {
            Product product = new Product(1);            
                if (ProductId == 2)
                {
                    product.productName = "Computer";
                    product.ProductDescription = "Different Types";
                    product.price = 500;
                }

                return product;            

        }
        
        public List<Product> ProductRetrive()
        {
            return new List<Product>();
        }


    }
}
