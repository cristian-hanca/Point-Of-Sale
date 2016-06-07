using System;

namespace DababaseConnection.MockData
{
    /// <summary>
    ///     Base Implementation of the Mock Seeder that returns NotImplementedException for each Method.
    ///     The use of this Class is to provide a base for Specialized Mock Seeders (like the CategorySeeder)
    ///     such tahat, when the Models (and thus Context) change (by adding a new Table to be mocked, for example)
    ///     only this base class will need to be updated!
    ///     We also make this class Abstract such to not confuse this Class with a functioning one.
    /// </summary>
    internal abstract class BaseMockSeeder : IMockSeeder
    {
        public void SeedSettings(DataContext context)
        {
            throw new NotImplementedException();
        }

        public void SeedCategories(DataContext context)
        {
            throw new NotImplementedException();
        }

        public void SeedProducts(DataContext context)
        {
            throw new NotImplementedException();
        }

        public void SeedCustomers(DataContext context)
        {
            throw new NotImplementedException();
        }
    }
}