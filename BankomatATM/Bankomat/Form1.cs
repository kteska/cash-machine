using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace Bankomat
{
    public partial class Form1 : Form
    {
        DataAccessLayer dal = new DataAccessLayer();
        SqlCommand sqlCommand = new SqlCommand();
        BindingSource bindingsource1 = new BindingSource();
        CreditCard creditCard = new CreditCard();
        Customer customer = new Customer();
        BankAccount bankAccount = new BankAccount();

        public Form1()
        {
            InitializeComponent();
            //sqlCommand.CommandText = "Select * From Customers";
            //bindingsource1.DataSource = dal.selectData(sqlCommand);
            //dataGridView1.DataSource = bindingsource1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*long personalID = Convert.ToInt64(textBox1.Text);
            int customerID = Convert.ToInt32(customer.getCustomerID(personalID));
            if (customerID > 0) label2.Text = "CustomerID = " + customerID.ToString();
            else label2.Text = "brak klienta";*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*long personalID = Convert.ToInt64(textBox1.Text);
            bool customerExists = customer.getCustomerInfo(personalID);
            if (customerExists)
            {
                label3.Text = "Customer Info = " + "\n ID = " + customer.CustomerID.ToString() +
                    "\n Name = " + customer.Name + "\n Surname = " + customer.Surname +
                    "\n PhoneNo = " + customer.PhoneNo.ToString() + "\n Address = " + customer.Address +
                    "\n PESEL = " + customer.PersonalID.ToString();
            }
            else label3.Text = "Nie ma takiego klienta";*/
        }

        bool checkData(out long cardNo, out int enteredPIN)
        {
            //stan początkowy
            cardNo = 0;
            enteredPIN = 0;
            //sprawdzenie numeru karty
            if (string.IsNullOrEmpty(txtEnterCard.Text))
            {
                errorProvider1.SetError(txtEnterCard, "Wprowadź numer karty");
                return false;
            }
            else
                errorProvider1.Dispose();

            if (!long.TryParse(txtEnterCard.Text, out cardNo))
            {
                errorProvider1.SetError(txtEnterCard, "Wystąpił niedozwolony znak");
                return false;
            }

            //sprawdzenie numeru PIN
            if (string.IsNullOrEmpty(txtEnterPin.Text))
            {
                errorProvider1.SetError(txtEnterPin, "Wprowadź PIN");
                return false;
            }
            else
                errorProvider1.Dispose();


            if (!int.TryParse(txtEnterPin.Text, out enteredPIN))
            {
                errorProvider1.SetError(txtEnterPin, "Wystąpił niedozwolony znak");
                return false;
            }


            return true;
        }

        private void btnEnterCard_Click(object sender, EventArgs e)
        {
            long cardNo;
            int enteredPIN;
            if (!checkData(out cardNo, out enteredPIN))
            {
                errorProvider1.SetError(btnEnterCard, "Wystąpił błąd przy pobieraniu danych");
            }
            else
            {
                errorProvider1.Dispose();
                int cardExists = creditCard.verifyCardNo(cardNo, enteredPIN);
                if (cardExists == 0)
                {
                    lblAlert1.ForeColor = Color.Green;
                    lblAlert1.Text = "Komunikat" + "\n\n" + "Weryfikacja przebiegła pomyślnie";
                    errorProvider1.Dispose();
                    txtEnterCard.Enabled = false;
                    txtEnterPin.Enabled = false;
                    btnEnterCard.Enabled = false;
                }
                else if (cardExists == -1)
                {
                    int counter = creditCard.pinCounter;
                    int attempt = 4 - counter;
                    lblAlert1.ForeColor = Color.Red;
                    lblAlert1.Text = "Komunikat" + "\n\n" + "Niepoprawny PIN! \nIlość prób: " + attempt.ToString();
                    errorProvider1.SetError(txtEnterPin, "Niepoprawny PIN");
                    txtEnterPin.Clear();
                }
                else if (cardExists == -2)
                {
                    lblAlert1.Text = "Komunikat" + "\n\n" + "Karta zablokowana!";
                    lblAlert1.ForeColor = Color.Red;
                    errorProvider1.Dispose();
                    txtEnterCard.Enabled = false;
                    txtEnterPin.Enabled = false;
                    btnEnterCard.Enabled = false;
                    tabControl1.Enabled = false;
                }
                else if (cardExists == 1)
                {
                    lblAlert1.ForeColor = Color.Red;
                    lblAlert1.Text = "Weryfikacja nie przebiegła pomyślnie";
                    errorProvider1.Dispose();
                    txtEnterCard.Enabled = false;
                    txtEnterPin.Enabled = false;
                    btnEnterCard.Enabled = false;
                    tabControl1.Enabled = false;
                } 
                else if (cardExists == -3)
                {
                    lblAlert1.ForeColor = Color.Red;
                    lblAlert1.Text = "Karta nieobsługiwana";
                    errorProvider1.Dispose();
                    txtEnterCard.Enabled = false;
                    txtEnterPin.Enabled = false;
                    btnEnterCard.Enabled = false;
                    tabControl1.Enabled = false;
                }
            }
            
        }

        bool checkWithdrawData(out decimal am)
        {
            //stan początkowy
            am = 0;
            //sprawdzenie numeru karty
            if (string.IsNullOrEmpty(txtWithdrawAmount.Text))
            {
                errorProvider1.SetError(txtWithdrawAmount, "Wprowadź ilość gotówki");
                return false;
            }
            else
                errorProvider1.Dispose();
            Console.WriteLine("FALSZ: " + decimal.TryParse(txtWithdrawAmount.Text, out am));
            if (!decimal.TryParse(txtWithdrawAmount.Text, out am))
            {
                errorProvider1.SetError(txtWithdrawAmount, "Wystąpił niedozwolony znak");
                return false;
            }

            if (am < 0)
            {
                errorProvider1.SetError(txtWithdrawAmount, "Wystąpił niedozwolony znak");
                return false;
            }
                return true;
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            decimal am;
            if (!checkWithdrawData(out am))
            {
                errorProvider1.SetError(btnWithdrawMoney, "Wystąpił błąd przy pobieraniu danych");
            }
            else
            {
                errorProvider1.Dispose();
                decimal balance = bankAccount.withdrawMoney(creditCard.AccountID, am);
                Console.WriteLine("STAN KONTA wyplata: " + balance);
                lblWithdrawAlert.ForeColor = Color.Green;
                lblWithdrawAlert.Text = "Komunikat" + "\n\n" + am + " zł zostało wypłacone z konta." +
                    "\nStan konta po wypłacie: " + balance + " zł";
                txtWithdrawAmount.Clear();
            }
        }

        bool checkDepositData(out decimal am)
        {
            //stan początkowy
            am = 0;
            //sprawdzenie numeru karty
            if (string.IsNullOrEmpty(txtDeposit.Text))
            {
                errorProvider1.SetError(txtDeposit, "Wprowadź ilość gotówki");
                return false;
            }
            else
                errorProvider1.Dispose();

            if (!decimal.TryParse(txtDeposit.Text, out am))
            {
                errorProvider1.SetError(txtDeposit, "Wystąpił niedozwolony znak");
                return false;
            }

            if (am < 0)
            {
                errorProvider1.SetError(txtDeposit, "Wystąpił niedozwolony znak");
                return false;
            }
            return true; 
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal am;
            if (!checkDepositData(out am))
            {
                errorProvider1.SetError(btnDeposit, "Wystąpił błąd przy pobieraniu danych");
            }
            else
            {
                errorProvider1.Dispose();
                decimal balance = bankAccount.depositMoney(creditCard.AccountID, am);               
                Console.WriteLine("STAN KONTA wplata: " + balance);
                lblDepositAlert.ForeColor = Color.Green;
                lblDepositAlert.Text = "Komunikat" + "\n\n" + am + " zł zostało wpłacone na konto." + 
                    "\nStan konta po wpłacie: " + balance + " zł";
                txtDeposit.Clear();
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            //sprawdź stan konta
            decimal bankBalance = bankAccount.checkBalance(creditCard.AccountID);
            txtCheckBalance.Text = bankBalance.ToString();
        }

        











        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEnterCard_Click(object sender, EventArgs e)
        {

        }

        
    }
}
