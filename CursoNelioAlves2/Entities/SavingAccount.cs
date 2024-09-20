using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoNelioAlves2.Entities
{
    internal class SavingAccount : Account
    {
        public double InterestRate { get; set; }    

        public SavingAccount() { }
        public SavingAccount(int number, string holder, double balance, double interestRate)
         : base(number, holder, balance)
        {
            InterestRate = interestRate ;
        }

        public void updateBalance() 
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
