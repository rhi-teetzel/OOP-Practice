using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; } 
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductCurrentPrice { get; set; } //the '?' makes it a nullable type, so 'null' is distinguished from zero
        public static int InstanceCount { get; set; }

        public Product Retrieve(int productId)
        {
            //code to retrieve one specific product
            return new Product();
        }

        public List<Product> Retrieve()
        {
            //code to retrieve list of all products
            return new List<Product>();
        }

        public bool Save()
        {
            //code to save
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (ProductCurrentPrice == null) isValid = false;

            return isValid;
        }



    }
}
