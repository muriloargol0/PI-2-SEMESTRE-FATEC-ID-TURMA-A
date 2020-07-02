namespace ControleDoações
{
    partial class Movimentações
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
            this.movLb = new System.Windows.Forms.Label();
            this.saidaBt = new System.Windows.Forms.Button();
            this.entradaBt = new System.Windows.Forms.Button();
            this.voltarMovBt = new System.Windows.Forms.Button();
            this.saldoLb = new System.Windows.Forms.Label();
            this.dinheiroLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movLb
            // 
            this.movLb.AutoSize = true;
            this.movLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.movLb.Location = new System.Drawing.Point(250, 76);
            this.movLb.Name = "movLb";
            this.movLb.Size = new System.Drawing.Size(300, 46);
            this.movLb.TabIndex = 9;
            this.movLb.Text = "Movimentações";
            // 
            // saidaBt
            // 
            this.saidaBt.Location = new System.Drawing.Point(407, 280);
            this.saidaBt.Name = "saidaBt";
            this.saidaBt.Size = new System.Drawing.Size(133, 39);
            this.saidaBt.TabIndex = 8;
            this.saidaBt.Text = "Saída de dinheiro";
            this.saidaBt.UseVisualStyleBackColor = true;
            this.saidaBt.Click += new System.EventHandler(this.saidaBt_Click);
            // 
            // entradaBt
            // 
            this.entradaBt.Location = new System.Drawing.Point(257, 280);
            this.entradaBt.Name = "entradaBt";
            this.entradaBt.Size = new System.Drawing.Size(133, 39);
            this.entradaBt.TabIndex = 7;
            this.entradaBt.Text = "Entrada de dinheiro";
            this.entradaBt.UseVisualStyleBackColor = true;
            this.entradaBt.Click += new System.EventHandler(this.entradaBt_Click);
            // 
            // voltarMovBt
            // 
            this.voltarMovBt.Location = new System.Drawing.Point(12, 12);
            this.voltarMovBt.Name = "voltarMovBt";
            this.voltarMovBt.Size = new System.Drawing.Size(75, 23);
            this.voltarMovBt.TabIndex = 5;
            this.voltarMovBt.Text = "Voltar";
            this.voltarMovBt.UseVisualStyleBackColor = true;
            this.voltarMovBt.Click += new System.EventHandler(this.voltarMovBt_Click);
            // 
            // saldoLb
            // 
            this.saldoLb.AutoSize = true;
            this.saldoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoLb.Location = new System.Drawing.Point(310, 192);
            this.saldoLb.Name = "saldoLb";
            this.saldoLb.Size = new System.Drawing.Size(69, 25);
            this.saldoLb.TabIndex = 10;
            this.saldoLb.Text = "Saldo:";
            // 
            // dinheiroLb
            // 
            this.dinheiroLb.AutoSize = true;
            this.dinheiroLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinheiroLb.Location = new System.Drawing.Point(386, 192);
            this.dinheiroLb.Name = "dinheiroLb";
            this.dinheiroLb.Size = new System.Drawing.Size(79, 25);
            this.dinheiroLb.TabIndex = 11;
            this.dinheiroLb.Text = "R$ 0,00";
            // 
            // Movimentações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dinheiroLb);
            this.Controls.Add(this.saldoLb);
            this.Controls.Add(this.movLb);
            this.Controls.Add(this.saidaBt);
            this.Controls.Add(this.entradaBt);
            this.Controls.Add(this.voltarMovBt);
            this.Name = "Movimentações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movLb;
        private System.Windows.Forms.Button saidaBt;
        private System.Windows.Forms.Button entradaBt;
        private System.Windows.Forms.Button voltarMovBt;
        private System.Windows.Forms.Label saldoLb;
        private System.Windows.Forms.Label dinheiroLb;
    }
}