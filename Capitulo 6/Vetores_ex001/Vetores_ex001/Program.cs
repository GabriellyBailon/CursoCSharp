using System;
using System.Globalization;

namespace Vetores_ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma= 0, media = 0;

            Console.Write("Insira o tamanho desejado do seu vetor: ");
            int n = int.Parse(Console.ReadLine());

            //Criação de um vetor
            double[] vetor = new double[n];

            //Atribuição de valores
            for(int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Soma dos valores
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            media = soma / n;

            //Impressão dos valores
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine($"A média dos valores inseridos foi {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
