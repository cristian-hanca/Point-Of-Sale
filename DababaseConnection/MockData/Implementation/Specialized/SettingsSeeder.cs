using System.Data.Entity.Migrations;
using System.Linq;
using Models;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Settings.
    /// </summary>
    internal class SettingsSeeder : BaseMockSeeder
    {
        public new void SeedSettings(DataContext context)
        {
            context.Settingses.AddOrUpdate(
                new Settings
                {
                    BaseCurrency = context.Currencies.First(x => x.Code.Equals("RON"))
                });
            context.SaveChanges();
        }
    }
}