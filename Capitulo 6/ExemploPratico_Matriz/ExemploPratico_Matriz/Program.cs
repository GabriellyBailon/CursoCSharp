using System;
using System.Collections.Generic;

namespace ExemploPratico_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, numerosNegativos = 0;
            int[,] matriz;

            Console.Write("Insira o número que será o número de linhas e colunas da matriz quadrada: ");
            n = int.Parse(Console.ReadLine());
            matriz = new int[n, n];

            Console.WriteLine("Insira os dados da matriz: ");

            for(int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Diagonal principal: ");
            for(int indice = 0; indice< n; indice++)
            {
                Console.Write($"{matriz[indice,indice]} ");
            }

            //Números negativos na matriz
            for (int l = 0; l < n; l++)
            {
                for(int c = 0; c < n; c++)
                {
                    if (matriz[l,c] < 0)
                    {
                        numerosNegativos++;
                    }
                }
            }

            Console.Write("Números negativos digitados: ");
            Console.WriteLine(numerosNegativos);




            



        }
    }
}
