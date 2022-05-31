﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            orderId = orderId;
        }

        public int OrderId { get; set; }
        public string OrderedProduct { get; set; }
        public int OrderQuantity { get; set; }
        public decimal? OrderPurchasePrice { get; set; }
        public static int InstanceCount { get; set; }
        
        public Order Retrieve(int orderId)
        {
            //code to retrieve order
            return new Order();
        }

        public List<Order> Retrieve()
        {
            //code to retrieve all orders
            return new List<Order>();
        }

        public bool Save()
        {
            //code to save order
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(OrderedProduct)) isValid = false;
            if (OrderPurchasePrice == null) isValid = false;
            return isValid;
        }

    }
}
