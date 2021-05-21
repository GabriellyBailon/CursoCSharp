using System;

namespace ExercicioPratico
{
    class Program
    {
        static void Main(string[] args)
        {
            int numConta;
            string nomeTitular;
            char haveraDeposito;
            double valorInicial, deposito, saque;

            //Declaração do objeto conta SEM A INSTANCIAÇÃO
            Conta conta1;

            Console.Write("Entre o número da conta: ");
            numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n): ");
            haveraDeposito = char.Parse(Console.ReadLine());
            if (haveraDeposito == 'S' || haveraDeposito == 's')
            {
                Console.Write("Entre com o valor do depósito: ");
                valorInicial = double.Parse(Console.ReadLine());

                //Declarar fora do if e instanciar aqui para não ocorrer erro de escopo
                conta1 = new Conta(nomeTitular, numConta, valorInicial);
            }
            else
            {
                //Declarar fora do else e instanciar aqui para não ocorrer erro de escopo
                conta1 = new Conta(nomeTitular, numConta);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta1.ToString());

            Console.Write("\nEntre com um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine());
            conta1.FazerDeposito(deposito);
            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta1.ToString());

            Console.Write("\nEntre com um valor para saque: ");
            saque = double.Parse(Console.ReadLine());
            conta1.FazerSaque(saque);
            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(conta1.ToString());



        }
    }
}
