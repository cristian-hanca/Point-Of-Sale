﻿namespace MockData
{
    /// <summary>
    /// Seed Methods used by DataBase Connection Module for Seeding the Database.
    /// </summary>
    public interface IMockSeeder
    {
        /// <summary>
        /// Seeds the Categories Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedCategories(DababaseConnection.DataContext context);

        /// <summary>
        /// Seeds the Products Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedProducts(DababaseConnection.DataContext context);

        /// <summary>
        /// Seeds the Customers Table.
        /// </summary>
        /// <param name="context">Database Context</param>
        void SeedCustomers(DababaseConnection.DataContext context);
    }
}