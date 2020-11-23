using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JogoDUDU
{
    public static class Arma
    {
        public static int velocidadeBala;
        public static Boolean existeBala;
        public static string lado;
        public static int qntBalas;

        static public void Reset()
        {
            existeBala = false;
            velocidadeBala = 10;
        }

        public static PictureBox AtiraPicBox(Image fotoBala)
        {
            PictureBox picBala = new PictureBox();
            picBala.Tag = "bala" + Arma.lado;
            picBala.BackColor = System.Drawing.Color.Transparent;
            picBala.Visible = true;
            picBala.TabStop = false;
            picBala.Image = fotoBala;


            if (Arma.lado == "direita")
            {
                picBala.Location = new System.Drawing.Point(Jogador.posicaoDireita + 5, Jogador.posicaoCima + Jogador.tamanhoJogador.Height / 5);
                picBala.Size = new System.Drawing.Size(24, 12);
            }
            else if (Arma.lado == "esquerda")
            {
                picBala.Location = new System.Drawing.Point(Jogador.posicaoEsquerda - 30, Jogador.posicaoCima + Jogador.tamanhoJogador.Height / 5);
                picBala.Size = new System.Drawing.Size(24, 12);
            }
            else if (Arma.lado == "cima")
            {
                picBala.Location = new System.Drawing.Point(Jogador.posicaoDireita - 17, Jogador.posicaoCima -40);
                picBala.Size = new System.Drawing.Size(12, 24);
            }
            else if (Arma.lado == "baixo")
            {
                picBala.Location = new System.Drawing.Point(Jogador.posicaoDireita - 17, Jogador.posicaoBaixo + 10);
                picBala.Size = new System.Drawing.Size(12, 24);
            }

            return picBala;
        }
    }
}
