using A135_Classes_Metodos_Abstratos.Entities.Enums;


namespace A135_Classes_Metodos_Abstratos.Entities
{
    abstract class Shape
    {
        //***ATRIBUTOS***
        public Color Color { get; set; }

        //***CONSTRUTORES***
        public Shape(Color color)
        {
            Color = color;
        }

        //***METODOS***
        public abstract double Area();
    }
}
