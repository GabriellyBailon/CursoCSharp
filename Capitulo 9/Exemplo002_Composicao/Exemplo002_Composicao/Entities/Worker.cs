using System.Collections.Generic;
using Exemplo002_Composicao.Entities.Enums;

namespace Exemplo002_Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        //Lista de contratos e com instância para garantir que não será vazia
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        //Quando temos algo (um para vários, no caso 1 cliente pode ter vários contratos),
        //não inicializamos essa lista ou conexão no construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //Quanto o funcionário ganhou em certo ano e certo mês
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year)
                {
                    sum += contract.TotalValue(); 
                }
            }

            return sum;

        }



    }

}
