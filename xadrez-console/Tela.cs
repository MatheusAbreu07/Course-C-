using System;
using xadrez_console.Tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro (TabuleiroC tab)
        {
            for (int x = 0; x < tab.Linhas; x++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(x,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(x, j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
