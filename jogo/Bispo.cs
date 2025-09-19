using tabuleiro;

namespace jogo
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor){ }

        public override string ToString()
        {
            return cor == Cor.Branca ? "♗" : "♝";
        }
    }
}