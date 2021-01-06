using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;



namespace adb2_handInProject
{
    class teszt : OracleDatabaseConnection
    {
       public string test()
        {
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM CONT";
            OracleConnection connection = getConnection();
            connection.Open();    
            command.Connection = connection;

            OracleDataReader reader = command.ExecuteReader();

            string output = "asd";
            while (reader.Read())
            {
                output = reader["id"].ToString();
            }
            connection.Close();

            return output;
        }
    }
}
