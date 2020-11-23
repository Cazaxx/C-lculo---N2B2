namespace JogoDUDU
{
    partial class frTelaTitulo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfigs = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.picAjuda = new System.Windows.Forms.PictureBox();
            this.picLoja = new System.Windows.Forms.PictureBox();
            this.ttTelaTitulo = new System.Windows.Forms.ToolTip(this.components);
            this.picLeaderboard = new System.Windows.Forms.PictureBox();
            this.btnApostas = new System.Windows.Forms.Button();
            this.btnJogoNave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(205, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jogar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::JogoDUDU.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(9, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 102);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfigs
            // 
            this.btnConfigs.BackColor = System.Drawing.Color.Black;
            this.btnConfigs.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnConfigs.ForeColor = System.Drawing.Color.Gold;
            this.btnConfigs.Location = new System.Drawing.Point(205, 198);
            this.btnConfigs.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigs.Name = "btnConfigs";
            this.btnConfigs.Size = new System.Drawing.Size(204, 44);
            this.btnConfigs.TabIndex = 2;
            this.btnConfigs.Text = "Configurações";
            this.btnConfigs.UseVisualStyleBackColor = false;
            this.btnConfigs.Click += new System.EventHandler(this.btnConfigs_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.Gold;
            this.btnSair.Location = new System.Drawing.Point(205, 262);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(204, 44);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picAjuda
            // 
            this.picAjuda.BackColor = System.Drawing.Color.Transparent;
            this.picAjuda.BackgroundImage = global::JogoDUDU.Properties.Resources.icnAjuda;
            this.picAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAjuda.Location = new System.Drawing.Point(40, 287);
            this.picAjuda.Margin = new System.Windows.Forms.Padding(2);
            this.picAjuda.Name = "picAjuda";
            this.picAjuda.Size = new System.Drawing.Size(48, 52);
            this.picAjuda.TabIndex = 4;
            this.picAjuda.TabStop = false;
            this.ttTelaTitulo.SetToolTip(this.picAjuda, "Ajuda");
            this.picAjuda.Click += new System.EventHandler(this.picAjuda_Click);
            // 
            // picLoja
            // 
            this.picLoja.BackColor = System.Drawing.Color.Transparent;
            this.picLoja.BackgroundImage = global::JogoDUDU.Properties.Resources.icnShop;
            this.picLoja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoja.Location = new System.Drawing.Point(525, 287);
            this.picLoja.Margin = new System.Windows.Forms.Padding(2);
            this.picLoja.Name = "picLoja";
            this.picLoja.Size = new System.Drawing.Size(48, 52);
            this.picLoja.TabIndex = 5;
            this.picLoja.TabStop = false;
            this.ttTelaTitulo.SetToolTip(this.picLoja, "Loja");
            this.picLoja.Click += new System.EventHandler(this.picLoja_Click);
            // 
            // picLeaderboard
            // 
            this.picLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.picLeaderboard.BackgroundImage = global::JogoDUDU.Properties.Resources.Trophy;
            this.picLeaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLeaderboard.Location = new System.Drawing.Point(525, 198);
            this.picLeaderboard.Margin = new System.Windows.Forms.Padding(2);
            this.picLeaderboard.Name = "picLeaderboard";
            this.picLeaderboard.Size = new System.Drawing.Size(48, 52);
            this.picLeaderboard.TabIndex = 8;
            this.picLeaderboard.TabStop = false;
            this.ttTelaTitulo.SetToolTip(this.picLeaderboard, "Loja");
            this.picLeaderboard.Click += new System.EventHandler(this.picLeaderboard_Click);
            // 
            // btnApostas
            // 
            this.btnApostas.BackColor = System.Drawing.Color.Black;
            this.btnApostas.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnApostas.ForeColor = System.Drawing.Color.Gold;
            this.btnApostas.Location = new System.Drawing.Point(11, 138);
            this.btnApostas.Margin = new System.Windows.Forms.Padding(2);
            this.btnApostas.Name = "btnApostas";
            this.btnApostas.Size = new System.Drawing.Size(161, 44);
            this.btnApostas.TabIndex = 6;
            this.btnApostas.Text = "Apostas";
            this.btnApostas.UseVisualStyleBackColor = false;
            this.btnApostas.Click += new System.EventHandler(this.btnApostas_Click);
            // 
            // btnJogoNave
            // 
            this.btnJogoNave.BackColor = System.Drawing.Color.Black;
            this.btnJogoNave.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnJogoNave.ForeColor = System.Drawing.Color.Gold;
            this.btnJogoNave.Location = new System.Drawing.Point(430, 138);
            this.btnJogoNave.Margin = new System.Windows.Forms.Padding(2);
            this.btnJogoNave.Name = "btnJogoNave";
            this.btnJogoNave.Size = new System.Drawing.Size(161, 44);
            this.btnJogoNave.TabIndex = 7;
            this.btnJogoNave.Text = "MiniGame";
            this.btnJogoNave.UseVisualStyleBackColor = false;
            this.btnJogoNave.Click += new System.EventHandler(this.btnJogoNave_Click);
            // 
            // frTelaTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDUDU.Properties.Resources.bgTelaTítulo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.picLeaderboard);
            this.Controls.Add(this.btnJogoNave);
            this.Controls.Add(this.btnApostas);
            this.Controls.Add(this.picLoja);
            this.Controls.Add(this.picAjuda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfigs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frTelaTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTT Slug";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeaderboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfigs;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picAjuda;
        private System.Windows.Forms.PictureBox picLoja;
        private System.Windows.Forms.ToolTip ttTelaTitulo;
        private System.Windows.Forms.Button btnApostas;
        private System.Windows.Forms.Button btnJogoNave;
        private System.Windows.Forms.PictureBox picLeaderboard;
    }
}

