using tabuleiro;

namespace jogo
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor){ }

        public override string ToString()
        {
            return "♕";
        }
    }
}