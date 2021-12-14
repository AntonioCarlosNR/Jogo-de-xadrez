using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.WriteLine("Turno" + partida.turno);
                    Console.WriteLine("Aguardando jogada:" + partida.jogadorAtual);

                    //imprime campo de seleção da peça
                    Console.WriteLine();
                    Console.WriteLine("Origem");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    //imprime posições possiveis de movimentação
                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                    //imprime campo para mover a peça
                    Console.WriteLine();
                    Console.WriteLine("Destino");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.realizaJogada(origem, destino);
                }                

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
