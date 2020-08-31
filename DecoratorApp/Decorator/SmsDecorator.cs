using DecoratorApp.Notifier;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp.Decorator
{
    public class SmsDecorator : MessageDecorator
    {
        public SmsDecorator(IMessageNotifier messageNotifier) : base(messageNotifier)
        {
            plateform = "SMS";
        }
    }
}
