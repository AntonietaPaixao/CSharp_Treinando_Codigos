using System;
using System.Collections.Generic;
using A132_ExeHerancaCastingSobreposicaoSelamento.Entities;

namespace A132_ExeHerancaCastingSobreposicaoSelamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRODUCT PROGRAM!\n");

            Console.Write("Deseja Cadastrar um produto?(S/N): ");
            char response = char.Parse(Console.ReadLine());

            Product prod = new Product();
            List<Product> listProducts = new List<Product>();

            if (response == 's' || response == 'S')
            {
                do
                {
                    Console.Write("O produto será do tipo: 1 Normal - 2 Importado - 3 Usado: ");
                    int typeProduc = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o nome do produto: ");
                    string name = Console.ReadLine();
                    Console.Write("Entre com o preço do produto: ");
                    double price = double.Parse(Console.ReadLine());

                    //Instanciando os objetos de acordo com o tipo de produto escolhido.
                    switch (typeProduc)
                    {
                        case 1:
                            prod = new Product(name, price);
                            break;

                        case 2:
                            Console.Write("Entre com o valor de alfândega: ");
                            double customesFree = double.Parse(Console.ReadLine());
                            prod = new ImportedProduct(name, price, customesFree);
                            break;

                        case 3:
                            Console.Write("Entre com a data de fabricação: ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                            prod = new UsedProduct(name, price, manufactureDate);
                            break;

                        default:
                            Console.WriteLine("Opção inválida, programa encerrado!");
                            break;
                    }

                    listProducts.Add(prod);

                    Console.Write("\nDeseja Cadastrar um outro produto? (S/N): ");
                    response = char.Parse(Console.ReadLine());
                } while (response == 's' || response == 'S');

                Console.WriteLine("PRODUTOS:\n");
                foreach (Product item in listProducts)
                {
                    Console.WriteLine(item.PriceTag());
                }

            }

        }
    }
}
