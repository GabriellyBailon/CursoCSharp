using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio001_Heranca.Entities;

namespace Exercicio001_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTrabalhadores;
            List<Employee> employees = new List<Employee>();

            Console.Write("Quantos trabalhadores serão cadastrados? ");
            numTrabalhadores = int.Parse(Console.ReadLine());

            for(int i = 0; i < numTrabalhadores; i++)
            {

                Console.WriteLine();
                Console.WriteLine($"Dados do funcionário #{i + 1}:");
                Console.Write("O trabalhador é terceirizado? ");
                string resposta;
                resposta = Console.ReadLine().ToUpper();

                if(resposta[0] == 'S')
                {
                    string nome;
                    int horas;
                    double valorPorHora, despesaAdicional;
                    
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Horas: ");
                    horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Despesa adicional: ");
                    despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee terceirizado = new Terceirizado(nome, horas, valorPorHora, despesaAdicional);

                    employees.Add(terceirizado);
                }
                else
                {
                    string nome;
                    int horas;
                    double valorPorHora;

                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Horas: ");
                    horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new Employee(nome, horas, valorPorHora);

                    employees.Add(employee);
                }
            }

            Console.WriteLine("Pagamentos: ");

            foreach (Employee trabalhador in employees)
            {
                Console.Write($"\n{trabalhador.Name} - $ {trabalhador.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
