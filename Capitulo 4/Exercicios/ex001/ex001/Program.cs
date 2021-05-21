using System;
using System.Globalization;

namespace ex001
{
    //Criar classe static que converte o valor de dólares em reais, recebendo a
    //cotação do dólar
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao, dolares, reais;

            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            dolares = double.Parse(Console.ReadLine());

            reais = ConversorDeMoeda.ValorEmReais(cotacao, dolares);
            Console.Write("Valor a ser pago em reais = " + reais.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
