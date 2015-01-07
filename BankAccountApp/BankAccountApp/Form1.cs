using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        private Customer aCustomer;
        private Account anAccount;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account();            
            anAccount.Number = accountNumberEntryTextBox.Text;
            anAccount.OpeningDate = openingDateEntryTextBox.Text;

            aCustomer = new Customer();
            aCustomer.Name = customerNameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;

            aCustomer.CustomerAccount = anAccount;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.Deposit(amount);
                MessageBox.Show("Deposited");
            }
            else
            {
                MessageBox.Show("Create account first");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.Withdraw(amount);
                MessageBox.Show("Withdrawn");
            }
            else
            {
                MessageBox.Show("Create account first");
            }

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            customerNameDisplayTextBox.Text = aCustomer.Name;
            emailDisplayTextBox.Text = aCustomer.Email;
            accountNumberDisplayTextBox.Text = aCustomer.CustomerAccount.Number;
            openingDateDisplayTextBox.Text = aCustomer.CustomerAccount.OpeningDate;
            balanceTextBox.Text = aCustomer.CustomerAccount.Balance.ToString();
        }
    }
}
