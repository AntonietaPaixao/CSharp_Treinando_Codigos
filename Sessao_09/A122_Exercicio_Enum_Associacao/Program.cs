using System;
using A122_Exercicio_Enum_Associacao.Entities;
using A122_Exercicio_Enum_Associacao.Entities.Enuns;

namespace A122_Exercicio_Enum_Associacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM ORDERITEM\n");

            Client client = new Client();
            Console.Write("Enter cliente data:\nName: ");
            client.Name = Console.ReadLine();
            Console.Write("Email: ");
            client.Email = Console.ReadLine();
            Console.Write("Birth date(DD/MM/YYYY): ");
            client.BirthDay = DateTime.Parse(Console.ReadLine());

            Order order = new Order();
            order.Client = client;
            order.Moment = DateTime.Now;
            Console.Write("\nEnter order data: \nStatus: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int it = int.Parse(Console.ReadLine());

            for (int i = 0; i<it; i++)
            { 
                //Product
                Product product = new Product();
                Console.WriteLine("\nEnter #" + (i + 1) + " item data: ");
                Console.Write("Product name: ");
                product.Name = Console.ReadLine();
                Console.Write("Product price: ");
                product.Price = Double.Parse(Console.ReadLine());
                
                //Order
                OrderItem orderItem = new OrderItem();
                Console.Write("Quantity: ");
                orderItem.Quantity = int.Parse(Console.ReadLine());
                orderItem.Price = product.Price;
                orderItem.Product = product;
                order.AddItem(orderItem);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
