using System;
using tabuleiro;
using jogo;

namespace xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0,0));
            tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));
            tabuleiro.inserirPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 3));


            Tela.imprimirTabueliro(tabuleiro);

            Console.ReadLine();    
            
        }
    }
}