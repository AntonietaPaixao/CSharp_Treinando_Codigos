using System;
using A135_Classes_Metodos_Abstratos.Entities.Enums;

namespace A135_Classes_Metodos_Abstratos.Entities
{
    class Circle : Shape
    {
        //***ATRIBUTOS***
        public double Radius { get; set; }

        //***CONSTRUTORES***
        public Circle(Color color, double radius)
            :base(color)
        {
            Radius = radius;
        }

        //***METODOS***
        public override double Area()
        {
            //PI x raio ao quadrado
            return Radius * Radius * Math.PI;
        }

    }
}
