using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp.Notifier
{
    public class MessageNotifier : IMessageNotifier
    {
        public void Send(string message, string handler)
        {
            Console.WriteLine($"the message '{message}'. Was sent by {handler}");
        }
    }
}
