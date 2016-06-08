using System.Linq;
using DababaseConnection;
using Models;

namespace DataAccessExtensions
{
    public static class DataAccessExtensions
    {
        
        public static Category FindCategoryByName(this DataContext context, string name)
        {
            return context.Categories.First(x => x.Name.Equals(name));
        }

        public static Product FindProductByName(this DataContext context, string name)
        {
            return context.Products.First(x => x.Name.Equals(name));
        }

        public static Customer FindCustomerByCnp(this DataContext context, string cnp)
        {
            return context.Customers.First(x => x.Cnp.Equals(cnp));
        }

        public static Currency FindCurrencyByCode(this DataContext context, string code)
        {
            return context.Currencies.First(x => x.Code.Equals(code));
        }

    }
}
