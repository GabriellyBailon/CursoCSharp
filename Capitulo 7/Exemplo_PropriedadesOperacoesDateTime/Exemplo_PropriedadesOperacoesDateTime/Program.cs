using System;

namespace Exemplo_PropriedadesOperacoesDateTime
{
    //Aula 91
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine("\tPropriedades e Operações DateTime");

            Console.WriteLine();
            Console.WriteLine(d);
            Console.WriteLine($"1) Date: {d.Date}");
            Console.WriteLine($"2) Day: {d.Day}");
            Console.WriteLine($"3) DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
            Console.WriteLine($"5) Hour: {d.Hour}");
            Console.WriteLine($"6) Kind: {d.Kind}");
            Console.WriteLine($"7) Millisecond: {d.Millisecond}");
            Console.WriteLine($"8) Minute: {d.Minute}");
            Console.WriteLine($"9) Month: {d.Month}");
            Console.WriteLine($"10) Second: {d.Second}");
            Console.WriteLine($"11) Ticks: {d.Ticks}");
            Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"13) Year: {d.Year}");

            //Conversão para impressão

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();
            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            //Operações possíveis
            DateTime x = DateTime.Now;
            DateTime y;
            //Adicionando períodos
            y = x.AddDays(12);
            y = x.AddHours(12);
            y = x.AddMilliseconds(500);
            y = x.AddMinutes(5);
            y = x.AddMonths(4);
            y = x.AddSeconds(30);
            y = x.AddTicks(900000000L);
            y = x.AddYears(2);
            TimeSpan t = x.Subtract(d2);
            y = x.Subtract(t);


        }
    }
}
