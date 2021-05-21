using System;
using System.Globalization;

namespace Static003
{
    class Program
    {
        //Agora, nosso programa usa a classe Calculadora como uma classe static, ou seja,
        //uma classe que pode ser chamada pelo nome da classe e que não precisa ser instanciada

        static void Main(string[] args)
        {

            double raio, circ, volume;
            Console.Write("Entre com o valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            circ = Calculadora.Circunferencia(raio);
            volume = Calculadora.Volume(raio);

            Console.WriteLine("Valor da Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }


    }
}
