using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace JogoDUDU
{
    public static class GlobalConfig
    {
        public static string mapa = "deserto";
        public static int qntChavesAtuais, qntChaves, score;
        public static int scoreVitoria, scoreDerrota, dinheiro;

        public static string dificuldade = "facil";

        public static Boolean muteLigado = false;

        public static void EscolheDificuldade()
        {
            if (GlobalConfig.dificuldade == "facil")
            {
                Jogador.velocidade = 4;
                Arma.qntBalas = 100;
                Inimigo.velocidade = 1;
                Inimigo.iteraVelocidade = 0;
                GlobalConfig.scoreVitoria = 10;
                GlobalConfig.scoreDerrota = 5;
            }
            else if (GlobalConfig.dificuldade == "medio")
            {
                Jogador.velocidade = 4;
                Arma.qntBalas = 20;
                Inimigo.velocidade = 1;
                Inimigo.iteraVelocidade = 1;
                GlobalConfig.scoreVitoria = 30;
                GlobalConfig.scoreDerrota = 10;
            }
            else
            {
                Jogador.velocidade = 4;
                Arma.qntBalas = 5;
                Inimigo.velocidade = 1;
                Inimigo.iteraVelocidade = 2;
                GlobalConfig.scoreVitoria = 50;
                GlobalConfig.scoreDerrota = 10;
            }
        }
    }
}
