using System;
using System.Globalization;

namespace Exemplo_ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)

        {
            double preco, desconto;

            Console.WriteLine("Exemplo Expressão Condicional Ternária");

            Console.WriteLine("\n\tMuito útil para substituir um if/else simples");

            Console.WriteLine("\nInsira o preço do produto e saiba seu desconto!");
            Console.Write("Preço: ");
            preco = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Variável recebe valor de acordo com a condição
            //Preço maior que 20? Se sim primeira expressão, se não, a segunda condição é realizada
            desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine("\nResultado");
            Console.WriteLine($"Preço: {preco.ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"Desconto: {desconto.ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}
