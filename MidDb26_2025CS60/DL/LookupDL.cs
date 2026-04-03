using System.Data;
using MySql.Data.MySqlClient;
using MidDb26_2025CS60.Utilities;

namespace MidDb26_2025CS60.DL
{
    public class LookupDL
    {
      
        public DataTable GetByCategory(string category)
        {
            string query = $"SELECT LookupId, Name FROM lookup WHERE Category='{category}'";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
