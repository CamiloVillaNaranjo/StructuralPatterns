using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeApp.Component
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract double GetPrice();
    }
}
