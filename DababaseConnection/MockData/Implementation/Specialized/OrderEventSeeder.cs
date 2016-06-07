using System;
using System.Data.Entity.Migrations;
using Models;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Settings.
    /// </summary>
    internal class OrderEventSeeder : BaseMockSeeder
    {
        private readonly Random _random;
        private readonly int _backTime = 7 * 24 * 60;

        public OrderEventSeeder()
        {
            _random = new Random();
        }

        public new void SeedOrderEvents(DataContext context)
        {
            foreach (Order order in context.Orders)
            {
                DateTime dateTime = DateTime.Now.AddMinutes(-1 * _random.Next(100, _backTime));
                context.OrderEvents.Add(CreateEvent(dateTime, order, OrderStatus.Created));

                dateTime = dateTime.AddMinutes(_random.Next(1, 10));
                if (_random.NextDouble() >= 0.85)
                {
                    context.OrderEvents.Add(CreateEvent(dateTime, order, OrderStatus.Canceled));
                    context.SaveChanges();
                    continue;
                }
                context.OrderEvents.Add(CreateEvent(dateTime, order, OrderStatus.Invoiced));

                dateTime = dateTime.AddMinutes(_random.Next(1, 90));
                if (_random.NextDouble() >= 0.85)
                {
                    context.OrderEvents.Add(CreateEvent(dateTime, order, OrderStatus.Canceled));
                    context.SaveChanges();
                    continue;
                }
                context.OrderEvents.Add(CreateEvent(dateTime, order, OrderStatus.Payed));

                context.SaveChanges();
            }
            context.SaveChanges();
        }

        private OrderEvent CreateEvent(DateTime dateTime, Order order, OrderStatus status)
        {
            return new OrderEvent
            {
                Order = order,
                DateTime = dateTime,
                Status = status
            };
        }
    }
}