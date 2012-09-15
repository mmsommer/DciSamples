using System;

namespace DciExampleCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceAccount = new SavingsAccount(balance: 5000);
            var destinationAccount = new SavingsAccount(balance: 5000);

            Console.WriteLine("Before:");
            Console.WriteLine("Source:      {0}", sourceAccount);
            Console.WriteLine("Destination: {0}", destinationAccount);
            Console.WriteLine();

            MoneyTransfer
                .Transfer(1000)
                .From(sourceAccount)
                .To(destinationAccount);

            Console.WriteLine("After:");
            Console.WriteLine("Source:      {0}", sourceAccount);
            Console.WriteLine("Destination: {0}", destinationAccount);

            Console.ReadKey();
        }
    }
}
