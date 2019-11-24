using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bankapp
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance +item.Amount;
                }
                return balance;
            }
            set => throw new NotImplementedException();
        }

        //list of transactions to manage all transactions made in an account.
        private List<Transaction> allTransactions= new List<Transaction>();
        
        // a private variable to produce the random account numbers for users
        private static int accountNumberSeed = 1234567890;
        
        // we need a constructor in order to allow the creation of new bank account
         public BankAccount(string name, decimal initialBalance)
         {
             this.Owner = name;
            // MakeDeposit(initialBalance, DateTime.Now, "initialBalance");
            this.Number = accountNumberSeed.ToString();
        }
         //A method for the deposit transactions.
          
         public void MakeDeposit(decimal amount, decimal accountnumber,string depositer, DateTime date, string note)
         { 
             if (amount<0) 
             {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be positive!");
             } 
             Balance += amount;
             var deposit= new Transaction(amount,date,note);
             allTransactions.Add(deposit);
             Console.WriteLine($"Success deposit of {amount}.00Rwf on {accountnumber} account, by {depositer} for {note}.");
             Console.WriteLine($"Dear {depositer}, your new balance is {Balance}.00rwf\n\t Thank you for banking with us!");
         }
         //A method for the withdrawal transactions.
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
             if (amount<0)
             {
                 throw new ArgumentOutOfRangeException(nameof(amount),"Amount of withdrawal must be positive!");
             }

             if (Balance-amount<0)
             {
                
                 Console.WriteLine("No sufficient funds for this withdrawal.");
                 Console.WriteLine("GO and make deposit first!");
             }
             
             var withdrawal= new Transaction(-amount,date,note);
             Balance -= amount;
             Console.WriteLine($"Dear {Owner}, your new balance is {Balance}.00rwf\n\t Thank you for banking with us!");
             allTransactions.Add(withdrawal);
        }
                public string GetAccountHistory()
                {
                    var report = new StringBuilder();
                    report.AppendLine("Date\t\t\tAmount\t\tNote");
                    foreach (var item in allTransactions)
                    {
                        //rows
                        report.AppendLine($"{item.Date}\t{item.Amount}\t\t{item.Note}");
                    }
                    return report.ToString();  
                }
    }
}