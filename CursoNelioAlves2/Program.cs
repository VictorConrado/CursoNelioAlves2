﻿using CursoNelioAlves2.Entities;

namespace CursoNelioAlves2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1003, "Bob", 500.0);
            Account acc2 = new SavingAccount(1004, "Anna", 500.0, 0.01);

            acc1.Withdraw(100.0);
            acc2.Withdraw(100.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


            ////UPCASTING

            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            ////DOWNCASTING

            //BusinessAccount acc4 = acc2 as BusinessAccount;
            //acc4.Loan(100.0);

            ////BusinessAccount acc5 = acc3 as BusinessAccount;

            //if(acc3 is BusinessAccount) 
            //{
            //  BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}
            //if (acc3 is SavingAccount)
            //{
            //    SavingAccount acc5 = acc3 as SavingAccount;
            //    acc5.updateBalance();
            //    Console.WriteLine("Update!");
            //}
        }
    }
}
