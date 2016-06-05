using System;
using DababaseConnection.MockData.Implementation.Specialized;

namespace DababaseConnection.MockData.Implementation
{
    internal class MockDataSeeder : IMockSeeder
    {
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
    }
}