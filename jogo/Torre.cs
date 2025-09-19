using tabuleiro;

namespace jogo
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor){ }

        public override string ToString()
        {
            return cor == Cor.Branca ? "♖" : "♜";
        }
    }
}