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
    public partial class frRecordes : Form
    {
        public frRecordes()
        {
            InitializeComponent();            
        }

        private void btnFaseCidade_Click(object sender, EventArgs e)
        {            
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        List<string> cidade = new List<string>();
        List<string> deserto = new List<string>();
        List<string> floresta = new List<string>();

        private void frRecordes_Load(object sender, EventArgs e)
        {
            if (!File.Exists("recordes.txt"))
            {
                MessageBox.Show("O arquivo não existe!");
            }

            else
            {
                string[] recordes = File.ReadAllLines("recordes.txt");

                for (int x = 0; x < recordes.Length; x++)
                {
                    if (recordes[x] == "cidade")
                    {
                        Array.
                    }
                }
            }
        }
    }
}