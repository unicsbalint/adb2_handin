using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace adb2_handInProject
{
    public class OracleDatabaseConnection
    {
        public OracleConnection getConnection()
        {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = @"Data Source=193.225.33.71;User Id=QPS1MZ;Password=EKE2020;";
            return connection;
        }
        
    }
}
