using System;
using System.Collections.Generic;
using System.Text;

namespace A132_ExeHerancaCastingSobreposicaoSelamento.Entities
{
    class Product
    {
        //***ATRIBUTOS***
        public string Name { get; set; }
        public double Price { get; set; }

        //***CONSTRUTORES***
        public Product()
        { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //***MÉTODOS***
        //Etiqueta - Imprime os dados do produto
        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $" + Price);
            return sb.ToString();
        }
    }
}
