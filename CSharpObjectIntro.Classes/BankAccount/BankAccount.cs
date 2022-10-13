using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml;

namespace CSharpObjectIntro.Classes.BankAccount
{
    public class BankAccount
    {
        private List<Transaction> transactions = new List<Transaction>();
        public BankAccount(string balance, DateOnly openingDate)
        {
            Balance = balance;
            OpeningDate = openingDate;
        }

        public string Balance { get; private set; }
        public DateOnly OpeningDate { get; private set; }
        public void Withdraw(decimal Balance = 0, decimal withdrawal = 300)
        {
            withdrawal = Convert.ToDecimal(Console.ReadLine());
            Balance = Balance - withdrawal;
            if (Balance < 0)
            {
                Console.WriteLine("Limit Exceeded");
                Balance = Balance + withdrawal;
            }

            Console.WriteLine("Your balance is:" + Balance);

        }

        public void Deposit(decimal Balance = 0, decimal deposit = 500)
        {
            deposit = Convert.ToDecimal(Console.ReadLine());
            Balance =+ deposit;
            Console.WriteLine(Balance);
        }
        // As you complete each task make sure you test your code carefully
        // Choose some combination of manual testing, Debug.Assert and unit tests

        // Task One        
        // The bank account should have a balance property        
        // It should have a constructor that sets the initial balance (default zero) and the opening date (default today)
        // It should have methods to deposit and withdraw/make payments from the account. 


        // Task Two
        // Give the option to set an overdraft limit
        // Do not allow a withdrawal/payment if the overdraft limit is exceeded. You could return false or throw an exception.

        // Task Three
        // Create a new class called AccountTransaction.
        // It could contain properties such as
        // date, amount, category, counterparty, transactionType, description (optional)
        // e.g 26/09/2022 16:45, -300, Groceries, Waitrose, Card, Weekly shop
        //     27/09/2022 17:40, 200, Gift, Bob Smith, Cheque, Birthday present
        // You might wish to use enums for category and transactionType
        // Amend your bank account to contain a list of transactions
        // The methods for  deposit and withdraw/make payments should be amended to add transactions

        public void AddTransaction(DateOnly date, int hours, int minutes, string description, string location, int amount = 0, int duration = 60)
        {
            var transaction = new Transaction(date, hours, minutes, description, location, amount, duration);
            transactions.Add(transaction);
        }

        // Task Four
        // Now add some new methods to your account
        // - See what the balance was at a previous date
        // - See how much money was spent in a given time period
        // - See how much money was spent in different categories

        public decimal CheckBalance(DateTime date)
        {
            date = Convert.ToDateTime(Console.ReadLine());
            for (int n = 0; n < transactions.Count; n++) ;    
            if (date > date.Transaction[n] && date < date.Transaction[n+1])
                {
                return Balance.Transaction[n] ;
            }

        }

        // Extension
        // Work out how much interest is payable on your account
        // For the moment make up the interest rates, though later we could look at loading them from a website
        // The interest should be added as transactions to your account





    }

}
