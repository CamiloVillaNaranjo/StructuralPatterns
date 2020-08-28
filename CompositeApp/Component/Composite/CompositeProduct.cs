using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeApp.Component.Composite
{
    public class CompositeProduct : Product, ICompositeProduct
    {
        List<Product> products = new List<Product>();

        public CompositeProduct(string name): base(name, 0){}
        public void Add(Product product)
        {
            products.Add(product);
        }
        public void Remove(Product product)
        {
            products.Remove(product);
        }
        public override double GetPrice()
        {
            return products.Sum(item => item.Price);
        }
    }
}
