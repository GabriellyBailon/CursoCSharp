using System;
using Exemplo002_Composicao.Entities;
using Exemplo002_Composicao.Entities.Enums;

namespace Exemplo002_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameDept, nome;
            double salarioBase;
            int numContratos, mes, ano;
            string mesAno;

            Console.Write("Entre com o nome do departamento: ");
            nameDept = Console.ReadLine();

            Console.WriteLine("Entre com os dados do trabalhador");
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Insira o salário do trabalhador: ");
            salarioBase = double.Parse(Console.ReadLine());

            Department department = new Department(nameDept);
            Worker worker = new Worker(nome, level, salarioBase, department);

            Console.Write("Quantos contratos para esse trabalhador? ");
            numContratos = int.Parse(Console.ReadLine());

            for(int i = 0; i< numContratos; i++)
            {
                DateTime date;
                double valorPorHora;
                int duracao;

                Console.WriteLine($"Entre com dos dados do contrato #{i+1} ");
                Console.Write("Insira a data: DD/MM/AAAA: ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração (em horas) do contrato: ");
                duracao = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(date, valorPorHora, duracao);
                worker.AddContract(contrato);
            }

            Console.WriteLine();

            Console.Write("Entre com o mês e o ano no formato MM/AAAA para calcular os ganhos: ");
            mesAno = Console.ReadLine();
            mes = int.Parse(mesAno.Substring(0, 2));
            ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Department.Name}");
            Console.WriteLine($"Ganhos em {mesAno}: {worker.Income(ano, mes)}");

        }
    }
}
