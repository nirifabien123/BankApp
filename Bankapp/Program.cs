using System;
using System.Collections.Generic;
using System.Collections.Immutable;
 
namespace Bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose among the following choices to continue:\n");
            Console.WriteLine("1 FOR DEPOSIT \n2 FOR WITHDRAWAL\n3 FOR CREATING A NEW ACCOUNT\n4 FOR HELP.");
            int casing = Convert.ToInt16(Console.ReadLine());
            switch (casing)
            {
                case 1:
                    
                    decimal depositAmount, accNo;
                    string names, reason;
                     BankAccount acc = new BankAccount("",0);
                   
                    Console.WriteLine("Enter deposit account no:");
                    accNo=Convert.ToDecimal(Console.ReadLine());
                  
                    
                    Console.WriteLine("Enter deposit amount:");
                    depositAmount=Convert.ToDecimal(Console.ReadLine());
                    
                    Console.WriteLine("Enter depositer names:");
                    names=Console.ReadLine();
                    
                    
                    Console.WriteLine("Enter deposit reason:");
                    reason=Console.ReadLine();
                    acc.MakeDeposit(depositAmount,accNo,names,DateTime.Now, reason);
                    Console.WriteLine(acc.GetAccountHistory());
                    break;
                
                case 2:
                    decimal withdrawAmount, accNo1;
                    string names1, reason1;
                    var acc1 = new BankAccount("", 0);
                    
                    Console.WriteLine("Enter account no:");
                    accNo1=Convert.ToDecimal(Console.ReadLine());
                  
                    
                    Console.WriteLine("Enter withdraw amount:");
                    withdrawAmount=Convert.ToDecimal(Console.ReadLine());
                    
                    Console.WriteLine("Enter names:");
                    names1=Console.ReadLine();
                    
                    
                    Console.WriteLine("Enter reason:");
                    reason1=Console.ReadLine();
                    acc1.MakeWithdrawal(withdrawAmount,DateTime.Now, reason1);
                    Console.WriteLine($"Success withdraw of { withdrawAmount}.00Rwf from {acc1} account, by {names1} for {reason1}.");
                    Console.WriteLine(acc1.GetAccountHistory());
                    goto case 1;
                    break;
                    
                
                    
            }
           
           //Console.WriteLine($"The account {account.Number} was created successfully, for {account.Owner} with {account.Balance}.00Rwf.");

           //var account;// must be initialized.
//          //test for a negative balance.
//          try
//          {
//
//              account.MakeWithdrawal(0,DateTime.Now, "Attempt to withdraw");
//          }
//          catch (InvalidOperationException e)
//          {
//              Console.WriteLine("Exception caught trying to overdraw ");
//              Console.WriteLine(e.ToString());
//          }
//          try
//          {
//            var invalidAccount=new BankAccount("invalid",-55);
//          }
//          catch (ArgumentOutOfRangeException e)
//          {
//              Console.WriteLine("Exception caught creating account with negative balance`");
//              Console.WriteLine(e.ToString());
//          }
         //Console.WriteLine(account.GetAccountHistory());
        }
         
    }
}
