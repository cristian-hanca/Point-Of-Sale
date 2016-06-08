using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServerCompact;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DababaseConnection
{
    class DataConfiguration : DbConfiguration
    {
        public static readonly string ConnectionString =
            @"Data Source=C:\[Projects]\Point-Of-Sale\database.sdf;Encrypt Database=True;Password=myPassword;Persist Security Info=False;";

        public DataConfiguration()
        {
            SetProviderServices(SqlCeProviderServices.ProviderInvariantName,
                SqlCeProviderServices.Instance);

            SetDefaultConnectionFactory(new SqlCeConnectionFactory(SqlCeProviderServices.ProviderInvariantName));
        }

    }
}
