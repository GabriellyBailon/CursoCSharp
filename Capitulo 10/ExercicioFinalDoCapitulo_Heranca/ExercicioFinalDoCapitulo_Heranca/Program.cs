using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFinalDoCapitulo_Heranca.Entities;

namespace ExercicioFinalDoCapitulo_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            int contribuintes;
            List<Pessoa> pessoas = new List<Pessoa>();
            double soma = 0.0;

            Console.Write("Quantos contribuíntes serão cadastrados? ");
            contribuintes = int.Parse(Console.ReadLine());

            for(int i = 0; i < contribuintes; i++)
            {
                string tipoDoContribuinte, nome;
                double rendaAnual;

                Console.WriteLine($"\nDados do funcionário #{i + 1}: ");
                Console.Write("Tipo de contribuínte (f/j): ");
                tipoDoContribuinte = Console.ReadLine().ToLower();

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipoDoContribuinte[0] == 'f')
                {
                    double gastosComSaude;
                    Console.Write("Gastos com saúde: ");
                    gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Pessoa pessoafisica = new PessoaFisica(nome, rendaAnual, gastosComSaude);
                    pessoas.Add(pessoafisica);
                }
                else
                {
                    int funcionarios;
                    Console.Write("Número de funcionários: ");
                    funcionarios = int.Parse(Console.ReadLine());

                    Pessoa pessoajuridica = new PessoaJuridica(nome, rendaAnual, funcionarios);
                    pessoas.Add(pessoajuridica);
                }

            }

            Console.WriteLine("\nIMPOSTOS PAGOS: ");
            foreach (Pessoa pessoa in pessoas)
            {
                soma += pessoa.CalculaImposto();
                Console.WriteLine(pessoa);
            }

            Console.WriteLine($"\nTotal pago de imposto: ${soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
