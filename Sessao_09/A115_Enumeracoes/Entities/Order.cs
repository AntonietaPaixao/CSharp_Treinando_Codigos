using System;
using System.Collections.Generic;
using System.Text;
using A115_Enumeracoes.Entities.Enums;

namespace A115_Enumeracoes.Entities
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ID + ", " + Moment + ", " + Status;
        }
    }
}
