using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    public class Peca
    {
        //Composição: Classe que utiliza outra classe como propriedade. Importante!
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }

        public int QteMovimentos { get; protected set; }

        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QteMovimentos = 0;              //inicialmente, todas as peças têm 0 movimentos feitos
        }

        public void IncrementarQtdMovimentos()
        {
            QteMovimentos++;
        }
    }
}
