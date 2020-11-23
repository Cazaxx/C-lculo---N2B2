namespace JogoDUDU
{
    partial class frConfigAposta
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
            this.txtAposta = new System.Windows.Forms.TextBox();
            this.lblAposta = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtDancante = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtMinotauro = new System.Windows.Forms.RadioButton();
            this.rbtBeyBlade = new System.Windows.Forms.RadioButton();
            this.btnApostar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAposta
            // 
            this.txtAposta.Location = new System.Drawing.Point(144, 33);
            this.txtAposta.Name = "txtAposta";
            this.txtAposta.Size = new System.Drawing.Size(166, 20);
            this.txtAposta.TabIndex = 0;
            // 
            // lblAposta
            // 
            this.lblAposta.AutoSize = true;
            this.lblAposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAposta.Location = new System.Drawing.Point(34, 33);
            this.lblAposta.Name = "lblAposta";
            this.lblAposta.Size = new System.Drawing.Size(61, 16);
            this.lblAposta.TabIndex = 1;
            this.lblAposta.Text = "Aposta:";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.BackColor = System.Drawing.Color.Green;
            this.lblDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDinheiro.Location = new System.Drawing.Point(34, 9);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(99, 16);
            this.lblDinheiro.TabIndex = 2;
            this.lblDinheiro.Text = "Seu dinheiro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chance de multiplicar dinheiro";
            // 
            // rbtDancante
            // 
            this.rbtDancante.AutoSize = true;
            this.rbtDancante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDancante.Location = new System.Drawing.Point(37, 94);
            this.rbtDancante.Name = "rbtDancante";
            this.rbtDancante.Size = new System.Drawing.Size(89, 20);
            this.rbtDancante.TabIndex = 4;
            this.rbtDancante.TabStop = true;
            this.rbtDancante.Tag = "dancando";
            this.rbtDancante.Text = "Dançando";
            this.rbtDancante.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sua aposta:";
            // 
            // rbtMinotauro
            // 
            this.rbtMinotauro.AutoSize = true;
            this.rbtMinotauro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMinotauro.Location = new System.Drawing.Point(144, 94);
            this.rbtMinotauro.Name = "rbtMinotauro";
            this.rbtMinotauro.Size = new System.Drawing.Size(85, 20);
            this.rbtMinotauro.TabIndex = 6;
            this.rbtMinotauro.TabStop = true;
            this.rbtMinotauro.Tag = "minotauro";
            this.rbtMinotauro.Text = "Minotauro";
            this.rbtMinotauro.UseVisualStyleBackColor = true;
            // 
            // rbtBeyBlade
            // 
            this.rbtBeyBlade.AutoSize = true;
            this.rbtBeyBlade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBeyBlade.Location = new System.Drawing.Point(251, 94);
            this.rbtBeyBlade.Name = "rbtBeyBlade";
            this.rbtBeyBlade.Size = new System.Drawing.Size(85, 20);
            this.rbtBeyBlade.TabIndex = 7;
            this.rbtBeyBlade.TabStop = true;
            this.rbtBeyBlade.Tag = "beyblade";
            this.rbtBeyBlade.Text = "Beyblade";
            this.rbtBeyBlade.UseVisualStyleBackColor = true;
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(257, 122);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(92, 35);
            this.btnApostar.TabIndex = 8;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // frConfigAposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 171);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.rbtBeyBlade);
            this.Controls.Add(this.rbtMinotauro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtDancante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.lblAposta);
            this.Controls.Add(this.txtAposta);
            this.Name = "frConfigAposta";
            this.Text = "frAposta";
            this.Load += new System.EventHandler(this.frAposta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAposta;
        private System.Windows.Forms.Label lblAposta;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtDancante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtMinotauro;
        private System.Windows.Forms.RadioButton rbtBeyBlade;
        private System.Windows.Forms.Button btnApostar;
    }
}