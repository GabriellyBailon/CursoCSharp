using System;

namespace Vetores_ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            double soma = 0.0;
            double media;

            //Criação de um vetor de objetos
            Product[] vetorProdutos = new Product[n];

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                //Instanciação automática dos objetos, sem construtores
                vetorProdutos[i] = new Product {Name = name, Price = price};
            }

            //Acessar um atributo em um vetor de objetos
            for (int i = 0; i < n; i++)
            {
                soma += vetorProdutos[i].Price;
            }

            media = soma / n;

            Console.WriteLine($"Average price: {media}");

        }
    }
}
