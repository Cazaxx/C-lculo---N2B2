using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JogoDUDU
{
    public partial class frAposta : Form
    {
        public frAposta()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ap1 = new Random();
            grpBeyBlade.Left -= (ap1.Next(0, 51) - ap1.Next(0, 11));
            grpMinotauro.Left -= (ap1.Next(0, 51) - ap1.Next(0, 11));
            grpDancante.Left -= (ap1.Next(0, 51) - ap1.Next(0, 11));

            if (grpBeyBlade.Bounds.IntersectsWith(label1.Bounds))
            {
                timer1.Enabled = false;
                VerificaGanhador(grpBeyBlade);
                PosicaoPadrao();
            }
            else if (grpMinotauro.Bounds.IntersectsWith(label1.Bounds))
            {
                timer1.Enabled = false;
                VerificaGanhador(grpMinotauro);
                PosicaoPadrao();
            }
            else if (grpDancante.Bounds.IntersectsWith(label1.Bounds))
            {
                timer1.Enabled = false;
                VerificaGanhador(grpDancante);
                PosicaoPadrao();
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            Aposta.apostou = false;
            frConfigAposta aposta = new frConfigAposta();
            aposta.ShowDialog();

            if (Aposta.apostou)
            {
                PosicaoPadrao();
                timer1.Enabled = true;
            }
        }

        public void PosicaoPadrao()
        {
            grpBeyBlade.Left = 1220;
            grpMinotauro.Left = 1220;
            grpDancante.Left = 1220;

            if (GlobalConfig.dinheiro <= 10)
            {
                MessageBox.Show("Você tem menos do que 10 reais! Ganhe mais para voltar aqui! ", "Dinheiro insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Close();
            }
        }

        public void VerificaGanhador(GroupBox aux)
        {
            if ((string)aux.Tag == Aposta.corredor)
            {
                GlobalConfig.dinheiro += Aposta.valor;
                string conteudo = $"dinheiro\n{GlobalConfig.dinheiro}";
                File.WriteAllText("dados.txt", conteudo);
                MessageBox.Show($"Parabéns! Você ganhou {Aposta.valor} moeda(s)! ", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GlobalConfig.dinheiro -= Aposta.valor;
                string conteudo = $"dinheiro\n{GlobalConfig.dinheiro}";
                File.WriteAllText("dados.txt", conteudo);
                MessageBox.Show($"Condolências! Você perdeu {Aposta.valor} moeda(s)! ", "Você perdeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
