using A135_Classes_Metodos_Abstratos.Entities.Enums;

namespace A135_Classes_Metodos_Abstratos.Entities
{
    class Rectangle : Shape
    {
        //***ATRIBUTOS***
        public double Width { get; set; }
        public double Height { get; set; }

        //***CONSTRUTORES***
       public Rectangle(Color color, double width, double height)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        //***METODOS***
        public override double Area()
        {
            return Width * Height;
        }

    }
}
