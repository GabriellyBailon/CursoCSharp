using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    public class Tabuleiro
    {
        //Dimensões do tabuleiro
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        //Matriz de peças
        private Peca[,] Pecas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
    }
}
