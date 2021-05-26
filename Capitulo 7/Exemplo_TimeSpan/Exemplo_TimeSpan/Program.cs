using System;

namespace Exemplo_TimeSpan
{
    class Program

        //Com o TimeSpan, trabalhamos com um intervalo de tempo
    {
        static void Main(string[] args)
        {
            //Construtores do TimeSpan
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(0, 1, 30);

            //Passando ticks como parâmetro
            TimeSpan t3 = new TimeSpan(900000000L);

            //Com dia
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

            //Com dia e milissegundos
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 300);

            Console.WriteLine("\tExemplo de usos do TimeSpan");
            Console.WriteLine($"\nQuando se cria uma nova instância de TimeSpan: {t1}");
            Console.WriteLine($"Instanciando colocando um período de tempo: {t2}");
            Console.WriteLine($"Passando ticks e retornando o período de tempo: {t3}");
            Console.WriteLine($"Período de tempo com dia também: {t4}");
            Console.WriteLine($"Período de tempo com dia e milissegundos: {t5}");
            Console.WriteLine("--------------------------------------------------------------");

            //Usando o TimeSpan.From

            Console.WriteLine("\n\tUsando o TimeSpan.From");

            //Faz a conversão, por exemplo
            //Quanto tempo dura um dia e meio ou 1 hora e meia
            //Isso em períodos de tempo

            TimeSpan f1 = TimeSpan.FromDays(1.5);
            TimeSpan f2 = TimeSpan.FromHours(1.5);
            TimeSpan f3 = TimeSpan.FromMinutes(1.5);
            TimeSpan f4 = TimeSpan.FromSeconds(1.5);
            TimeSpan f5 = TimeSpan.FromMilliseconds(1);
            TimeSpan f6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine();
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine(f4);
            Console.WriteLine(f5);
            Console.WriteLine(f6);




        }
    }
}
