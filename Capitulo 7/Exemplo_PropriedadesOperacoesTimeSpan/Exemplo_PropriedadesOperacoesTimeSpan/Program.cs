using System;

namespace Exemplo_PropriedadesOperacoesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1;
            TimeSpan t2;
            TimeSpan t3;

            Console.WriteLine("\tOperações e exemplos TimeSpan");

            t1 = TimeSpan.MaxValue;
            t2 = TimeSpan.MinValue;
            t3 = TimeSpan.Zero;

            Console.WriteLine($"\nMax value: {t1}");

            //Pode ser negativo
            Console.WriteLine($"Min value: {t2}");
            Console.WriteLine($"Zero: {t3}");
            Console.WriteLine();

            //Propriedades
            Console.WriteLine("\tPropriedades");
            Console.WriteLine();
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            Console.WriteLine();

            //Operações
            Console.WriteLine("\tOperações");
            Console.WriteLine();

            //Declaração
            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);

            //Adição
            TimeSpan sum = t4.Add(t5);

            //Subtração
            TimeSpan dif = t4.Subtract(t5);

            //Multiplicação (por double)
            TimeSpan mult = t5.Multiply(2.0);

            //Divisão (por double)
            TimeSpan div = t5.Divide(2.0);

            Console.WriteLine(t5);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

        }
    }
}
