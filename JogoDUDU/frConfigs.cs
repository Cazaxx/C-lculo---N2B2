using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace JogoDUDU
{
    public partial class frConfigs : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        Loja loja = new Loja();
        public frConfigs()
        {
            InitializeComponent();
            loja = new Loja();
            PadraoConfig();
        }

        public void PadraoConfig()
        {
            if (GlobalConfig.dificuldade == "facil")
                btnFacil.BackColor = Color.Green;
            else if (GlobalConfig.dificuldade == "medio")
                btnMedio.BackColor = Color.Green;
            else
                btnDificil.BackColor = Color.Green;

            if (GlobalConfig.mapa == "deserto")
                picFundoDeserto.Visible = true;
            else if (GlobalConfig.mapa == "cidade")
                picFundoCidade.Visible = true;
            else
                picFundoFloresta.Visible = true;

            cboSkinBala.Items.AddRange(loja.RetornaSkinsPossuidas("skinBalas.txt", "machado\nmachado2"));
            cboSkinJogador.Items.AddRange(loja.RetornaSkinsPossuidas("skinPersonagens.txt", "loki\ndarthVader"));
            cboSkinInimigo.Items.AddRange(loja.RetornaSkinsPossuidas("skinPersonagens.txt", "loki\ndarthVader"));
            cboMusicas.Items.Add("Low Rider");
            cboMusicas.Items.Add("Welcome to the Jungle");
            cboMusicas.Items.Add("Corneria");
            cboMusicas.Items.Add("Pumped Up Kicks");
            cboMusicas.Items.Add("Tema do Metal Slug");

            cboSkinBala.Text = DadosSkin.chaveBala;
            cboSkinJogador.Text = DadosSkin.chaveJogador;
            cboSkinInimigo.Text = DadosSkin.chaveInimigo;

            MudaPictureBox(picEscolhaJogador, cboSkinJogador.Text, "Baixo");
            MudaPictureBox(picEscolhaInimigo, cboSkinInimigo.Text, "Baixo");
            MudaPictureBox(picEscolhaBala, cboSkinBala.Text, "Direita");

            if (GlobalConfig.muteLigado)
            {
                btnSom.BackgroundImage = Properties.Resources.semsom;
            }

            else
            {
                btnSom.BackgroundImage = Properties.Resources.som;
            }
        }

        public void MudaPictureBox(PictureBox pic, string skin, string lado)
        {
            try
            {
                pic.Image = Image.FromFile(skin + lado + ".png");
            }
            catch
            {
                MessageBox.Show("Erro achar imagem! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            btnDificil.BackColor = Color.Black;
            btnMedio.BackColor = Color.Black;
            btnFacil.BackColor = Color.Green;
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            btnDificil.BackColor = Color.Black;
            btnMedio.BackColor = Color.Green;
            btnFacil.BackColor = Color.Black;
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            btnDificil.BackColor = Color.Green;
            btnMedio.BackColor = Color.Black;
            btnFacil.BackColor = Color.Black;
        }

        private void picMapaCidade_Click(object sender, EventArgs e)
        {
            picFundoFloresta.Visible = false;
            picFundoCidade.Visible = true;
            picFundoDeserto.Visible = false;
        }

        private void picMapaDeserto_Click(object sender, EventArgs e)
        {
            picFundoFloresta.Visible = false;
            picFundoCidade.Visible = false;
            picFundoDeserto.Visible = true;
        }

        private void picMapaFloresta_Click(object sender, EventArgs e)
        {
            picFundoFloresta.Visible = true;
            picFundoCidade.Visible = false;
            picFundoDeserto.Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (picFundoCidade.Visible)
                GlobalConfig.mapa = "cidade";
            else if (picFundoDeserto.Visible)
                GlobalConfig.mapa = "deserto";
            else
                GlobalConfig.mapa = "floresta";

            if (btnFacil.BackColor == Color.Green)
                GlobalConfig.dificuldade = "facil";
            else if (btnMedio.BackColor == Color.Green)
                GlobalConfig.dificuldade = "medio";
            else
                GlobalConfig.dificuldade = "dificil";

            DadosSkin.chaveInimigo = cboSkinInimigo.Text;
            DadosSkin.chaveJogador = cboSkinJogador.Text;
            DadosSkin.chaveBala = cboSkinBala.Text;

            player.controls.stop();
            Close();
        }

        private void cboSkinBala_SelectedIndexChanged(object sender, EventArgs e)
        {
            MudaPictureBox(picEscolhaBala, cboSkinBala.Text, "Direita");
        }

        private void cboSkinInimigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MudaPictureBox(picEscolhaInimigo, cboSkinInimigo.Text, "Baixo");
        }

        private void cboSkinJogador_SelectedIndexChanged(object sender, EventArgs e)
        {
            MudaPictureBox(picEscolhaJogador, cboSkinJogador.Text, "Baixo");
        }

        private void btnSom_Click(object sender, EventArgs e)
        {
            if (GlobalConfig.muteLigado)
            {
                GlobalConfig.muteLigado = false;
                btnSom.BackgroundImage = Properties.Resources.som;
                cboMusicas.Enabled = true;
                player.controls.play();
            }
            else
            {
                GlobalConfig.muteLigado = true;
                btnSom.BackgroundImage = Properties.Resources.semsom;
                cboMusicas.Enabled = false;
                player.controls.pause();
            }
        }

        private void cboMusicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMusicas.SelectedIndex == 0)
            {
                player.controls.stop();
                player.URL = "WarLowRider.mp3";
                player.controls.play();
            }

            else if (cboMusicas.SelectedIndex == 1)
            {
                player.controls.stop();
                player.URL = "WelcomeToTheJungle.mp3";
                player.controls.play();
            }

            else if (cboMusicas.SelectedIndex == 2)
            {
                player.controls.stop();
                player.URL = "Corneria.mp3";
                player.controls.play();
            }

            else if (cboMusicas.SelectedIndex == 3)
            {
                player.controls.stop();
                player.URL = "PumpedUpKicks.mp3";
                player.controls.play();
            }

            else if (cboMusicas.SelectedIndex == 4)
            {
                player.controls.stop();
                player.URL = "MetalSlug.mp3";
                player.controls.play();
            }
        }
    }
}