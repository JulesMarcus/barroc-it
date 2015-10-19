
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace barroc_IT
{
    class DatabaseHandler
    {
        private SqlConnection _conn;
        private SqlDataAdapter _da;
        private DataTable _dt;
        private SqlCommand _comm;

        public DatabaseHandler()
        {
            _conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\J. Marcus\Documents\GitHub\barroc-it\barroc_IT\barroc_IT\Database1.mdf;Integrated Security=True");
        }
        public void Query(string sqlQuery)
        {
            _comm = new SqlCommand(sqlQuery, _conn);
        }

        //Execute query (select from)
        public DataTable QueryEx(string query)
        {
            _conn.Open();
            _da = new SqlDataAdapter(query, _conn);
            _dt = new DataTable();
            _da.Fill(_dt);
            
            
            _conn.Close();
            return _dt;
        }
    }
}
