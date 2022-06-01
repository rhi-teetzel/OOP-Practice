using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int OrderItemQuantity { get; set; }
        public decimal? OrderItemPurchasePrice { get; set; }
        
        public OrderItem Retrieve(int orderItemId)
        {
            //code to retrieve order
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            //code to retrieve all order items
            return new List<OrderItem>();
        }

        public bool Save()
        {
            //code to save order item
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderItemQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (OrderItemPurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}
