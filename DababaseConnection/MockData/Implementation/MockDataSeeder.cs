﻿using System;
using DababaseConnection.MockData.Implementation.Specialized;

namespace DababaseConnection.MockData.Implementation
{
    internal class MockDataSeeder : IMockSeeder
    {
        public void SeedCurrencies(DataContext context)
        {
            new CurrencySeeder().SeedCurrencies(context);
        }

        public void SeedSettings(DataContext context)
        {
            new SettingsSeeder().SeedSettings(context);
        }

        public void SeedCategories(DataContext context)
        {
            new CategorySeeder().SeedCategories(context);
        }

        public void SeedProducts(DataContext context)
        {
            new ProductSeeder().SeedProducts(context);
        }

        public void SeedCustomers(DataContext context)
        {
            new CustomerSeeder().SeedCustomers(context);
        }

        public void SeedOrders(DataContext context)
        {
            new OrderSeeder().SeedOrders(context);
        }

        public void SeedOrderItems(DataContext context)
        {
            new OrderItemSeeder().SeedOrderItems(context);
        }

        public void SeedOrderEvents(DataContext context)
        {
            new OrderEventSeeder().SeedOrderEvents(context);
        }
    }
}