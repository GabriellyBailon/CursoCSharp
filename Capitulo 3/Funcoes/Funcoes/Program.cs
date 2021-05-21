using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            int resultado;

            Console.WriteLine("Digite três números: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            resultado = Maior(n1, n2, n3);

            Console.WriteLine($"O maior número digitado foi {resultado}");

        }

        static int Maior(int a, int b, int c)
        {
            int maior;

            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > a && b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }
    }
}
