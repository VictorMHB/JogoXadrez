using System;
using tabuleiro;
using jogo;
using System.Runtime.CompilerServices;

namespace xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));
                tabuleiro.inserirPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 4));

                tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(7, 0));
                tabuleiro.inserirPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(7, 7));
                tabuleiro.inserirPeca(new Rainha(tabuleiro, Cor.Branca), new Posicao(7, 3));


                Tela.imprimirTabueliro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();    
            
        }
    }
}