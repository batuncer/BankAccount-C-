using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public class BankAccount
    {
        private static int nextAccountNumber = 1;

        public string CustomerName { get; set; }
        public int AccountNumber { get; }
        public decimal Balance { get; set; }

        public BankAccount(string customerName, int? accountNumber = null, decimal balance = 0.0m)
        {
            CustomerName = customerName;
            AccountNumber = accountNumber ?? GenerateAccountNumber();
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Balance -= amount;
            }
        }

        private static int GenerateAccountNumber()
        {
            return nextAccountNumber++;
        }
    }
}
