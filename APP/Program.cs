using APP;

class Program
{
    static void Main(string[] args)
    {
        BankAccount regularAccount = new BankAccount("Baki");
        CurrentAccount currentAccount = new CurrentAccount("Tuncer", 500);
        SavingsAccount savingsAccount = new SavingsAccount("Ana", 2.5m);

        regularAccount.Deposit(1000);
        currentAccount.Deposit(1500);
        savingsAccount.Deposit(2000);

        regularAccount.Withdraw(500);
        currentAccount.Withdraw(1000);

        savingsAccount.AddInterest();
        savingsAccount.Withdraw(800);

        

        Console.WriteLine("Regular Account - Balance: $" + regularAccount.Balance);
        Console.WriteLine("Current Account - Balance: $" + currentAccount.Balance);
        Console.WriteLine("Savings Account - Balance: $" + savingsAccount.Balance);

    }
}