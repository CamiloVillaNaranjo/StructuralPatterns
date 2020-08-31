using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorApp.Notifier
{
    public interface IMessageNotifier
    {
        void Send(string message, string handler);
    }
}
