using System;
using System.Collections.Generic;
using System.Linq;
using DababaseConnection;
using Models;

namespace DataAccessExtensions
{
    public static class DataSamplerExtensions
    {

        public static List<Category> SampleCategories(this DataContext context, int count)
        {
            return context.Categories.OrderBy(o => Guid.NewGuid()).Take(count).ToList();
        }

        public static List<Product> SampleProducts(this DataContext context, int count)
        {
            return context.Products.OrderBy(o => Guid.NewGuid()).Take(count).ToList();
        }

        public static List<Customer> SampleCustomers(this DataContext context, int count)
        {
            return context.Customers.OrderBy(o => Guid.NewGuid()).Take(count).ToList();
        }

        public static List<Currency> SampleCurrencies(this DataContext context, int count)
        {
            return context.Currencies.OrderBy(o => Guid.NewGuid()).Take(count).ToList();
        }

    }
}
