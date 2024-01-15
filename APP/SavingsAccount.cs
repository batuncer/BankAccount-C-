using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string customerName, decimal interestRate = 2.0m)
            : base(customerName)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            Balance += Balance * InterestRate / 100;
        }
    }
}
