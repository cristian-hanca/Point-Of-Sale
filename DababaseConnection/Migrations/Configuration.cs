using System.Data.Entity.Migrations;
using DababaseConnection.MockData;
using DababaseConnection.MockData.Implementation;

namespace DababaseConnection.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        ///     This method will be called after migrating to the latest version.
        ///     We use it in order to update the Data present in the database with Mock data.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DataContext context)
        {
            // Replace with custom implementation!
            SeedUsingMocks(new MockDataSeeder(), context);

            // In order to disable the use of Mock Data, comment the previous call and uncomment this line:
            //SeedUsingMocks(new EmptySeeder(), context);
        }

        /// <summary>
        ///     Seed Database using a custom Mock Seeder.
        /// </summary>
        /// <param name="seeder">Mock Seeder implementation</param>
        /// <param name="context">Database Context</param>
        private void SeedUsingMocks(IMockSeeder seeder, DataContext context)
        {
            seeder.SeedCategories(context);
            seeder.SeedProducts(context);
            seeder.SeedCustomers(context);
        }

        public void SeedSettings(DataContext context)
        {
            throw new System.NotImplementedException();
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

    }
}