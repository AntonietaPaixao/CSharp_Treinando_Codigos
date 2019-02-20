using System;
using A118_Enumeracao.Entities;
using A118_Enumeracao.Entities.Enums;
using System.Globalization;

namespace A118_Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADMISSION PROGRAM\n");

            Worker work = new Worker();

            Console.Write("Enter departament's name: ");
            Department dept = new Department(Console.ReadLine());
            work.Dapartment = dept;

            Console.WriteLine("\nEnter worker data!");
            Console.Write("Name: ");
            work.Name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            work.Level = Enum.Parse<WorkerLevel>(Console.ReadLine()); //Converting string tipe to ENUM tipe ******************    
            Console.Write("Base salary: ");
            work.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nHow many contracts to this worker?: ");
            int nContracts = int.Parse(Console.ReadLine()); //Number of contracts

            HourContract[] contract = new HourContract[nContracts];

            for (int i = 0; i < nContracts; i++)
            {
                contract[i] = new HourContract();
                Console.WriteLine("\nEnter #" +(i+1)+ " contract data!");
                Console.Write("Date (DD/MM/YYYY): ");
                contract[i].Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                contract[i].ValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                contract[i].Hours = int.Parse(Console.ReadLine());

                work.AddContract(contract[i]);
            }

            Console.Write("\nEnter month and yer to calculate income (mm/yyyy): ");
            string [] date = Console.ReadLine().Split("/");
            double totalValue = work.Income(int.Parse(date[0]), int.Parse(date[1]));
            Console.WriteLine("Name: " + work.Name);
            Console.WriteLine("Departament: " + work.Dapartment.Name);
            Console.WriteLine("Income for " + date[0] + "/" + date[1] + ": " + totalValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
