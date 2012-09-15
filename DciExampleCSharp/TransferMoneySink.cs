namespace DciExampleCSharp
{
    interface TransferMoneySink : Log
    {
        void Deposit(double amount);
    }
}
