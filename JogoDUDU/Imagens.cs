using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JogoDUDU
{
    public static class Imagens
    {
        public static Boolean trocaImagemJogador;

        public static Image MudaImagem(Skin imagens, string imagem)
        {
            if (imagem == "jogador")
                imagem = Jogador.lado;
            else if (imagem == "bala")
                imagem = Arma.lado;


            if (imagem == "cima")
                return imagens.imgCima;
            else if (imagem == "baixo")
                return imagens.imgBaixo;
            else if (imagem == "direita")
                return imagens.imgDireita;
            else
                return imagens.imgEsquerda;

        }
    }
}
