﻿using System;
using tabuleiro;

namespace console_xadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i=0; i < tab.Linhas; i++)
            {
                for(int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.GetPeca(i, j) == null)
                    {
                        Console.Write("-" + " ");
                    }
                    else
                    {
                        Console.Write(tab.GetPeca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }

        }

    }
}
