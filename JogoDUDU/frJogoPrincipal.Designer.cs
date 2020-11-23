namespace JogoDUDU
{
    partial class frJogoPrincipal
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
            this.lblQntBalas = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.picPorta = new System.Windows.Forms.PictureBox();
            this.picJogador = new System.Windows.Forms.PictureBox();
            this.picMapa = new System.Windows.Forms.PictureBox();
            this.picArea = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerTempoTotal = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQntBalas
            // 
            this.lblQntBalas.AutoSize = true;
            this.lblQntBalas.BackColor = System.Drawing.Color.Transparent;
            this.lblQntBalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntBalas.Location = new System.Drawing.Point(706, 485);
            this.lblQntBalas.Name = "lblQntBalas";
            this.lblQntBalas.Size = new System.Drawing.Size(75, 16);
            this.lblQntBalas.TabIndex = 135;
            this.lblQntBalas.Text = "QntBalas:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(629, 485);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 16);
            this.lblScore.TabIndex = 136;
            this.lblScore.Text = "Score:";
            // 
            // picPorta
            // 
            this.picPorta.BackColor = System.Drawing.Color.Red;
            this.picPorta.Location = new System.Drawing.Point(0, 0);
            this.picPorta.Name = "picPorta";
            this.picPorta.Size = new System.Drawing.Size(10, 46);
            this.picPorta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPorta.TabIndex = 134;
            this.picPorta.TabStop = false;
            this.picPorta.Tag = "";
            // 
            // picJogador
            // 
            this.picJogador.BackColor = System.Drawing.Color.Transparent;
            this.picJogador.Location = new System.Drawing.Point(30, 52);
            this.picJogador.Name = "picJogador";
            this.picJogador.Size = new System.Drawing.Size(24, 24);
            this.picJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJogador.TabIndex = 28;
            this.picJogador.TabStop = false;
            this.picJogador.Tag = "";
            // 
            // picMapa
            // 
            this.picMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMapa.Location = new System.Drawing.Point(0, 0);
            this.picMapa.Name = "picMapa";
            this.picMapa.Size = new System.Drawing.Size(784, 500);
            this.picMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMapa.TabIndex = 0;
            this.picMapa.TabStop = false;
            // 
            // picArea
            // 
            this.picArea.Location = new System.Drawing.Point(-44, -30);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(192, 192);
            this.picArea.TabIndex = 119;
            this.picArea.TabStop = false;
            this.picArea.Tag = "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblTempo.Location = new System.Drawing.Point(679, 9);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(15, 15);
            this.lblTempo.TabIndex = 137;
            this.lblTempo.Text = "0";
            this.lblTempo.Click += new System.EventHandler(this.lblTempo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(612, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 138;
            this.label2.Text = "Tempo:";
            // 
            // timerTempoTotal
            // 
            this.timerTempoTotal.Tick += new System.EventHandler(this.timerTempoTotal_Tick);
            // 
            // frJogoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblQntBalas);
            this.Controls.Add(this.picPorta);
            this.Controls.Add(this.picJogador);
            this.Controls.Add(this.picMapa);
            this.Controls.Add(this.picArea);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 539);
            this.MinimumSize = new System.Drawing.Size(800, 539);
            this.Name = "frJogoPrincipal";
            this.Text = "FTT Slug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.picPorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picPorta;
        private System.Windows.Forms.PictureBox picArea;
        private System.Windows.Forms.PictureBox picJogador;
        private System.Windows.Forms.PictureBox picMapa;
        private System.Windows.Forms.Label lblQntBalas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerTempoTotal;
    }
}

