using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JogoDUDU
{
    public static class Jogador
    {
        public static string lado;

        public static int velocidade = 4;

        public static int posicaoEsquerda, posicaoDireita, posicaoCima, posicaoBaixo;

        public static Point localizacaoArea = new Point(-84, 399);
        public static Point localizacaoJogador = new Point(0, 469);
        public static Size tamanhoJogador = new Size(24, 32);
        public static Size tamanhoArea = new Size(192, 192);

        public static void Reset(Point jogador, Point area)
        {
            lado = "direita";
            localizacaoArea = area;
            localizacaoJogador = jogador;
            tamanhoJogador = new Size(24, 32);
            tamanhoArea = new Size(192, 192);
        }

        

    
    }
}
