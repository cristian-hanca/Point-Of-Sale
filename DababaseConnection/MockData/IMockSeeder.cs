namespace DababaseConnection.MockData
{
    /// <summary>
    ///     Seed Methods used by DataBase Connection Module for Seeding the Database.
    /// </summary>
    public interface IMockSeeder
    {
        /// <summary>
        ///     Seeds the Currencies Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedCurrencies(DataContext context);

        /// <summary>
        ///     Seeds the Settings Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedSettings(DataContext context);

        /// <summary>
        ///     Seeds the Categories Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedCategories(DataContext context);

        /// <summary>
        ///     Seeds the Products Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedProducts(DataContext context);

        /// <summary>
        ///     Seeds the Customers Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedCustomers(DataContext context);

        /// <summary>
        ///     Seeds the Orders Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedOrders(DataContext context);

        /// <summary>
        ///     Seeds the Order Items Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedOrderItems(DataContext context);

        /// <summary>
        ///     Seeds the Order Events Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedOrderEvents(DataContext context);
    }
}