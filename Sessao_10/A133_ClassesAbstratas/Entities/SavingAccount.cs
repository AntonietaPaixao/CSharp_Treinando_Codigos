namespace A133_ClassesAbstratas.Entities
{
    //sealed indica que a classe está selada
    sealed class SavingAccount : Account 
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        { }
        
        public SavingAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) //override - Indica que é um método sobreposto
        {
            base.Withdraw(amount); //Copia exatamente o método como ele é na SuperClasse
            Balance -= amount * 0.01; //Comportamento adicionano na sobreposição do método
        }

        public override string ToString()
        {
            return "Number: " + Number +
                "\nHolder: " + Holder +
                "\nBalance: " + Balance +
                "\nInterestRate: " + InterestRate + "\n";
        }
    }
}
