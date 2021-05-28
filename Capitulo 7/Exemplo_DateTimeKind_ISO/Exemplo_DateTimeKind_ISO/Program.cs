using System;

namespace Exemplo_DateTimeKind_ISO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tDateTimeKind e ISO 8601");
            Console.WriteLine("\nMuito usado por empresas" +
                "Consiste em usar o padrão de horário mundial UTC para armazenar datas e então," +
                "\nse caso for preciso usar no horário local, poderá ser convertido novamente.");

            DateTime dataLocal = new DateTime(2000, 08, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dataUtc = new DateTime(2000, 08, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime data = new DateTime(2000, 08, 15, 13, 5, 58);

            Console.WriteLine("\n");

            Console.WriteLine($"Data local: {dataLocal}");
            Console.WriteLine($"Data Kind: {dataLocal.Kind}");
            Console.WriteLine($"Data to Local: {dataLocal.ToLocalTime()}");
            Console.WriteLine($"Data to Utc: {dataLocal.ToUniversalTime()}");
            Console.WriteLine();

            Console.WriteLine("Data UTC: " + dataUtc);
            Console.WriteLine("Data UTC Kind: " + dataUtc.Kind);
            Console.WriteLine("Data UTC to Local: " + dataUtc.ToLocalTime());
            Console.WriteLine("Data UTC to Utc: " + dataUtc.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("Data: " + data);
            Console.WriteLine("Data Kind: " + data.Kind);

            //Tipo não especificado pode gerar problemas na conversão
            Console.WriteLine("Data to Local: " + data.ToLocalTime());
            Console.WriteLine("Data to Utc: " + data.ToUniversalTime());
            Console.WriteLine();

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();

            //O tipo deve estar explícito para converter assim, senão dá erro
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
    }
}
