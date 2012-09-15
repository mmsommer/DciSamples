using System;

namespace DciExampleCSharp
{
    class SavingsAccount : TransferMoneySource, TransferMoneySink
    {
        private double balance;

        public SavingsAccount(double balance)
        {
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return balance.ToString();
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
    }
}
