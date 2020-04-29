using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyBanHang
{
    class DAO
    {
        public static SqlConnection conn = new SqlConnection();
        public static string ConnectionString = "Data Source=DESKTOP-FUFFDKL;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        public static void  connect()
        {
            conn.ConnectionString = ConnectionString;
            conn.Open();

        }
        public static void closeConnect()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public static DataTable LoadDataToTable(string sql)
        {

            SqlDataAdapter MyData = new SqlDataAdapter();
            MyData.SelectCommand = new SqlCommand();
            MyData.SelectCommand.Connection = DAO.conn;
            MyData.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            MyData.Fill(table);
            return table;
        }
    }
}
