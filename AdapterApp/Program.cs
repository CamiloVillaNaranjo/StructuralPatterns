using AdapterApp.JSONProvider;
using AdapterApp.XMLProvider;
using System;

namespace AdapterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = new XmlFormatter();
            Console.WriteLine("Data provided by Store.");
            Console.WriteLine(xml.ReadXml());
            Console.WriteLine(Environment.NewLine + ":*:*:---------------------------:*:*:" + Environment.NewLine);
            var wrapper = new WrapperData.XmlToJsonWrapper(xml);
            Console.WriteLine("Data converted to be stored on DB.");
            Console.WriteLine(wrapper.ConvertXmlToJson());
            Console.ReadLine();
        }
    }
}
