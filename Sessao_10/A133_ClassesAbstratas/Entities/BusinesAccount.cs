namespace A133_ClassesAbstratas.Entities
{
    class BusinesAccount : Account  //:Indicando a extensão da SuperClasse Account
    {
        public double LoanLimit { get; set; }

        public BusinesAccount()
        { }

        public BusinesAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) //herdando os parâmetros do construtor da Super Classe
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        //Método sobreposto e selado pela palavra sealed
        public sealed override void Withdraw(double amount) 
        {
            base.Withdraw(amount);
            Balance -= amount * 0.02; //Comportamento adicionano na sobreposição do método
        }

        public override string ToString()
        {
            return "Number: " + Number +
                "\nHolder: " + Holder +
                "\nBalance: " + Balance +
                "\nLoan Limit: " + LoanLimit + "\n"; 
        }
    }
}
