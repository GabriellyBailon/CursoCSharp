using System;

namespace Exemplo001
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;

            try
            {
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());

                resultado = n1 / n2;

                Console.WriteLine(resultado);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro! Divisão por 0 não permitida!");
            }

            //Pode-se instanciar uma exceção do tipo para usar seus atributos e/ou métodos ou não
            catch (FormatException e)
            {
                Console.WriteLine($"Erro! O número digitado precisa ser um inteiro! {e.Message}");
            }
        }
    }
}
