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

        public int ProductId { get; private set; } 
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductCurrentPrice { get; set; } //the '?' makes it a nullable type, so 'null' is distinguished from zero
        public static int InstanceCount { get; set; }

        
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (ProductCurrentPrice == null) isValid = false;
            return isValid;
        }



    }
}
