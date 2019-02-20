using A118_Enumeracao.Entities.Enums;
using System.Collections.Generic;

namespace A118_Enumeracao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double Salary { get; set; }
        public Department Dapartment { get; set; } //1 worker has only 1 department
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//1 worker has 0 or more department

        public Worker()
        { }

        public Worker(string name, WorkerLevel level, double salary, Department department)
        {
            Name = name;
            Level = level;
            Salary = salary;
            Dapartment = department;
        }

        public void AddContract(HourContract hourContract)
        {
            Contracts.Add(hourContract);
        }

        public void RemoveContract(HourContract hourContract)
        {
            Contracts.Remove(hourContract);
        }

        public double Income(int month, int year)
        {
            double resultValue = Salary;
            foreach (HourContract cont in Contracts)
            {
                if (cont.Date.Year == year && cont.Date.Month == month)
                {
                    resultValue += cont.TotalValue();
                }
            }

            return resultValue;
        }
    }
}
