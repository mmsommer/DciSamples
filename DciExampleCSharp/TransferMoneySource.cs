namespace DciExampleCSharp
{
    interface TransferMoneySource : Log
    {
        double Balance { get; }

        void Withdraw(double amount);
    }
}
