using System;
using System.Collections.Generic;
using System.Text;
using AdapterApp.Data;
using Newtonsoft.Json;

namespace AdapterApp.JSONProvider
{
    public class JsonFormatter
    {
        private IEnumerable<Product> products;
        public JsonFormatter(IEnumerable<Product> products)
        {
            this.products = products;
        }
        public string ReadJson() {
            return JsonConvert.SerializeObject(products, Formatting.Indented);
        }
    }
}
