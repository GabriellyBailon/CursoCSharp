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

        //Matriz de peças é privada por segurança,
        //mas ainda precisamos ter acesso às peças
        //para algumas operações, para isso vamos utilizar o método a seguir
        public Peca GetPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }
    }
}
