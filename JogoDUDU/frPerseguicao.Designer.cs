namespace JogoDUDU
{
    partial class frPerseguicao
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
            this.components = new System.ComponentModel.Container();
            this.tmrMovimento = new System.Windows.Forms.Timer(this.components);
            this.Verifica = new System.Windows.Forms.Timer(this.components);
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picInimigo = new System.Windows.Forms.PictureBox();
            this.picJogador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMovimento
            // 
            this.tmrMovimento.Interval = 50;
            this.tmrMovimento.Tick += new System.EventHandler(this.tmrMovimento_Tick);
            // 
            // Verifica
            // 
            this.Verifica.Interval = 1000;
            this.Verifica.Tick += new System.EventHandler(this.Verifica_Tick);
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.AutoSize = true;
            this.lblTempoRestante.BackColor = System.Drawing.Color.Red;
            this.lblTempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRestante.ForeColor = System.Drawing.Color.White;
            this.lblTempoRestante.Location = new System.Drawing.Point(956, 583);
            this.lblTempoRestante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(96, 29);
            this.lblTempoRestante.TabIndex = 6;
            this.lblTempoRestante.Text = "Tempo";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(-31, 599);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1163, 75);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-31, -58);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1183, 74);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(1021, -33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 708);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-115, -33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 708);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // picInimigo
            // 
            this.picInimigo.BackgroundImage = global::JogoDUDU.Properties.Resources.Viotti1;
            this.picInimigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInimigo.Location = new System.Drawing.Point(627, 254);
            this.picInimigo.Margin = new System.Windows.Forms.Padding(4);
            this.picInimigo.Name = "picInimigo";
            this.picInimigo.Size = new System.Drawing.Size(67, 62);
            this.picInimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInimigo.TabIndex = 1;
            this.picInimigo.TabStop = false;
            // 
            // picJogador
            // 
            this.picJogador.BackgroundImage = global::JogoDUDU.Properties.Resources.eduardo;
            this.picJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJogador.Location = new System.Drawing.Point(396, 254);
            this.picJogador.Margin = new System.Windows.Forms.Padding(4);
            this.picJogador.Name = "picJogador";
            this.picJogador.Size = new System.Drawing.Size(67, 62);
            this.picJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador.TabIndex = 0;
            this.picJogador.TabStop = false;
            // 
            // frPerseguicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1045, 617);
            this.ControlBox = false;
            this.Controls.Add(this.lblTempoRestante);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picInimigo);
            this.Controls.Add(this.picJogador);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frPerseguicao";
            this.Text = "FUJA DO VIOTTI!!!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picJogador;
        private System.Windows.Forms.PictureBox picInimigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer tmrMovimento;
        private System.Windows.Forms.Timer Verifica;
        private System.Windows.Forms.Label lblTempoRestante;
    }
}

