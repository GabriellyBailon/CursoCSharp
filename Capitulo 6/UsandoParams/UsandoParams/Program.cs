using System;

namespace UsandoParams
{
    class Program
    {
        //Com o params, podemos passar vários parâmetros para uma função
        //de uma forma muito prática e sem o uso de sobrecarga.

        static void Main(string[] args)
        {
            int s2;

            //Modo sem params

            //Instanciação pode ser feita diretamente como aqui, ou não
            //  int s1 = Calculadora.Soma(new int[] {3, 5, 9});
            //  Console.WriteLine(s1);

            //Modo com params
            s2 = Calculadora.Soma(3, 5, 9, 2, 2);
            Console.WriteLine(s2);

        }
    }
}
