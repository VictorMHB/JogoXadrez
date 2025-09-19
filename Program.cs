using System;
using tabuleiro;
using jogo;

namespace xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicao().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicao().toPosicao();

                    partida.executarMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadLine();    
            
        }
    }
}