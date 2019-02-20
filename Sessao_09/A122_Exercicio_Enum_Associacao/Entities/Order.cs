using System;
using System.Collections.Generic;
using System.Text;
using A122_Exercicio_Enum_Associacao.Entities.Enuns;

namespace A122_Exercicio_Enum_Associacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(OrderItem it in Items)
            {
                total += it.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Cliet : " + Client);
            sb.AppendLine("Order items: " );
            foreach (OrderItem oi in Items)
            {
                sb.Append(oi.ToString() + "\n");
            }
            sb.AppendLine("Total price: $" + Total().ToString());

            return sb.ToString();
        }
    }
}
