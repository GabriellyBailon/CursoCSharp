using System;

namespace Exemplo_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo Matrizes");

            //Instanciação de matriz
            double[,] matriz = new double[2, 3];

            //Exemplo de inserção
            matriz[0, 0] = 1.0;

            //O Lenght mostra o tamanho da matriz, quantas posições ela tem ao todo
            Console.WriteLine(matriz.Length);

            //O Rank mostra o número de linhas da matriz
            Console.WriteLine(matriz.Rank);

            //GetLenght(0) mostra o número de linhas da matriz
            Console.WriteLine($"A matriz tem {matriz.GetLength(0)} linhas");

            //GetLenght(0) mostra o número de colunas da matriz
            Console.WriteLine($"A matriz tem {matriz.GetLength(1)} colunas");
        }
    }
}
