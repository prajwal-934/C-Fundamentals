using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Solid
{
    internal class OrderProcessor
    {
        private readonly OrderValidator orderValidator;
        private readonly OrderSaver orderSaver;
        private readonly OrderNotificationSender orderNotificationSender;

        public OrderProcessor(OrderValidator orderValidator, OrderSaver orderSaver, OrderNotificationSender orderNotificationSender)
        {
            this.orderValidator = orderValidator;
            this.orderSaver = orderSaver;
            this.orderNotificationSender = orderNotificationSender;
        }

        public void process()
        {
            orderValidator.Validate();
            orderSaver.Save(null);
            orderNotificationSender.SendNotification();
        }

    }

    class OrderValidator
    {
        public void Validate() { }
    }

    class OrderSaver
    {
        public void Save(string order) { }
    }

    class OrderNotificationSender
    {
        public void SendNotification() { }
    }
}
