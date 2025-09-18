using tabuleiro;

namespace jogo
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor){ }

        public override string ToString()
        {
            return cor == Cor.Branca ? "♞" : "♘";
        }
    }
}