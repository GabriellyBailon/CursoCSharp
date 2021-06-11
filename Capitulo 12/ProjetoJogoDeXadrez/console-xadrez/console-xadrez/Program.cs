using System;
using tabuleiro;

namespace console_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao posicao = new Posicao(1, 2);

            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            Console.WriteLine(posicao);
        }
    }
}
