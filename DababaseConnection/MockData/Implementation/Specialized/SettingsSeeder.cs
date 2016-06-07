using System.Data.Entity.Migrations;
using Models;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Categories.
    /// </summary>
    internal class SettingsSeeder : BaseMockSeeder
    {
        public new void SeedSettings(DataContext context)
        {
            context.Settingses.AddOrUpdate(
                new Settings
                {
                    BaseCurrency = "RON"
                });
            context.SaveChanges();
        }
    }
}