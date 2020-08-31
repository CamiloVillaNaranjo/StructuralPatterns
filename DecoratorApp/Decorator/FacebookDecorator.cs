using DecoratorApp.Notifier;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp.Decorator
{
    public class FacebookDecorator : MessageDecorator
    {
        public FacebookDecorator(IMessageNotifier messageNotifier) : base(messageNotifier)
        {
            plateform = "Facebook";
        }
    }
}
