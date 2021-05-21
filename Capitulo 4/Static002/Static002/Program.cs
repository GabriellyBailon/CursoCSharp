using System;
using System.Globalization;

namespace Static002
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            double raio, circ, volume;
            Console.Write("Entre com o valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            circ = calculadora.Circunferencia(raio);
            volume = calculadora.Volume(raio);

            Console.WriteLine("Valor da Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Valor de Pi: " + calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }


    }
}

