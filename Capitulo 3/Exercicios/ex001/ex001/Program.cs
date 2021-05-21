using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1;
            retangulo1 = new Retangulo();

            Console.WriteLine("Insira a medida da altura do retângulo: ");
            retangulo1.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a medida da largura do retângulo: ");
            retangulo1.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine(retangulo1);
        }
    }
}
