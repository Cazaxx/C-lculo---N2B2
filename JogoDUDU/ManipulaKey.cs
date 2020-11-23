using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDUDU
{
    static class ManipulaKey
    {
        public static Boolean podeDireita, podeEsquerda, podeCima, podeBaixo;

        public static Boolean jogadorDireita, jogadorEsquerda, jogadorCima, jogadorBaixo;

        public static Boolean atiraDireita, atiraEsquerda, atiraCima, atiraBaixo, atira;

        public static void ValidaKeyDown(Keys chave)
        {
            if (chave == Keys.Up || chave == Keys.W)
            {
                Jogador.lado = "cima";
                jogadorCima = true;
                Imagens.trocaImagemJogador = true;
            }

            if (chave == Keys.Down || chave == Keys.S)
            {
                Jogador.lado = "baixo";
                jogadorBaixo = true;
                Imagens.trocaImagemJogador = true;
            }

            if (chave == Keys.Right || chave == Keys.D)
            {
                Jogador.lado = "direita";
                jogadorDireita = true;
                Imagens.trocaImagemJogador = true;
            }

            if (chave == Keys.Left || chave == Keys.A)
            {
                Jogador.lado = "esquerda";
                jogadorEsquerda = true;
                Imagens.trocaImagemJogador = true;
            }

            if (chave == Keys.Space)
            {
                atira = true;
            }
        }

        public static void ValidaKeyUp(Keys chave)
        {
            if (chave == Keys.Up || chave == Keys.W)
            {
                jogadorCima = false;
            }

            if (chave == Keys.Down || chave == Keys.S)
            {
                jogadorBaixo = false;
            }

            if (chave == Keys.Right || chave == Keys.D)
            {
                jogadorDireita = false;
            }

            if (chave == Keys.Left || chave == Keys.A)
            {
                jogadorEsquerda = false;
            }

            if (chave == Keys.Space)
            {
                atira = false;
            }
        }

        public static void ResetPossibilidadeAndar()
        {
            podeDireita = true;
            podeEsquerda = true;
            podeCima = true;
            podeBaixo = true;
        }

        public static void Reset()
        {
            ResetPossibilidadeAndar();

            jogadorBaixo = false;
            jogadorCima = false;
            jogadorDireita = false;
            jogadorEsquerda = false;


            atiraBaixo = false;
            atiraCima = false;
            atiraDireita = false;
            atiraEsquerda = false;
            atira = false;
        }
    }
}
