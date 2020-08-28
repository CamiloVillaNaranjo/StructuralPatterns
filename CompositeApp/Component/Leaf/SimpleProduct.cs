using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeApp.Component.Leaf
{
    public class SimpleProduct : Product
    {
        public SimpleProduct(string name, double price) : base(name, price) { }
        
        public override double GetPrice()
        {
            return Price;
        }
    }
}
