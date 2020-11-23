namespace JogoDUDU
{
    partial class frRecordes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstRecordes = new System.Windows.Forms.ListBox();
            this.btnFaseCidade = new System.Windows.Forms.Button();
            this.btnDeserto = new System.Windows.Forms.Button();
            this.btnFloresta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRecordes
            // 
            this.lstRecordes.BackColor = System.Drawing.Color.Bisque;
            this.lstRecordes.FormattingEnabled = true;
            this.lstRecordes.Location = new System.Drawing.Point(12, 12);
            this.lstRecordes.Name = "lstRecordes";
            this.lstRecordes.Size = new System.Drawing.Size(815, 381);
            this.lstRecordes.TabIndex = 0;
            // 
            // btnFaseCidade
            // 
            this.btnFaseCidade.BackColor = System.Drawing.Color.Black;
            this.btnFaseCidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFaseCidade.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnFaseCidade.ForeColor = System.Drawing.Color.Orange;
            this.btnFaseCidade.Location = new System.Drawing.Point(12, 398);
            this.btnFaseCidade.Margin = new System.Windows.Forms.Padding(2);
            this.btnFaseCidade.Name = "btnFaseCidade";
            this.btnFaseCidade.Size = new System.Drawing.Size(126, 44);
            this.btnFaseCidade.TabIndex = 1;
            this.btnFaseCidade.Text = "Cidade";
            this.btnFaseCidade.UseVisualStyleBackColor = false;
            this.btnFaseCidade.Click += new System.EventHandler(this.btnFaseCidade_Click);
            // 
            // btnDeserto
            // 
            this.btnDeserto.BackColor = System.Drawing.Color.Black;
            this.btnDeserto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeserto.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDeserto.ForeColor = System.Drawing.Color.Orange;
            this.btnDeserto.Location = new System.Drawing.Point(220, 398);
            this.btnDeserto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeserto.Name = "btnDeserto";
            this.btnDeserto.Size = new System.Drawing.Size(126, 44);
            this.btnDeserto.TabIndex = 2;
            this.btnDeserto.Text = "Deserto";
            this.btnDeserto.UseVisualStyleBackColor = false;
            // 
            // btnFloresta
            // 
            this.btnFloresta.BackColor = System.Drawing.Color.Black;
            this.btnFloresta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFloresta.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnFloresta.ForeColor = System.Drawing.Color.Orange;
            this.btnFloresta.Location = new System.Drawing.Point(450, 398);
            this.btnFloresta.Margin = new System.Windows.Forms.Padding(2);
            this.btnFloresta.Name = "btnFloresta";
            this.btnFloresta.Size = new System.Drawing.Size(126, 44);
            this.btnFloresta.TabIndex = 3;
            this.btnFloresta.Text = "Floresta";
            this.btnFloresta.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.Orange;
            this.btnSair.Location = new System.Drawing.Point(751, 398);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 44);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frRecordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFloresta);
            this.Controls.Add(this.btnDeserto);
            this.Controls.Add(this.btnFaseCidade);
            this.Controls.Add(this.lstRecordes);
            this.Name = "frRecordes";
            this.Text = "frRecordes";
            this.Load += new System.EventHandler(this.frRecordes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecordes;
        private System.Windows.Forms.Button btnFaseCidade;
        private System.Windows.Forms.Button btnDeserto;
        private System.Windows.Forms.Button btnFloresta;
        private System.Windows.Forms.Button btnSair;
    }
}