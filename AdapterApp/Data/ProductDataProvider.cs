using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterApp.Data
{
    public static class ProductDataProvider
    {
        public static List<Product> GetProducts() => new List<Product>
        {
            new Product("Samsung A70",1500000),
            new Product("Lenovo Think L300", 2597000),
            new Product("Samsung S7", 750000)
        };
    }
}
