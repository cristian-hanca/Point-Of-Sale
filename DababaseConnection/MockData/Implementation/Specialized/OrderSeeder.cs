using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Models;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Orders.
    /// </summary>
    internal class OrderSeeder : BaseMockSeeder
    {
        private readonly Random _random;
        private readonly int _count;

        /// <summary>
        ///     Creates a new Order Seeder that will generate the 125 Orders.
        /// </summary>
        public OrderSeeder() : this(125)
        {
        }


        /// <summary>
        ///     Creates a new Order Seeder that will generate the the given number of Orders.
        /// </summary>
        /// <param name="count">Number of Customers to generate.</param>
        public OrderSeeder(int count)
        {
            if (count < 0)
                throw new ArgumentException("Count less than 0", nameof(count));
            _random = new Random();
            _count = count;
        }

        public new void SeedOrders(DataContext context)
        {
            List<Order> orders = new List<Order>();
            Currency baseCurrency = context.Settingses.First().BaseCurrency;
            for (int i = 1; i <= _count; i++)
            {
                orders.Add(new Order
                {
                    Customer = context.Customers.OrderBy(o => Guid.NewGuid()).First(),
                    Currency = _random.NextDouble() < 0.8 
                        ? baseCurrency : context.Currencies.OrderBy(o => Guid.NewGuid()).First()
                });
            }

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }
    }
}