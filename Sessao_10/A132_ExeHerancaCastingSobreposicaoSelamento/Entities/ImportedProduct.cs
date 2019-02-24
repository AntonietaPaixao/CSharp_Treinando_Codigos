using System;
using System.Collections.Generic;
using System.Text;

namespace A132_ExeHerancaCastingSobreposicaoSelamento.Entities
{
    class ImportedProduct : Product
    {
        //***ATRIBUTOS***
        public double CustomesFree { get; set; }

        //***CONSTRUTORES***
        public ImportedProduct()
        { }

        public ImportedProduct(string name, double price, double customesFree) : base(name, price)
        {
            CustomesFree = customesFree;
        }

        //***MÉTODOS***
        //Etiqueta - Imprime os dados do produto
        public double TotalPrice()
        {
            return Price + CustomesFree;
        }

        public sealed override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $" + TotalPrice());
            sb.Append(" (Customs free: $" + CustomesFree + ")");

            return sb.ToString();
        }
    }
}
