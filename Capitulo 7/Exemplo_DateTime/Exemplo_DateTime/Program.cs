using System;
using System.Globalization;

namespace Exemplo_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            //Instancia o dia passado por parâmetro às 00:00
            DateTime d2 = new DateTime(2018, 11, 25);

            //Além do dia, passa o horário também
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);

            //Com os milisegundos
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 20);

            DateTime d5 = DateTime.Today;

            //Horário no Meridiano de Greenwich
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine("\tExemplo DateTime");
            Console.WriteLine();
            Console.WriteLine($"Data atual: {d1}");
            Console.WriteLine(d1.Ticks);
            Console.WriteLine();
            Console.WriteLine(d2);
            Console.WriteLine();
            Console.WriteLine(d3);
            Console.WriteLine();
            Console.WriteLine(d4);
            Console.WriteLine();
            Console.WriteLine(d5);
            Console.WriteLine();
            Console.WriteLine(d6);

            Console.WriteLine("\n\tConversão de Datetime");

            //Conversão com data e conversão com data e horário
            DateTime c1 = DateTime.Parse("2000-08-15");
            DateTime c2 = DateTime.Parse("2000-08-15 13:05:58");

            //Formato mais utilizado no Brasil
            DateTime c3 = DateTime.Parse("15/08/2000");
            DateTime c4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine();
            Console.WriteLine(c1);
            Console.WriteLine();
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine(c3);
            Console.WriteLine();
            Console.WriteLine(c4);

            Console.WriteLine("\n\t Conversão personalizada");

            DateTime p1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime p2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
