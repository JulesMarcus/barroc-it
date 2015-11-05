
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Collections.Generic;


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
            _conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Dimitri\Documents\GitHub\Barroc-IT\barroc_IT\barroc_IT\Database1.mdf;Integrated Security=True");
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
        //insert command
        public void insertCmd(string tableName, Dictionary<string, object> dic)
        {
            string keys = "";
            string values = "";
            for (int i = 0; i < dic.Count; i++)
            {
                keys += dic.Keys.ElementAt(i) + " ,";
                values += "'" + dic.Values.ElementAt(i) + "' ,";
            }
            keys = keys.Remove(keys.Length - 1);
           values = values.Remove(values.Length - 1);
            SqlCommand cmd = new SqlCommand("INSERT INTO " +tableName+ " (" + keys + ") VALUES (" + values + ") " , _conn);
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void updateCmd(string tableName, Dictionary<string, object> dic)
        {
            string keys = "";
            string values = "";
            object outValue = (string)"";
            dic.TryGetValue("company_Name",out outValue);
            
            for (int i = 0; i < dic.Count; i++)
            {
                keys += dic.Keys.ElementAt(i) + " ,";
                values += "'" + dic.Values.ElementAt(i) + "' ,";
            }
            keys = keys.Remove(keys.Length - 1);
            values = values.Remove(values.Length - 1);
            
            SqlCommand cmd_Delete = new SqlCommand("DELETE FROM " +tableName+ " WHERE company_Name = " +" '" +outValue+ "'", _conn);
            SqlCommand cmd_Insert = new SqlCommand("INSERT INTO " + tableName + " (" + keys + ") VALUES (" + values + ") ", _conn);
            _conn.Open();
            cmd_Delete.ExecuteNonQuery();
            cmd_Insert.ExecuteNonQuery();
            _conn.Close();
        }
       

        //Method to flip the dataset
        public DataSet FlipDataSet(DataSet my_DataSet)
        {
            DataSet ds = new DataSet();

            foreach (DataTable dt in my_DataSet.Tables)
            {
                DataTable table = new DataTable();

                for (int i = 0; i <= dt.Rows.Count; i++)
                { table.Columns.Add(); }

                DataRow r;
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    r = table.NewRow();
                    r[0] = dt.Columns[k].ToString();
                    for (int j = 1; j <= dt.Rows.Count; j++)
                    { r[j] = dt.Rows[j - 1][k]; }
                    table.Rows.Add(r);
                }
                ds.Tables.Add(table);
            }

            return ds;
        }
        
        //Method to get the flipped dataview for the dataviewgrid
        public DataView GetDataView(string tbl, string col = " * ", bool cust = false, string where = "")
        {
            string qry = "";
            if (!cust)
            {
                qry += "SELECT " + col + " ";
                qry += "FROM " + tbl + " ";
                if (where != "")
                {
                    qry += "WHERE " + where;
                }
            }
            else
            {
                qry = tbl;
            }
            

            DataSet x = new DataSet();
            x.Tables.Add(QueryEx(qry));
            DataSet new_x = FlipDataSet(x);
            DataView y = new_x.Tables[0].DefaultView;
            return y;
        }
    }
}
