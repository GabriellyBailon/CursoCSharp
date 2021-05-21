using System;

namespace ex001_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numQuartos;

            Console.Write("Quantos quartos você deseja alugar? ");
            numQuartos = int.Parse(Console.ReadLine());
            Locatarios[] vetor = new Locatarios[9];

            for(int i = 0; i < numQuartos; i++)
            {
                Console.WriteLine($"Aluguel {i+1}: ");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Número do quarto desejado: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Locatarios(nome, email, quarto);
            }

            for(int i = 0; i < 9; i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine(vetor[i]);
                }
            }


        }
    }
}
