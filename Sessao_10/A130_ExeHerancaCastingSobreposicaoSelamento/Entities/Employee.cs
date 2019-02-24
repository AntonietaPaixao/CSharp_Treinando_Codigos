using System.Globalization;
namespace A130_ExeHerancaCastingSobreposicaoSelamento.Entities
{
    class Employee
    {
        //***CLASSE FUNCIONÁRIO***

        ////***ATRIBUTOS//***
        public string Name { get; set; }
        public int Hour { get; set; }
        public double ValuePerHour { get; set; }

        ////***CONSTRUTORES//***
        public Employee()
        { }

        public Employee(string name, int hour, double valuePerHour)
        {
            Name = name;
            Hour = hour;
            ValuePerHour = valuePerHour;
        }

        ////***MÉTODOS//***
        //Calcula o pagamento do funcionário pela quantidade de horas trabalhadas
        public virtual double Payment()
        {
            return Hour * ValuePerHour;
        }

        public override string ToString()
        {
            return "\nName: " + Name
                + "\nHour: " + Hour
                + "\nValue Per Hour: " + ValuePerHour 
                + "\nPayment: $" + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
