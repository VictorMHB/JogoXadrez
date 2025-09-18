using tabuleiro;

namespace jogo
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor){ }

        public override string ToString()
        {
            return cor == Cor.Branca ? "♟" : "♙";
        }
    }
}