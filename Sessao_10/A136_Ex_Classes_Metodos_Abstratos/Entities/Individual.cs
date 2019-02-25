namespace A136_Ex_Classes_Metodos_Abstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HelthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double helthExpenditures)
            : base(name, anualIncome)
        {
            HelthExpenditures = helthExpenditures;
        }

        public override double Tax()
        {
            //Percentual do inposto conforme a renda
            if (AnualIncome > 2000.00)
                return (AnualIncome * 0.25) - (HelthExpenditures * 0.5);
            else
                return (AnualIncome * 0.15) - (HelthExpenditures * 0.5);
        }

    }
}
