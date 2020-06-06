using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bankomat
{
    class BankAccount
    {
        public int AccountID { get; set; }
        public int CustomerID { get; set; }
        public string AccountNo { get; set; }
        public decimal Balance { get; set; }

        public decimal withdrawMoney(int accountID, decimal amount)
        {
            checkBalance(accountID);
            Console.WriteLine("STAN wyplata przed: " + this.Balance);
            this.Balance -= amount;
            

            //updating to database
            string query = "Update BankAccounts Set Balance = @balance Where AccountID = @accountID";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@accountID", accountID);
            sqlCommand.Parameters.AddWithValue("@balance", this.Balance);
            DataAccessLayer dal = new DataAccessLayer();
            dal.connectionOpen();
            dal.queryExecution(sqlCommand);

            Console.WriteLine("STAN wyplata po: " + this.Balance);

            return this.Balance;
        }

        public decimal depositMoney(int accountID, decimal amount)
        {
            checkBalance(accountID);
            Console.WriteLine("STAN wplata przed: " + this.Balance);
            this.Balance += amount;
            

            //updating to database
            string query = "Update BankAccounts Set Balance = @balance Where AccountID = @accountID";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@accountID", accountID);
            sqlCommand.Parameters.AddWithValue("@balance", this.Balance);
            DataAccessLayer dal = new DataAccessLayer();
            dal.connectionOpen();
            dal.queryExecution(sqlCommand);

            Console.WriteLine("STAN wplata po: " + this.Balance);

            return this.Balance;
        }

        public decimal checkBalance(int accountID)
        {
            string query = "Select Balance From BankAccounts Where AccountID = @accountID";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@accountID", accountID);
            DataAccessLayer dal = new DataAccessLayer();
            dal.connectionOpen();
            SqlDataReader reader = dal.returnReader(sqlCommand);
            if (reader.HasRows)
            {
                reader.Read();
                this.Balance = Convert.ToDecimal(reader[0]);
                reader.Close();
            }
            dal.connectionClose();
            return this.Balance;

        }
    }
}
