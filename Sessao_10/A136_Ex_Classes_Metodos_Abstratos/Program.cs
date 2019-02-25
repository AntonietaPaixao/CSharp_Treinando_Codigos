using System;
using System.Collections.Generic;
using A136_Ex_Classes_Metodos_Abstratos.Entities;

namespace A136_Ex_Classes_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTRIBUINTE\n");

            Console.Write("Deseja cadastrar um contribuinte? (S/N): ");
            char response = char.Parse(Console.ReadLine());

            List<TaxPayer> listTaxPeyer = new List<TaxPayer>();
            if (response == 's' || response == 'S')
            {
                do
                {
                    Console.Write("Contribuinte: 1-Pessoa Física ou 2-Pessoa Jurídica? ");
                    int kindTaxPayer = int.Parse(Console.ReadLine());

                    if (kindTaxPayer == 1 || kindTaxPayer == 2)
                    {

                        Console.Write("Entre com no nome do contribuinte: ");
                        string name = Console.ReadLine();
                        Console.Write("Entre com os proventos anuais do contribuinte: ");
                        double anualIncome = double.Parse(Console.ReadLine());

                        switch (kindTaxPayer)
                        {
                            case 1:
                                Console.Write("Entre com as despesas médicas a abater: ");
                                double helthExpenditures = double.Parse(Console.ReadLine());
                                Individual indTaxPayer = new Individual(name, anualIncome, helthExpenditures);
                                listTaxPeyer.Add(indTaxPayer);

                                break;

                            case 2:
                                Console.Write("Entre com o numero de funcionários da empresa: ");
                                int numberOfEmployees = int.Parse(Console.ReadLine());
                                Company compTaxPayer = new Company(name, anualIncome, numberOfEmployees);
                                listTaxPeyer.Add(compTaxPayer);
                                break;

                            default:
                                Console.WriteLine("É necessário informar o tipo de contribuinte!");
                                break;
                        }
                    }

                    Console.Write("\nDeseja cadastrar outro contribuinte? (S/N): ");
                    response = char.Parse(Console.ReadLine());

                } while (response == 's' || response == 'S');

                double total = 0;
                Console.WriteLine("\nCONTRIBUIÇÕES:");
                foreach (TaxPayer item in listTaxPeyer)
                { Console.WriteLine(item);
                    total += item.Tax();
                }
                Console.WriteLine("Total de contribuições: " + total);
            }
        }
    }
}