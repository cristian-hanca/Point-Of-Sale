using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DababaseConnection.MockData
{
    /// <summary>
    ///     Provides an Empty Mock Seeder Implementation.
    /// </summary>
    public sealed class EmptySeeder : IMockSeeder
    {
        /// <summary>
        ///     Base (empty) seed implementation.
        /// </summary>
        /// <param name="context">Database Context</param>
        public void SeedSettings(DataContext context)
        {
        }

        /// <summary>
        ///     Base (empty) seed implementation.
        /// </summary>
        /// <param name="context">Database Context</param>
        public void SeedCategories(DataContext context)
        {
        }

        /// <summary>
        ///     Base (empty) seed implementation.
        /// </summary>
        /// <param name="context">Database Context</param>
        public void SeedProducts(DataContext context)
        {
        }

        /// <summary>
        ///     Base (empty) seed implementation.
        /// </summary>
        /// <param name="context">Database Context</param>
        public void SeedCustomers(DataContext context)
        {
        }

        /// <summary>
        ///     Base (empty) seed implementation.
        /// </summary>
        /// <param name="context">Database Context</param>
        public void SeedOrders(DataContext context)
        {
        }

        /// <summary>
        ///     Base (empty) seed implementation.
        /// </summary>
        /// <param name="context">Database Context</param>
        public void SeedOrderItems(DataContext context)
        {
        }
    }
}
