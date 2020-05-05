using System;
using System.Collections.Generic;
using System.Text;

namespace xadrez_console.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public TabuleiroC Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, TabuleiroC tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QtdeMovimentos = 0;
        }
    }
}
