using DecoratorApp.Notifier;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp.Decorator
{
    public abstract class MessageDecorator : IMessageNotifier
    {
        IMessageNotifier messageNotifier;
        protected string plateform;

        public MessageDecorator(IMessageNotifier messageNotifier)
        {
            this.messageNotifier = messageNotifier;
        }

        public void Send(string message, string handler)
        {
            handler += $"{plateform}. ";
            messageNotifier.Send(message, handler);
        }
    }
}
