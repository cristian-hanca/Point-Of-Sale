using System.Data.Entity.Migrations;
using Models;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Settings.
    /// </summary>
    internal class CurrencySeeder : BaseMockSeeder
    {
        public new void SeedCurrencies(DataContext context)
        {
            context.Currencies.AddOrUpdate(
                new Currency
                {
                    Code = "RON",
                    Name = "Romanian Leu",
                    ToBase = 1
                },
                new Currency
                {
                    Code = "EUR",
                    Name = "Euro",
                    ToBase = (decimal)0.22186
                },
                new Currency
                {
                    Code = "USD",
                    Name = "US Dollar",
                    ToBase = (decimal)0.25177
                },
                new Currency
                {
                    Code = "GBP",
                    Name = "British Pound",
                    ToBase = (decimal)0.17279
                });
            context.SaveChanges();
        }
    }
}