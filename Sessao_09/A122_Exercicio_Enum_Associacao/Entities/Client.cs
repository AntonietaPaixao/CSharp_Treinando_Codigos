using System;

namespace A122_Exercicio_Enum_Associacao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public override string ToString()
        {
            return Name + "(" + BirthDay.ToString("dd/MM/yy") + ") - " + Email;
        }

    }
}
