using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            //Create the instance of the Product class
            //Pass in the requested id
            Product product = new Product(productId);

            //Code that retrieves the defined product

            //Temporary hard-coded values to return a populated product
            if (productId == 2)
            {
                product.ProductName = "Ring";
                product.ProductDescription = "The One Ring To Rule Them All";
                product.ProductCurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            //Code that saves the passed-in product

            return true;
        }
}
