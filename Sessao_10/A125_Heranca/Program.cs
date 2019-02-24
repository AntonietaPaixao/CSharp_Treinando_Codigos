using System;
using A125_Heranca.Entities;

namespace A125_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACCOUNT\n");
            
            //HERANÇA
            BusinesAccount busines = new BusinesAccount(100, "Antonia", 203.50,  300.00);
            Console.WriteLine("Teste de Herança:");
            Console.WriteLine(busines);

            //UPCASTING DOWNCASTING
            Account acc = new Account(101, "Belmiro", 10000.00); 
            Console.WriteLine("Instanciação de um Account:");
            Console.WriteLine(acc);

            BusinesAccount bacc = new BusinesAccount(102, "Clementina", 2000.00, 500.00);
            Console.WriteLine("Instanciação de um BusinesAccount:");
            Console.WriteLine(bacc);

            SavingAccount sacc = new SavingAccount(103, "Diogo", 3000.00, 0.10);
            Console.WriteLine("Instanciação de um SavingAccount:");
            Console.WriteLine(sacc);

            //Upcasting: SubClasse -> SuperClasse
            Account acc1 = bacc;
            Console.WriteLine("Account recebendo um BusinesAccount:");
            Console.WriteLine(acc1);

            Account acc2 = new BusinesAccount(103, "Elder", 3000.00, 1000.00);
            Console.WriteLine("Account isntanciado como BusinesAccount:");
            Console.WriteLine(acc2);

            Account acc3 = new SavingAccount(104, "Francisco", 4000.00, 0.15);
            Console.WriteLine("Account isntanciado como SavingAcount:");
            Console.WriteLine(acc3);

            //Downcasting: SuperClasse -> SubClasse
            //A conversão não ocorre implicitamente, sendo necessário fazer um casting da SubClasse
            BusinesAccount bacc1 = (BusinesAccount)acc2;
            //Permite acessar os métodos especificos da SubClasse
            bacc1.Loan(50.00);
            Console.WriteLine("BusinesAccount recebendo um Acount que recebeu anteriormente um BusinesAccount:");
            Console.WriteLine(bacc1);
            
            //OBS: Não é possível realizar casting entre Objetos
            //de Classes Filhas de uma mesma Classe Mãe.
            //Ex: BusinesAccount bacc2 = (BusinesAccount)sacc;

            //Verificando de qual classe é o objeto
            Console.WriteLine("sacc é um Account? " + ((sacc is Account) ? "Sim" : "Não"));
            Console.WriteLine("sacc é um BusinesAccount? " + ((sacc is BusinesAccount) ? "Sim" : "Não"));
            Console.WriteLine("sacc é um SavingAccount? " + ((sacc is SavingAccount) ? "Sim" : "Não"));
        }
    }
}
