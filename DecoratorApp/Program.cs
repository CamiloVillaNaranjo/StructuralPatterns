using DecoratorApp.Decorator;
using DecoratorApp.Notifier;
using System;

namespace DecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var notifier = new SmsDecorator(new MessageNotifier());
            notifier.Send("please I need a PCI card for connect to network.", "");
            Console.ReadLine();
        }
    }
}



