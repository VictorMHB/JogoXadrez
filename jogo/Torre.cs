using tabuleiro;

namespace jogo
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return cor == Cor.Branca ? "♖" : "♜";
        }

        private bool podeMover(Posicao posicao)
        {
            Peca p = tabuleiro.peca(posicao);
            return p == null || p.cor != cor;
        }
        
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao posicao = new Posicao(0, 0);

            //NORTE
            posicao.definirValor(posicao.linha - 1, posicao.coluna);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.linha = posicao.linha - 1;
            }

            //SUL
            posicao.definirValor(posicao.linha + 1, posicao.coluna);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.linha = posicao.linha + 1;
            }

            //LESTE
            posicao.definirValor(posicao.linha, posicao.coluna + 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.coluna = posicao.coluna + 1;
            }

            //OESTE
            posicao.definirValor(posicao.linha, posicao.coluna - 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                {
                    break;
                }
                posicao.coluna = posicao.coluna - 1;
            }

            return mat;
        }
    }
}