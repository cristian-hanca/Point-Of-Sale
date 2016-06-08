using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServerCompact;

namespace DababaseConnection
{
    class DataConfiguration : DbConfiguration
    {
        public DataConfiguration()
        {
            SetProviderServices(SqlCeProviderServices.ProviderInvariantName,
                SqlCeProviderServices.Instance);

            SetDefaultConnectionFactory(new SqlCeConnectionFactory(SqlCeProviderServices.ProviderInvariantName));
        }

    }
}
