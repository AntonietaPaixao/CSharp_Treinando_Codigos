using System;
using A115_Enumeracoes.Entities;
using A115_Enumeracoes.Entities.Enums;

namespace A115_Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { ID = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };
            Console.WriteLine(order);

            //CONVERSÃO PARA STRING
            string texto = OrderStatus.Shipped.ToString();
            Console.WriteLine(texto);

            //CONVERSÃO PARA ENUM
            OrderStatus or = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(or);
        }

    }
}
