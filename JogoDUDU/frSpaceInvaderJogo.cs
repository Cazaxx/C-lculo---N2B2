using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace JogoDUDU
{
    public partial class frSpaceInvaderJogo : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        static int vida = 1;
        static int inimigosDerrotados = 0;
        static int somaPontos = 0;
        static int velocidade = 8;
        static int queda = 20;

        public frSpaceInvaderJogo()
        {
            InitializeComponent();
            MessageBox.Show("OS ALIENÍGENAS ESTÃO INVADINDO!\n\nEXTERMINE TODOS ELES PARA SALVAR O PLANETA!");
            MessageBox.Show("Espaço - Atira\nSeta Esquerda - move para esquerda\nSeta Direita - move para a direita");
            MessageBox.Show("Ganho de Moedas: pontuação total divida por 10");
        }

        #region controles
        private void FormSpaceInvaderJogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnIniciar.Visible == false)
            {
                if (e.KeyCode == Keys.Space && imgProjetilPlayer.Visible == false)
                {
                    imgProjetilPlayer.Top = imgPlayerNave.Top - imgPlayerNave.Height + 39;
                    imgProjetilPlayer.Left = imgPlayerNave.Left - 10 + (imgPlayerNave.Width / 2);
                    imgProjetilPlayer.Visible = true;
                    timerTiroNavePlayer.Start();
                }

                if (e.KeyCode == Keys.Left)
                    imgPlayerNave.Left -= 10;
                else if (e.KeyCode == Keys.Right)
                    imgPlayerNave.Left += 10;

                if (e.KeyCode == Keys.Left && imgPlayerNave.Bounds.IntersectsWith(imgBorda1.Bounds))
                {
                    imgPlayerNave.Left += 10;
                }

                if (e.KeyCode == Keys.Right && imgPlayerNave.Bounds.IntersectsWith(imgBorda2.Bounds))
                {
                    imgPlayerNave.Left -= 10;
                }
            }
        }
        #endregion

        #region tiroPlayer
        private void timerTiroNavePlayer_Tick(object sender, EventArgs e)
        {
            imgProjetilPlayer.Top -= 40;
            if (imgProjetilPlayer.Top <= imgBorda.Top - 30)
            {
                ParaTimerPlayer();
            }

            AliensDerrotados();

            if (inimigosDerrotados == 40)
            {
                MessageBox.Show("PARABÉNS, VOCÊ VENCEU SALVOU A TERRA! SUA PONTUAÇÃO FOI: " + lblPontuacao.Text + " PONTOS!");
                Close();
            }
        }
        #endregion

        #region timerAlien
        private void TimerAlienInimigo_Tick(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "Inimigos")
                {
                    if (control.Bounds.IntersectsWith(imgBorda2.Bounds) && control.Visible || control.Bounds.IntersectsWith(imgBorda1.Bounds) && control.Visible)
                    {
                        AumentaVelocidade();
                        velocidade = -velocidade;
                        alienDescendo();
                        break;
                    }
                }
            }
            MovimentoAlien();
        }
        #endregion

        #region tiroPlayer
        private void ParaTimerPlayer()
        {
            timerTiroNavePlayer.Stop();
            imgProjetilPlayer.Visible = false;
        }
        #endregion

        #region movimentoAlien
        private void MovimentoAlien()
        {
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "Inimigos" && control.Visible)
                    control.Left += velocidade;
            }

            AlienAcertaBordaOuPlayer();

            if (vida == 0)
            {
                MessageBox.Show("A TERRA SERÁ DESTRUÍDA!\n\nVOCÊ FEZ: " + lblPontuacao.Text + " PONTOS!");
                Close();
            }

        }
        #endregion

        #region alienAlvejado
        private void AliensDerrotados()
        {
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "Inimigos")
                {
                    if (imgProjetilPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible)
                    {
                        control.Visible = false;
                        inimigosDerrotados++;
                        ParaTimerPlayer();
                        PontuacaoCastor1();
                        PontuacaoCastor2();
                        PontuacaoAndroid1();
                        PontuacaoAndroid2();
                        PontuacaoPolvo();
                        break;
                    }
                }
            }
        }
        #endregion

        #region descidaAlien
        private void alienDescendo()
        {
            imgAlienCastor1.Top += queda;
            imgAlienCastor2.Top += queda;
            imgAlienCastor3.Top += queda;
            imgAlienCastor4.Top += queda;
            imgAlienCastor5.Top += queda;
            imgAlienCastor6.Top += queda;
            imgAlienCastor7.Top += queda;
            imgAlienCastor8.Top += queda;
            imgAlienCastor9.Top += queda;
            imgAlienCastor10.Top += queda;
            imgAlienCastor11.Top += queda;
            imgAlienCastor12.Top += queda;
            imgAlienCastor13.Top += queda;
            imgAlienCastor14.Top += queda;
            imgAlienCastor15.Top += queda;
            imgAlienCastor16.Top += queda;
            imgAlienAndroid1.Top += queda;
            imgAlienAndroid2.Top += queda;
            imgAlienAndroid3.Top += queda;
            imgAlienAndroid4.Top += queda;
            imgAlienAndroid5.Top += queda;
            imgAlienAndroid6.Top += queda;
            imgAlienAndroid7.Top += queda;
            imgAlienAndroid8.Top += queda;
            imgAlienAndroid9.Top += queda;
            imgAlienAndroid10.Top += queda;
            imgAlienAndroid11.Top += queda;
            imgAlienAndroid12.Top += queda;
            imgAlienAndroid13.Top += queda;
            imgAlienAndroid14.Top += queda;
            imgAlienAndroid15.Top += queda;
            imgAlienAndroid16.Top += queda;
            imgAlienPolvo1.Top += queda;
            imgAlienPolvo2.Top += queda;
            imgAlienPolvo3.Top += queda;
            imgAlienPolvo4.Top += queda;
            imgAlienPolvo5.Top += queda;
            imgAlienPolvo6.Top += queda;
            imgAlienPolvo7.Top += queda;
            imgAlienPolvo8.Top += queda;
        }
        #endregion

        #region pontuacao
        private void PontuacaoCastor1()
        {
            if (imgAlienCastor1.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor2.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor3.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor4.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor5.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor6.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor7.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor8.Bounds.IntersectsWith(imgProjetilPlayer.Bounds))
            {
                somaPontos += 10;
                lblPontuacao.Text = "" + somaPontos;
            }
        }

        private void PontuacaoCastor2()
        {
            if (imgAlienCastor9.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor10.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor11.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor12.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor13.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor14.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor15.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienCastor16.Bounds.IntersectsWith(imgProjetilPlayer.Bounds))
            {
                somaPontos += 10;
                lblPontuacao.Text = "" + somaPontos;
            }
        }

        private void PontuacaoAndroid1()
        {
            if (imgAlienAndroid1.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid2.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid3.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid4.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid5.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid6.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid7.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid8.Bounds.IntersectsWith(imgProjetilPlayer.Bounds))
            {
                somaPontos += 20;
                lblPontuacao.Text = "" + somaPontos;
            }
        }

        private void PontuacaoAndroid2()
        {
            if (imgAlienAndroid9.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid10.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid11.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid12.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid13.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid14.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid15.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienAndroid16.Bounds.IntersectsWith(imgProjetilPlayer.Bounds))
            {
                somaPontos += 20;
                lblPontuacao.Text = "" + somaPontos;
            }
        }


        private void PontuacaoPolvo()
        {
            if (imgAlienPolvo1.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienPolvo2.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienPolvo3.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienPolvo4.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienPolvo5.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienPolvo6.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienPolvo7.Bounds.IntersectsWith(imgProjetilPlayer.Bounds) || imgAlienPolvo8.Bounds.IntersectsWith(imgProjetilPlayer.Bounds))
            {
                somaPontos += 30;
                lblPontuacao.Text = "" + somaPontos;
            }
        }
        #endregion

        #region velocidade
        private void AumentaVelocidade()
        {
            if (velocidade > 0)
                velocidade++;
            else
                velocidade--;
        }
        #endregion

        #region GameOver
        private void AlienAcertaBordaOuPlayer()
        {
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "Inimigos" && control.Bounds.IntersectsWith(imgPlayerNave.Bounds) && control.Visible || (string)control.Tag == "Inimigos" && control.Bounds.IntersectsWith(imgBordaInferior.Bounds) && control.Visible)
                {
                    vida -= 1;
                    lblGameOver.Visible = true;
                    timerAlienInimigo.Stop();
                    break;
                }
            }
        }
        #endregion

        #region btnIniciar
        public void BtnIniciar_Click(object sender, EventArgs e)
        {
            timerAlienInimigo.Start();
            if (!GlobalConfig.muteLigado)
                player.URL = "Corneria.mp3";
            player.controls.play();
            btnIniciar.Dispose();
        }
        #endregion

        #region paraMúsica
        private void frSpaceInvaderJogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.controls.stop();
        }
        #endregion
    }
}