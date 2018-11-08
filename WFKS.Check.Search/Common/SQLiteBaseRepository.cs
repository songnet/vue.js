using System.Configuration;
using System.Data.SQLite;

namespace WFKS.Check.Search.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class SQLiteBaseRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SQLiteConnection SimpleDbConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["Sqlite"].ConnectionString;
            return new SQLiteConnection(connString);
        }
    }
}
