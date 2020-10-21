﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheCashier
{
    class Item
    {
        private int id;

        public string title { get; set; }

        public int quantity { get; set; }

        public double price { get; set; }

        public double subtotal { get; set; }

        public string type;
        

        public Item(int id, string title, int quantity, double price, string type)
        {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.price = price;
            this.subtotal = 0;
            this.type = type;

        }

      
 

        public string getTitle()
        {
            return title;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public string getType()
        {
            return type;
        }
        public double getPrice()
        {
            return price;
        }
        public double getSubTotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }
    }
}
