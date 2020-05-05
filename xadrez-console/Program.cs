using System;
using xadrez_console.Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            TabuleiroC tab = new TabuleiroC(8, 8);

            Tela.imprimirTabuleiro(tab);

            
                
        }
    }
}
