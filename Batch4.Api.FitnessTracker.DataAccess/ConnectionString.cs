using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.FitnessTracker.DataAccess;

public static class ConnectionString
{
    public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
    {
        DataSource = "SANDAR\\MSSQLSERVER2012",
        InitialCatalog = "SSDLDotNetCore",
        UserID = "sa",
        Password = "admin123!",
        TrustServerCertificate = true
    };
}
