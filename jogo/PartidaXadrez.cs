using System.Runtime.InteropServices;
using tabuleiro;

namespace jogo
{
    class PartidaXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            
            inserirPecas();
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = tabuleiro.removerPeca(origem);
            peca.incrementarMovimentos();
            Peca pecaCapturada = tabuleiro.removerPeca(destino);
            tabuleiro.inserirPeca(peca, destino);
        }

        private void inserirPecas()
        {
            tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('a', 1).toPosicao());
            tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('h', 1).toPosicao());
            tabuleiro.inserirPeca(new Rei(tabuleiro, Cor.Preta), new PosicaoXadrez('e', 1).toPosicao());

            tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('a', 8).toPosicao());
            tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('h', 8).toPosicao());
            tabuleiro.inserirPeca(new Rainha(tabuleiro, Cor.Branca), new PosicaoXadrez('d', 8).toPosicao());
        }
    }
}