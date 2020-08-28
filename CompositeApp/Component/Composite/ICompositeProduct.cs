using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeApp.Component.Composite
{
    public interface ICompositeProduct
    {
        void Add(Product product);
        void Remove(Product product);
    }
}
