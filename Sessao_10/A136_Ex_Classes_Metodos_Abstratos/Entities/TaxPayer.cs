namespace A136_Ex_Classes_Metodos_Abstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax(); //Método Abstrato

        public override string ToString()
        {
            return Name + ": $" + Tax();
        }

    }
}
