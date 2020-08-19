using AdapterApp.Data;
using System.Linq;
using System.Xml.Linq;

namespace AdapterApp.XMLProvider
{
    public class XmlFormatter
    {
        public XDocument ReadXml()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Products");
            var xAttributes = ProductDataProvider.GetProducts()
                .Select(m => new XElement("Product",
                new XAttribute("Description", m.Name), new XAttribute("Price", m.Price)));
            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}
