using System;

namespace Exemplo_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            int escolha;

            Console.WriteLine("Exemplo Switch Case");
            Console.WriteLine();
            Console.WriteLine("\tInteressante para substituir vários if-else encadeados.");
            Console.WriteLine("\tPor exemplo numa escolha de respostas, como em um menu.");

            Console.WriteLine("[1] Bom dia!");
            Console.WriteLine("[2] Boa tarde!");
            Console.WriteLine("[3] Boa noite!");
            Console.WriteLine("[4] Outro");
            Console.WriteLine("[5] Sair");

            Console.Write("Sua escolha: ");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                //Caso a escolha seja igual a um dos valores a seguir, ações serão feitas
                case 1:
                    Console.WriteLine("Bom dia pra você também!");
                    break;

                case 2:
                    Console.WriteLine("Boa tarde pra você também!");
                    break;

                case 3:
                    Console.WriteLine("Boa noite pra você também!");
                    break;

                case 4:
                    Console.WriteLine("Opa! Bão?");
                    break;

                case 5:
                    Console.WriteLine("Tchau!");
                    break;

                //Se não ocorrer nenhuma das ações acima, acontece o que está indicado abaixo:
                default:
                    Console.WriteLine("Opa, essa opção não tem não!");
                    break;

            }

        }
    }
}
