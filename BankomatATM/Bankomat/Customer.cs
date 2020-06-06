using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bankomat
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long PhoneNo { get; set; }
        public string Address { get; set; }
        public long PersonalID { get; set; }

        public int getCustomerID(long personalID)
        {
            string query = "Select CustomerID From Customers Where PersonalID = @personalID";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@personalID", personalID);
            DataAccessLayer dal = new DataAccessLayer();
            dal.connectionOpen();
            SqlDataReader reader = dal.returnReader(sqlCommand);
            if (reader.HasRows)
            {
                reader.Read();
                this.CustomerID = Convert.ToInt32(reader[0]);
                reader.Close();
                dal.connectionClose();
                return this.CustomerID;
            } else
            {
                dal.connectionClose();
                return -1;
            }
        }

        public bool getCustomerInfo(long personalID)
        {
            string query = "Select CustomerID, Name, Surname, PhoneNo, Address, PersonalID From Customers Where PersonalID = @personalID";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@personalID", personalID);
            DataAccessLayer dal = new DataAccessLayer();
            dal.connectionOpen();
            SqlDataReader reader = dal.returnReader(sqlCommand);
            if (reader.HasRows)
            {
                reader.Read();
                this.CustomerID = Convert.ToInt32(reader[0]);
                this.Name = reader[1].ToString();
                this.Surname = reader[2].ToString();
                this.PhoneNo = Convert.ToInt64(reader[3]);
                this.Address = reader[4].ToString();
                this.PersonalID = Convert.ToInt64(reader[5]);
                reader.Close();
                dal.connectionClose();
                return true;
            }
            else
            {
                dal.connectionClose();
                return false;
            }
        }

    }
}
