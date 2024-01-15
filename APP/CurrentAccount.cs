using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string customerName, decimal overdraftLimit = 0.0m)
            : base(customerName)
        {
            OverdraftLimit = overdraftLimit;
        }

        public new void Withdraw(decimal amount)
        {
            if (amount > Balance + OverdraftLimit)
            {
                Console.WriteLine("Withdrawal is failed.");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
