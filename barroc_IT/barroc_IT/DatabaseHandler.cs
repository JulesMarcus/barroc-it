﻿
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System;
using System.Collections;

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
        public void Update(string query, string table)
        {
            _da = new SqlDataAdapter(query, _conn);
            DataSet x = new DataSet(query);
            SqlCommandBuilder cmd = new SqlCommandBuilder(_da);
            _da.Update(x, table);
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
        public DataView GetDataView(string query)
        { 
            DataSet x = new DataSet();
            x.Tables.Add(QueryEx(query));
            DataSet new_x = FlipDataSet(x);
            DataView y = new_x.Tables[0].DefaultView;
            return y;
        }
    }
}
