using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncionarios, idAumento;
            double porcentagem;
            List<Funcionario> listaFuncionarios = new List<Funcionario>();


            Console.Write("Quantos funcionários serão registrados? ");
            numFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < numFuncionarios; i++)
            {
                int id;
                string nome;
                double salario;

                Console.WriteLine($"\nFuncionário {i + 1}");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salário: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFuncionarios.Add(new Funcionario(id, nome, salario));

            }

            Console.Write("Insira o id do funcionário que terá seu salário aumentado: ");
            idAumento = int.Parse(Console.ReadLine());

            Funcionario funcionarioPesquisa = listaFuncionarios.Find(x => x.Id == idAumento);
            if (funcionarioPesquisa != null)
            {
                Console.Write("Insira a porcentagem de aumento que esse funcionário vai receber: ");
                porcentagem = double.Parse(Console.ReadLine());
                funcionarioPesquisa.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse funcionário não existe!");
            }


            foreach (Funcionario funcionario in listaFuncionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}
