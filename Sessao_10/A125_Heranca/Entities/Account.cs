namespace A125_Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //protected permite acesso pelas subclasses da classe mãe

        public Account()
        { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //SOBREPOSIÇÃO
        //A palavra VIRTUAL indica que é um método base para sobreposição
        public virtual void Withdraw(double amount)
        {
            Balance -= amount; //Oeração de depósito
            Balance -= 5.00; //Taxa de 5 reais para cada depósito
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return "Number: " + Number +
                "\nHolder: " + Holder +
                "\nBalance: " + Balance + "\n";
        }
    }
}
