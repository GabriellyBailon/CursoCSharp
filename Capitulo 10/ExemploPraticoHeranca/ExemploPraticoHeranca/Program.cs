using System;
using System.Collections.Generic;
using ExemploPraticoHeranca.Enums;
using ExemploPraticoHeranca.Entities;

namespace ExemploPraticoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            double numFormas;
            List<Forma> formas = new List<Forma>();

            Console.Write("Entre com o número de formas: ");
            numFormas = double.Parse(Console.ReadLine());

            for(int i = 0; i < numFormas; i++)
            {
                string tipo;
                Cor cor;

                Console.WriteLine($"Forma #{i + 1}");

                Console.Write("Retângulo ou Círculo (r ou c)? ");
                tipo = Console.ReadLine().ToLower();

                Console.Write("Qual a cor? ");
                cor = Enum.Parse<Cor>(Console.ReadLine());

                if (tipo[0] == 'r')
                {
                    double altura, largura;

                    Console.Write("Altura: ");
                    altura = double.Parse(Console.ReadLine());
                    Console.Write("Largura: ");
                    largura = double.Parse(Console.ReadLine());

                    Forma retangulo = new Retangulo(largura, altura, cor);
                    formas.Add(retangulo);
                }
                else
                {
                    double raio;
                    Console.Write("Medida do raio: ");
                    raio = double.Parse(Console.ReadLine());

                    Forma circulo = new Circulo(raio, cor);

                    formas.Add(circulo);
                }
            }

            Console.WriteLine("\nÁreas das formas: ");
            foreach (Forma forma in formas)
            {
                Console.WriteLine(forma.Area().ToString("F2"));
            }
        }
    }
}
