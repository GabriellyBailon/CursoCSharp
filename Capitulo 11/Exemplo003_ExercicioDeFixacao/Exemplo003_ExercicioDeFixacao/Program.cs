using System;
using System.Globalization;
using Exemplo003_ExercicioDeFixacao.Entities;
using Exemplo003_ExercicioDeFixacao.Exceptions;

namespace Exemplo003_ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            int numConta;
            string titular;
            double saldoInicial, limiteSaque, saque;

            try
            {
                Console.WriteLine("Entre com os dados da conta");
                Console.Write("Número da conta: ");
                numConta = int.Parse(Console.ReadLine());
                Console.Write("Titular da conta: ");
                titular = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numConta, titular, saldoInicial, limiteSaque);

                Console.Write("\nEntre com a quantidade para saque: ");
                saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(saque);
                Console.WriteLine(conta);
            }
            catch (MenorQueZeroException e)
            {
                Console.WriteLine($"Erro! {e.Message}");
            }
            catch (SaqueMaiorQueLimiteException e)
            {
                Console.WriteLine($"Erro! {e.Message}");
            }
            catch(SaqueMaiorQueSaldoExcepton e)
            {
                Console.WriteLine($"Erro! {e.Message}");
            }

        }
    }
}
