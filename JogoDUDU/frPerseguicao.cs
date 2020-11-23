using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace JogoDUDU
{
    public partial class frPerseguicao : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        int velocidadeJogador = 10;
        int velocidadeInimigoVertical = 4, velocidadeInimigoHorizontal = -4;
        int tempoRestante;

        public frPerseguicao()
        {
            InitializeComponent();
            tempoRestante = 15;
            MessageBox.Show("Sobreviva ao Viotti! ", "SOBREVIVA", MessageBoxButtons.OK, MessageBoxIcon.Question);
            lblTempoRestante.Text = tempoRestante.ToString();
            tmrMovimento.Enabled = true;
            Verifica.Enabled = true;
            if (!GlobalConfig.muteLigado)
            {
                player.URL = "PumpedUpKicks.mp3";
                player.controls.play();
            }
        }

        public Boolean ColisaoParede() 
        {
            foreach (Control aux in Controls)
            {
                if ((string)aux.Tag == "wall")
                {
                    if (picJogador.Bounds.IntersectsWith(aux.Bounds))
                        return true;
                }
            }
            return false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            { 
                picJogador.Left += velocidadeJogador;

                if (ColisaoParede())
                    picJogador.Left -= velocidadeJogador;   
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                picJogador.Left -= velocidadeJogador;

                if (ColisaoParede())
                    picJogador.Left += velocidadeJogador; 
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                picJogador.Top -= velocidadeJogador;

                if (ColisaoParede())
                    picJogador.Top += velocidadeJogador;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                picJogador.Top += velocidadeJogador;

                if (ColisaoParede())
                    picJogador.Top -= velocidadeJogador;
            }
        }

        private void tmrMovimento_Tick(object sender, EventArgs e)
        {
            if (picJogador.Bounds.IntersectsWith(picInimigo.Bounds)) 
            {
                tmrMovimento.Stop();
                Verifica.Stop();
                MessageBox.Show("Tente o bônus da próxima vez!", "FALHA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                player.controls.stop();
                Close();
            }
            picInimigo.Left += velocidadeInimigoHorizontal;
            picInimigo.Top += velocidadeInimigoVertical;

        }

        private void Verifica_Tick(object sender, EventArgs e)
        {
            if (picInimigo.Location.X >= picJogador.Location.X && velocidadeInimigoHorizontal > 0)
            {
                velocidadeInimigoHorizontal = -velocidadeInimigoHorizontal;
            }

            if (picInimigo.Location.X <= picJogador.Location.X && velocidadeInimigoHorizontal < 0)
            {
                velocidadeInimigoHorizontal = -velocidadeInimigoHorizontal;
            }

            if (picInimigo.Location.Y <= picJogador.Location.Y && velocidadeInimigoVertical < 0)
            {
                velocidadeInimigoVertical = -velocidadeInimigoVertical;
            }

            if (picInimigo.Location.Y >= picJogador.Location.Y && velocidadeInimigoVertical > 0)
            {
                velocidadeInimigoVertical = -velocidadeInimigoVertical;
            }

            tempoRestante--;
            if (tempoRestante == 0)
            {
                tmrMovimento.Stop();
                Verifica.Stop();
                GlobalConfig.dinheiro += 25;
                string conteudo = $"dinheiro\n{GlobalConfig.dinheiro}";
                File.WriteAllText("dados.txt", conteudo);

                MessageBox.Show("Parabéns! Você ganhou o bônus do Viotti de 25 moedas!", "BÔNUS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                player.controls.stop();
                Close();
            }

            lblTempoRestante.Text = tempoRestante.ToString();
        }
    }
}
