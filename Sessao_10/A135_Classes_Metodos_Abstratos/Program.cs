using System;
using System.Globalization;
using System.Collections.Generic;
using A135_Classes_Metodos_Abstratos.Entities;
using A135_Classes_Metodos_Abstratos.Entities.Enums;

namespace A135_Classes_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GEOMÉTRIC SHAPES!\n");

            Console.Write("Deseja calcular a área de uma figura? (S/N): ");
            char response = char.Parse(Console.ReadLine());
            if (response == 's' || response == 'S')
            {
                char shapeOption;
                List<Shape> listShape = new List<Shape>();
                do
                {
                    Console.Write("\nEscolha um dos dos tipos de figura: 1 - Retangulo ou 2 - Circulo: ");
                    shapeOption = char.Parse(Console.ReadLine());

                    if (shapeOption == 'r' || shapeOption == 'R')
                    {
                        Console.Write("Digite a cor da figura (Branca/Azul/Vermelha): ");
                        Color color = Enum.Parse<Color>(Console.ReadLine());
                        Console.Write("Entre com o valor da Largura do retângulo: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Entre com o valor da Altura do retângulo: ");
                        double hight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        ;
                        Rectangle rectangle = new Rectangle(color, width, hight);
                        listShape.Add(rectangle);
                    }
                    else
                    {
                        if (shapeOption == 'c' || shapeOption == 'C')
                        {
                            Console.Write("Digite a cor da figura (Branca/Azul/Vermelha): ");
                            Color color = Enum.Parse<Color>(Console.ReadLine());
                            Console.Write("Entre com o valor do raio do círculo: ");
                            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Circle circle = new Circle(color, radius);
                            listShape.Add(circle);
                        }
                    }

                    Console.Write("\nDeseja calcular a área de outra figura? (S/N): ");
                    response = char.Parse(Console.ReadLine());

                } while (response == 's' || response == 'S');

                Console.WriteLine("\nFORMAS GEOMÉTICAS CADASTRADAS:");
                foreach (Shape item in listShape)
                {
                    if (shapeOption == 'r' || shapeOption == 'R')
                    { Console.WriteLine("Retangulo: "); }
                    else
                    { Console.WriteLine("Circulo: "); }

                    Console.WriteLine("Cor " + item.Color + " Area " + item.Area().ToString("F2", CultureInfo.InvariantCulture) + '\n');

                }

            }
        }
    }
}

