namespace DciExampleCSharp
{
    static class TransferMoneySourceTraits
    {
        public static void TransferTo(this TransferMoneySource self, TransferMoneySink recipient, double amount)
        {
            if (self != null && recipient != null)
            {
                if (self.Balance < amount)
                {
                    self.Log("Insufficient funds");
                }
                else
                {
                    self.Withdraw(amount);
                    self.Log("Withdrawing  " + amount);

                    recipient.Deposit(amount);
                    recipient.Log("Depositing   " + amount);
                }
            }
        }
    }
}
