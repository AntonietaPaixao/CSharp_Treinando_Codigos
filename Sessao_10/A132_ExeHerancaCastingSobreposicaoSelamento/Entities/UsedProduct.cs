    using System;
using System.Collections.Generic;
using System.Text;

namespace A132_ExeHerancaCastingSobreposicaoSelamento.Entities
{
    class UsedProduct : Product
    {
        //***ATRIBUTOS***
        public DateTime ManufactureDate { get; set; }

        //***CONSTRURORES***
        public UsedProduct()
        { }

        public UsedProduct(string name, double price, DateTime manufactureDate): base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        //***MÉTODOS***
        //Etiqueta - Imprime os dados do produto
        public sealed override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " (used) $" + Price);
            sb.Append(" (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")");

            return sb.ToString();
        }

    }
}
