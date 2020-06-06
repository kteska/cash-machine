using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bankomat
{
    class CreditCard
    {
        public int CardID { get; private set; }
        public string CardNo { get; private set; }
        public DateTime ExpiredDate { get; private set; }
        public int AccountID { get; private set; }
        public int CustomerID { get; private set; }
        public int CVV { get; private set; }
        public string CardHolder { get; private set; }
        public int PIN { get; private set; }
        public string CardType { get; private set; }

        public int pinCounter = 0;

        public int verifyCardNo(long cardNumber, int enteredPIN)
        {
            string query = "Select AccountID, PIN, ExpiredDate, CustomerID From CreditCards Where CardNo = @cardNumber";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@cardNumber", cardNumber);
            DataAccessLayer dal = new DataAccessLayer();
            dal.connectionOpen();
            SqlDataReader reader = dal.returnReader(sqlCommand);
            if (reader.HasRows)
            {
                reader.Read();
                this.CustomerID = Convert.ToInt32(reader[3]);
                this.PIN = Convert.ToInt32(reader[1]);
                if (this.PIN == enteredPIN)
                {
                    this.ExpiredDate = Convert.ToDateTime(reader[2]);
                    this.AccountID = Convert.ToInt32(reader[0]);
                    Console.WriteLine("KARTA DATA " + this.ExpiredDate);
                    reader.Close();
                    dal.connectionClose();
                    Console.WriteLine("Weryfikacja przebiegła pomyślnie - karta aktywna");
                    return 0;
                }
                else if (this.PIN != enteredPIN && pinCounter < 3)
                {
                    Console.WriteLine("PIN niepoprawny, spróbuj ponownie");
                    pinCounter++;
                    Console.WriteLine("PRÓBA: " + pinCounter);
                    return -1;
                }
                else if (pinCounter == 3)
                {
                    Console.WriteLine("Karta zablokowana");
                    return -2;
                }
                else if (DateTime.Now > this.ExpiredDate)
                {
                    Console.WriteLine("Dzis " + DateTime.Now);
                    Console.WriteLine("Karta " + this.ExpiredDate);
                    return -3;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                dal.connectionClose();
                Console.WriteLine("Weryfikacja przebiegła negatywnie - karta nieaktywna");
                return 1;
            }


        }

        public bool getCardInfo(int customerID)
        {
            string query = "Select CardNo, ExpiredDate, AccountID, CardHolder, CardType From CreditCards Where CustomerID = @customerID";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@customerID", customerID);
            DataAccessLayer dal = new DataAccessLayer();
            dal.connectionOpen();
            SqlDataReader reader = dal.returnReader(sqlCommand);
            
            if (reader.HasRows)
            {
                reader.Read();
                this.CardNo = reader[0].ToString();
                //this.PIN = Convert.ToInt32(reader[6]);
                Console.WriteLine("TU JEST READER");
                Console.WriteLine(reader[1]);
                //this.CustomerID = Convert.ToInt32(reader[0]);
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
