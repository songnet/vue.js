using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFKS.Check.Search.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class SQLBaseRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings["PersonCheck"].ToString();
                return _connectionString;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
