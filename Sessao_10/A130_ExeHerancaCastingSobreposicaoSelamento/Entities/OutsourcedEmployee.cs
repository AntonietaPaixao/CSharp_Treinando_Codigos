using System.Globalization;
namespace A130_ExeHerancaCastingSobreposicaoSelamento.Entities
{
    class OutsourcedEmployee : Employee
    {
        //***CLASSE FUNCIONÁRIO TERCEIRIZADO***
        //Subclasse da classe FUNCIONÁRIO


        //***ATRIBUTOS***
        //Funcionários terceirizados, tem um custo adicional
        public double AdditionalCharge { get; set; }


        //***CONSTRUTORE***S
        public OutsourcedEmployee()
        { }

        public OutsourcedEmployee(double additionalCharge, string name, int hour, double valuePerHour) : base(name, hour, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }


        //***MÉTODOS ESPECÍFICOS***

        //Calcula o pagamento do funcionário conforme método Payment da Classe FUNCIONÁRIOS
        //e adiciona mais 110% do custo adicional
        public sealed override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nAdditional Cherge: " + AdditionalCharge;
        }
    }
}
