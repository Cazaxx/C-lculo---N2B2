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
    public partial class frConfigAposta : Form
    {
        public frConfigAposta()
        {
            InitializeComponent();
            lblDinheiro.Text = "Seu dinheiro: " + GlobalConfig.dinheiro;
            rbtBeyBlade.Checked = true;
        }

        private void frAposta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            Aposta.apostou = false;
            if (int.TryParse(txtAposta.Text, out Aposta.valor))
            {
                if (Aposta.valor <= GlobalConfig.dinheiro && Aposta.valor > 0)
                {
                    Aposta.apostou = true;
                    DevolveEscolhaCorredor();
                    MessageBox.Show("Apostado com sucesso! Clique em OK para começar a corrida", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Close();
                }
                else
                {
                    MessageBox.Show("Você não possui dinheiro suficiente! ", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Digite um valor de aposta válido! ", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        public void DevolveEscolhaCorredor()
        {
            if (rbtBeyBlade.Checked)
                Aposta.corredor = "beyblade";
            if (rbtDancante.Checked)
                Aposta.corredor = "dancante";
            if (rbtMinotauro.Checked)
                Aposta.corredor = "minotauro";
        }
    }
}
