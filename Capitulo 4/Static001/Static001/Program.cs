using System;
using System.Globalization;

namespace Static001
{
    class Program
    {
        //Declaração de uma constante
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            double raio, circ, volume;
            Console.Write("Entre com o valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            circ = Circunferencia(raio);
            volume = Volume(raio);
            Console.WriteLine("Valor da Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));


        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return (4.0/ 3.0) * (Pi * Math.Pow(r, 3));
        }
    }
}
