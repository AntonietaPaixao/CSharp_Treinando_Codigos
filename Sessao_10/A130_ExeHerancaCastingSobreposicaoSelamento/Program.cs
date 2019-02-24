using System;
using A130_ExeHerancaCastingSobreposicaoSelamento.Entities;
using System.Collections.Generic;

namespace A130_ExeHerancaCastingSobreposicaoSelamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE PROGRAM!\n");

            List<Employee> listEmployee = new List<Employee>();

            //Enquanto o usuário desejar cadastrar um  funcionário, faça:
            Console.Write("\nDeseja cadastrar um funcionário? S/N: ");
            char response = char.Parse(Console.ReadLine());
            if (response == 's' || response == 'S')
            {
                do
                {
                    Console.Write("\nO funcionário será do tipo: 1)Próprio ou 2)Terceirizado: ");
                    int typeEmploy = int.Parse(Console.ReadLine());

                    Console.Write("Entre com o nome do funcionário: ");
                    string name = Console.ReadLine();
                    Console.Write("Entre com a quantidade de horas trabalhadas: ");
                    int hour = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o salário-hora do funcionário: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    //Instancia um tipo de objeto de acordo com o tipo de funcionário desejado
                    Employee emp;
                    if (typeEmploy == 1)
                    {
                        //Instancia funcionário comun
                        emp = new Employee(name, hour, valuePerHour);
                    }
                    else
                    {
                        //Instancia funcionário terceirizado
                        Console.Write("Entre com o valor adicional do funcionário terceirizado: ");
                        double addictionalCharge = double.Parse(Console.ReadLine());
                        emp = new OutsourcedEmployee(addictionalCharge, name, hour, valuePerHour);
                    }

                    //Insere o funcionário na lista
                    listEmployee.Add(emp);

                    Console.Write("\nDeseja cadastrar outro funcionário? S/N: ");
                    response = char.Parse(Console.ReadLine());
                }
                while (response == 's' || response == 'S');

                //Escreve os dados de todos os funcionários na tela
                Console.WriteLine("\nFUNCIONÁRIOS CADASTRADOS:");
                foreach (Employee item in listEmployee)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
