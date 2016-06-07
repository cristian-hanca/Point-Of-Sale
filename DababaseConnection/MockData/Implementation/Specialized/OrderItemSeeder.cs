using System;
using System.Linq;
using Models;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Order Items.
    /// </summary>
    internal class OrderItemSeeder : BaseMockSeeder
    {
        private readonly Random _random;
        private readonly int _minItems;
        private readonly int _maxItems;
        private readonly int _minQuantity;
        private readonly int _maxQuantity;
        private readonly double _priceChange;

        /// <summary>
        ///     Creates a new Order Seeder that will generate, for each Order, Items in rage of 1 to 10,
        ///     with a Price change likelyhood of 0.2 and quantities in the range 1 to 25.
        /// </summary>
        public OrderItemSeeder() : this(1, 10, 1, 25, 0.2)
        {
        }

        /// <summary>
        ///     Creates a new Order Items Seeder that will generate, for each order, a random number 
        ///     between Min and Max of Items, each having quantities in the provided range, 
        ///     with the provided likelyhood for a Price Change.
        /// </summary>
        /// <param name="minItems">Minimum number of Items per Order.</param>
        /// <param name="maxItems">Maximum number of Items per Order.</param>
        /// <param name="minQuantity">Minimum quantity.</param>
        /// <param name="maxQuantity">Maximum quantity.</param>
        /// <param name="priceChange">Likelyhood of a Price change.</param>
        public OrderItemSeeder(int minItems, int maxItems, int minQuantity, int maxQuantity, double priceChange)
        {
            if (minItems <= 0)
                throw new ArgumentOutOfRangeException(nameof(minItems), "Minimum less than or equal to 0");
            if (minItems > maxItems)
                throw new ArgumentOutOfRangeException(nameof(maxItems), "Max less than Min");
            if (minQuantity <= 0)
                throw new ArgumentOutOfRangeException(nameof(minQuantity), "Minimum less than or equal to 0");
            if (minQuantity > maxQuantity)
                throw new ArgumentOutOfRangeException(nameof(maxQuantity), "Max less than Min");
            if (priceChange < 0 || priceChange > 1)
                throw new ArgumentOutOfRangeException(nameof(priceChange), "Price change not in range [0, 1]");

            _random = new Random();
            _minItems = minItems;
            _maxItems = maxItems;
            _minQuantity = minQuantity;
            _maxQuantity = maxQuantity;
            _priceChange = priceChange;
        }

        public new void SeedOrderItems(DataContext context)
        {
            foreach (Order order in context.Orders)
            {
                int limit = _random.Next(_minItems, _maxItems);
                var products = context.Products.OrderBy(o => Guid.NewGuid()).Take(limit).ToList();
                
                for (int i = 0; i < limit; i++)
                {
                    OrderItem item =  new OrderItem
                    {
                        Order = order,
                        Product = products[i],
                        Quantity = _random.Next(_minQuantity, _maxQuantity) * (_random.NextDouble() >= 0.5 ? 1 : -1)
                    };

                    if (_random.NextDouble() <= _priceChange)
                    {
                        decimal original = item.Product.Price;
                        item.AlterPrice = original + (original * (decimal)0.1 * (_random.NextDouble() >= 0.5 ? 1 : -1));
                    }

                    context.OrderItems.Add(item);
                }

                context.SaveChanges();
            }

        }
    }
}