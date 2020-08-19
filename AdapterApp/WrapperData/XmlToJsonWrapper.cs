using AdapterApp.Data;
using AdapterApp.JSONProvider;
using AdapterApp.XMLProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterApp.WrapperData
{
    public class XmlToJsonWrapper : IXmlToJson
    {
        private XmlFormatter xmlFormatter;

        public XmlToJsonWrapper(XmlFormatter xmlFormatter)
        {
            this.xmlFormatter = xmlFormatter;
        }

        public string ConvertXmlToJson()
        {
            var products = xmlFormatter.ReadXml()
                .Element("Products")
                .Elements("Product")
                .Select(node => new Product
                {
                    Name = node.Attribute("Description").Value,
                    Price = double.Parse(node.Attribute("Price").Value)
                });

            return new JsonFormatter(products).ReadJson();
        }
    }
}
