using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Bankomat
{
    class DataAccessLayer
    {
        SqlConnection sqlConnection = 
            new SqlConnection(ConfigurationManager.ConnectionStrings["Bankomat.Properties.Settings.Database1ConnectionString"].ConnectionString);

        // for SELECT to get DataTable Object
        public DataTable selectData(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // for SELECT to get stream of rows
        public SqlDataReader returnReader(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = sqlConnection;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            return reader;
        }

        public void connectionOpen()
        {
            sqlConnection.Open();
            Console.WriteLine("BAZA OTWARTA");
        }

        public void connectionClose()
        {
            sqlConnection.Close();
            Console.WriteLine("BAZA ZAMKNIETA");
        }


        //for INSERT, UPDATE, DELETE
        public void queryExecution(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
        }

    }
}
