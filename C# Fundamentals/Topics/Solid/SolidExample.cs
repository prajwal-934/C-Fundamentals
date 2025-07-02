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
        private readonly IOrderSaver[] orderSaver;
        private readonly OrderNotificationSender orderNotificationSender;

        public OrderProcessor(OrderValidator orderValidator, IOrderSaver[] orderSaver, OrderNotificationSender orderNotificationSender)
        {
            this.orderValidator = orderValidator;
            this.orderSaver = orderSaver;
            this.orderNotificationSender = orderNotificationSender;
        }

        public void process()
        {
            orderValidator.Validate();
            foreach (var item in orderSaver)
            {
                item.Save(null);
            }
            orderNotificationSender.SendNotification();
        }

    }

    public interface IOrderSaver
    {
        public void Save(string order);
    }

    public interface IOrderDeleter
    {
        public void Delete(int id);
    }

    public interface IOrderReader
    {
        string Read(int id);
    }

    class OrderValidator
    {
        public void Validate() { }
    }

    class DBOrderSaver : IOrderSaver
    {
        public void Save(string order) { }
    }


    class CacheOrderSaver : IOrderSaver
    {
        public void Save(string order) { }
    }


    class OrderNotificationSender
    {
        public void SendNotification() { }
    }
}
