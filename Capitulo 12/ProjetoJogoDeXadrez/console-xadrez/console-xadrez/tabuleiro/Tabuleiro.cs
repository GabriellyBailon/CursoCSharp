using System;

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

        public Peca GetPeca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return GetPeca(posicao) != null;

        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao) == true)
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (GetPeca(posicao) == null)
            {
                return null;
            }

            //Guarda a peça
            Peca auxiliar = GetPeca(posicao);
            //Mas sem posição pois ela estará removida
            auxiliar.Posicao = null;
            Pecas[posicao.Linha, posicao.Coluna] = null;

            return auxiliar;


        }

        public bool PosicaoValida(Posicao posicao)
        {
            if(posicao.Linha < 0 || posicao.Linha > Linhas || posicao.Coluna < 0 || posicao.Coluna > Colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }

    }
}
