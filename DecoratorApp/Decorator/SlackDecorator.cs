using DecoratorApp.Notifier;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp.Decorator
{
    public class SlackDecorator : MessageDecorator
    {
        public SlackDecorator(IMessageNotifier messageNotifier):base(messageNotifier)
        {
            plateform = "Slack";
        }
    }
}
