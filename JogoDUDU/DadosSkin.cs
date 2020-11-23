using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JogoDUDU
{
    static public class DadosSkin
    {
        public static string chaveJogador, chaveInimigo, chaveBala;

        public static Skin CapturaSkin(string nome)
        {
            return new Skin()
            {
                imgBaixo = Image.FromFile(nome + "Baixo.png"),
                imgCima = Image.FromFile(nome + "Cima.png"),
                imgEsquerda = Image.FromFile(nome + "Esquerda.png"),
                imgDireita = Image.FromFile(nome + "Direita.png"),
            };
        }
        
    }

}
