namespace JogoDUDU
{
    partial class frLoja
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.picSkin = new System.Windows.Forms.PictureBox();
            this.btnBala = new System.Windows.Forms.Button();
            this.btnPersonagem = new System.Windows.Forms.Button();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lstSkins = new System.Windows.Forms.ListBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblPrecoSkin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::JogoDUDU.Properties.Resources.moeda;
            this.pictureBox1.Location = new System.Drawing.Point(476, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.BackColor = System.Drawing.Color.Transparent;
            this.lblDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.ForeColor = System.Drawing.Color.White;
            this.lblDinheiro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDinheiro.Location = new System.Drawing.Point(371, 23);
            this.lblDinheiro.MaximumSize = new System.Drawing.Size(100, 18);
            this.lblDinheiro.MinimumSize = new System.Drawing.Size(100, 18);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(100, 18);
            this.lblDinheiro.TabIndex = 1;
            this.lblDinheiro.Tag = "dinheiro";
            this.lblDinheiro.Text = "Dinheiro";
            this.lblDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picSkin
            // 
            this.picSkin.BackColor = System.Drawing.Color.Transparent;
            this.picSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSkin.Location = new System.Drawing.Point(35, 64);
            this.picSkin.Name = "picSkin";
            this.picSkin.Size = new System.Drawing.Size(92, 92);
            this.picSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSkin.TabIndex = 2;
            this.picSkin.TabStop = false;
            // 
            // btnBala
            // 
            this.btnBala.BackColor = System.Drawing.Color.Black;
            this.btnBala.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBala.ForeColor = System.Drawing.Color.White;
            this.btnBala.Location = new System.Drawing.Point(229, 14);
            this.btnBala.Margin = new System.Windows.Forms.Padding(2);
            this.btnBala.Name = "btnBala";
            this.btnBala.Size = new System.Drawing.Size(151, 34);
            this.btnBala.TabIndex = 11;
            this.btnBala.Text = "Balas";
            this.btnBala.UseVisualStyleBackColor = false;
            this.btnBala.Click += new System.EventHandler(this.btnBala_Click);
            // 
            // btnPersonagem
            // 
            this.btnPersonagem.BackColor = System.Drawing.Color.Black;
            this.btnPersonagem.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnPersonagem.ForeColor = System.Drawing.Color.White;
            this.btnPersonagem.Location = new System.Drawing.Point(35, 14);
            this.btnPersonagem.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonagem.Name = "btnPersonagem";
            this.btnPersonagem.Size = new System.Drawing.Size(151, 34);
            this.btnPersonagem.TabIndex = 13;
            this.btnPersonagem.Text = "Personagens";
            this.btnPersonagem.UseVisualStyleBackColor = false;
            this.btnPersonagem.Click += new System.EventHandler(this.btnPersonagem_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::JogoDUDU.Properties.Resources.moeda;
            this.pictureBox13.Location = new System.Drawing.Point(448, 94);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(24, 22);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 28;
            this.pictureBox13.TabStop = false;
            // 
            // lstSkins
            // 
            this.lstSkins.FormattingEnabled = true;
            this.lstSkins.Location = new System.Drawing.Point(142, 53);
            this.lstSkins.Name = "lstSkins";
            this.lstSkins.Size = new System.Drawing.Size(164, 121);
            this.lstSkins.TabIndex = 41;
            this.lstSkins.SelectedIndexChanged += new System.EventHandler(this.lstSkins_SelectedIndexChanged);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Black;
            this.btnComprar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(320, 118);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(2);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(151, 34);
            this.btnComprar.TabIndex = 42;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblPrecoSkin
            // 
            this.lblPrecoSkin.AutoSize = true;
            this.lblPrecoSkin.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecoSkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoSkin.ForeColor = System.Drawing.Color.White;
            this.lblPrecoSkin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrecoSkin.Location = new System.Drawing.Point(322, 96);
            this.lblPrecoSkin.MaximumSize = new System.Drawing.Size(120, 18);
            this.lblPrecoSkin.MinimumSize = new System.Drawing.Size(120, 18);
            this.lblPrecoSkin.Name = "lblPrecoSkin";
            this.lblPrecoSkin.Size = new System.Drawing.Size(120, 18);
            this.lblPrecoSkin.TabIndex = 43;
            this.lblPrecoSkin.Tag = "dinheiro";
            this.lblPrecoSkin.Text = "Dinheiro";
            this.lblPrecoSkin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDUDU.Properties.Resources.bgTelaLoja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 188);
            this.Controls.Add(this.lblPrecoSkin);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lstSkins);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.btnPersonagem);
            this.Controls.Add(this.btnBala);
            this.Controls.Add(this.picSkin);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja";
            this.Load += new System.EventHandler(this.frLoja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.PictureBox picSkin;
        private System.Windows.Forms.Button btnBala;
        private System.Windows.Forms.Button btnPersonagem;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.ListBox lstSkins;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblPrecoSkin;
    }
}