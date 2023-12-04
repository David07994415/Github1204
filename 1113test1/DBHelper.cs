using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace test1109
{
    public class DBHelper
    {
        //建立SQL連接的物件,DbConnection是Web.cofig中自訂的變數名稱
        SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["OliverDB"].ConnectionString);
        //建立要操作SQL的指令物件

        SqlCommand sqlCommand = new SqlCommand();

        //連接到哪個資料庫
        private void ConnectDB()
        {
            //跟資料庫建立連線
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

        }

        internal void SearchDb()
        {
            throw new NotImplementedException();
        }

        //關閉資料庫
        public void CloseDb()
        {
            connection.Close();
        }

        //查詢資料庫
        public SqlDataReader SearchDb(string sql)
        {

            ConnectDB();

            sqlCommand.Connection = connection;
            sqlCommand.CommandText = sql;

            //執行該SQL查詢
            SqlDataReader reader = sqlCommand.ExecuteReader();

            //CloseDb();
            return reader;

        }

        internal SqlDataReader GetDataReader(string sql)
        {
            throw new NotImplementedException();
        }

     

        internal int ExecuteSQL(string sql)
        {
            throw new NotImplementedException();
        }

        internal void UpdateDb(string deleteSql, SqlParameter[] sqlParameters)
        {
            throw new NotImplementedException();
        }
    }
}