using System;
using System.Collections.Generic;
using System.Text;

namespace A115_Enumeracoes.Entities.Enums
{
    enum OrderStatus: int  //Int indica que cada valor do OrderStatus é um inteiro
    {
        PendingPayment = 8, //Se não colocar nada o compilador irá atribuir uma contagem começando do 0
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
