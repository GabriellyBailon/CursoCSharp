using System;

namespace Exemplo_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração na mesma linha
            string[] vetorExemplo = new string[] {"Maria", "João", "Bob"};

            Console.WriteLine("Exemplo Foreach");
            foreach(string nome in vetorExemplo)
            {
                Console.WriteLine(nome);
            }


        }
    }
}
