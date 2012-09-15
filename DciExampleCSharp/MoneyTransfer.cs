namespace DciExampleCSharp
{
    class MoneyTransfer
    {
        private TransferMoneySource source;
        private TransferMoneySink sink;
        private double amount;

        private MoneyTransfer(double amount)
        {
            this.amount = amount;
        }

        public static MoneyTransfer Transfer(double amount)
        {
            return new MoneyTransfer(amount);
        }

        public MoneyTransfer From(TransferMoneySource source)
        {
            this.source = source;
            return this;
        }

        public void To(TransferMoneySink sink)
        {
            this.sink = sink;
            DoIt();
        }

        private void DoIt()
        {
            source.TransferTo(sink, amount);
        }
    }
}
