using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JogoDUDU
{
    public partial class frLoja : Form
    {
        string[] skinsPersonagem;
        string[] skinsBala;
        Dictionary<string, int> skins = new Dictionary<string, int>();
        public frLoja()
        {
            InitializeComponent();
        }

        public void CapturaSkinsDisponiveis(string arquivoReduzido, string[] skinsGeral)
        {
            try
            {
                lstSkins.Items.Clear();
                skins.Clear();
                string[] skinsQuePossui = File.ReadAllLines(arquivoReduzido);
                for (int i = 0; i < skinsGeral.Length; i++)
                {
                    for (int j = 0; j < skinsQuePossui.Length; j++)
                    {
                        if (skinsGeral[i].Split(';')[0] == skinsQuePossui[j])
                        {
                            break;
                        }
                        if (j == skinsQuePossui.Length - 1)
                        {
                            lstSkins.Items.Add(skinsGeral[i].Split(';')[0]);
                            skins.Add(skinsGeral[i].Split(';')[0], int.Parse(skinsGeral[i].Split(';')[1]));
                        }
                    }
                }
                lstSkins.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Você possui um arquivo corrompido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public string[] LeArquivoTexto(string arquivo)
        {
            if (File.Exists(arquivo))
            {
                return File.ReadAllLines(arquivo);
            }

            return null;

        }

        public void PadraoInicializacao()
        {
            btnPersonagem.BackColor = Color.DarkRed;
            CapturaSkinsDisponiveis("skinPersonagens.txt", skinsPersonagem);
        }

        public void PersonagemEscolhido()
        {
            btnBala.BackColor = Color.Black;
            btnPersonagem.BackColor = Color.DarkRed;
        }

        public void BalaEscolhida()
        {
            btnBala.BackColor = Color.DarkRed;
            btnPersonagem.BackColor = Color.Black;
        }

        private void frLoja_Load(object sender, EventArgs e)
        {

            string[] auxPersonagem = LeArquivoTexto("todasSkinsPersonagens.txt");
            string[] auxBala = LeArquivoTexto("todasSkinsBalas.txt");

            if (auxPersonagem == null || auxBala == null)
            {
                MessageBox.Show("Você possui um arquivo corrompido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                skinsBala = auxBala;
                skinsPersonagem = auxPersonagem;
            }

            btnPersonagem.PerformClick();
            lblDinheiro.Text = GlobalConfig.dinheiro.ToString();
            PadraoInicializacao();
        }

        private void btnPersonagem_Click(object sender, EventArgs e)
        {
            if (btnBala.BackColor == Color.DarkRed)
            {
                PersonagemEscolhido();
                CapturaSkinsDisponiveis("skinPersonagens.txt", skinsPersonagem);
            }

        }

        private void btnBala_Click(object sender, EventArgs e)
        {
            if (btnPersonagem.BackColor == Color.DarkRed)
            {
                BalaEscolhida();
                CapturaSkinsDisponiveis("skinBalas.txt", skinsBala);
            }
        }

        private void lstSkins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSkins.SelectedIndex != -1)
            {
                try
                {
                    if (btnPersonagem.BackColor == Color.DarkRed && lstSkins.Text != "")
                    {
                        picSkin.Size = new Size(92, 92);
                        picSkin.BackgroundImage = Image.FromFile(lstSkins.Text + "Baixo.png");
                    }
                    else if (lstSkins.Text != "")
                    {
                        picSkin.Size = new Size(92, 46);
                        picSkin.BackgroundImage = Image.FromFile(lstSkins.Text + "Direita.png");
                    }

                    lblPrecoSkin.Text = "Preço: " + (skins[lstSkins.Text]).ToString();
                }
                catch
                {
                    lstSkins.Items.Remove(lstSkins.SelectedItem);
                    MessageBox.Show("Não foi possível achar essa skin! ", "Skin Inválida", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalConfig.dinheiro >= skins[lstSkins.Text])
                {
                    DialogResult resultado = MessageBox.Show("Deseja realmente comprar? ", "Comprar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (btnBala.BackColor == Color.DarkRed) File.AppendAllText("skinBalas.txt", "\n" + lstSkins.Text);
                        else File.AppendAllText("skinPersonagens.txt", "\n" + lstSkins.Text);

                        GlobalConfig.dinheiro -= skins[lstSkins.Text];
                        File.WriteAllText("dados.txt", $"dinheiro\n{GlobalConfig.dinheiro}");
                        lblDinheiro.Text = GlobalConfig.dinheiro.ToString();
                        skins.Remove(lstSkins.Text);
                        lstSkins.Items.Remove(lstSkins.SelectedItem);

                        MessageBox.Show("Personagem comprado com sucesso! Usufrua com moderação ;)", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (lstSkins.Items.Count > 0)
                            lstSkins.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Dinheiro Insuficiente! ", "Dinheiro Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Falha ao comprar skin! Tente novamente mais tarde! ", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
}   }
