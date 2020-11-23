using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDUDU
{
    public partial class frSalvaRecorde : Form
    {
        public frSalvaRecorde()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite o seu nome!");
                return;
            }

            else
            {
                string conteudo = GlobalConfig.mapa + "|" + txtNome.Text + "|" + frJogoPrincipal.tempoTotal + "|" + GlobalConfig.dificuldade;                      

                if (!File.Exists("recordes.txt"))
                {
                    File.WriteAllText("recordes.txt", conteudo);
                }

                else
                {
                    File.AppendAllText("recordes.txt", conteudo);
                }
            }
        }
    }
}