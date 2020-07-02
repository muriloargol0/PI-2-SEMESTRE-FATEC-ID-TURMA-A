namespace ControleDoações
{
    partial class Menu
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
            this.logoffBt = new System.Windows.Forms.Button();
            this.cadastrBt = new System.Windows.Forms.Button();
            this.movimBt = new System.Windows.Forms.Button();
            this.consultBt = new System.Windows.Forms.Button();
            this.menuLb = new System.Windows.Forms.Label();
            this.registrarBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoffBt
            // 
            this.logoffBt.Location = new System.Drawing.Point(12, 12);
            this.logoffBt.Name = "logoffBt";
            this.logoffBt.Size = new System.Drawing.Size(75, 23);
            this.logoffBt.TabIndex = 0;
            this.logoffBt.Text = "Logoff";
            this.logoffBt.UseVisualStyleBackColor = true;
            this.logoffBt.Click += new System.EventHandler(this.logoffBt_Click);
            // 
            // cadastrBt
            // 
            this.cadastrBt.Location = new System.Drawing.Point(337, 286);
            this.cadastrBt.Name = "cadastrBt";
            this.cadastrBt.Size = new System.Drawing.Size(133, 39);
            this.cadastrBt.TabIndex = 1;
            this.cadastrBt.Text = "Origens";
            this.cadastrBt.UseVisualStyleBackColor = true;
            this.cadastrBt.Click += new System.EventHandler(this.cadastrBt_Click);
            // 
            // movimBt
            // 
            this.movimBt.Location = new System.Drawing.Point(337, 219);
            this.movimBt.Name = "movimBt";
            this.movimBt.Size = new System.Drawing.Size(133, 39);
            this.movimBt.TabIndex = 2;
            this.movimBt.Text = "Movimentação";
            this.movimBt.UseVisualStyleBackColor = true;
            this.movimBt.Click += new System.EventHandler(this.movimBt_Click);
            // 
            // consultBt
            // 
            this.consultBt.Location = new System.Drawing.Point(337, 353);
            this.consultBt.Name = "consultBt";
            this.consultBt.Size = new System.Drawing.Size(133, 39);
            this.consultBt.TabIndex = 3;
            this.consultBt.Text = "Consultas";
            this.consultBt.UseVisualStyleBackColor = true;
            this.consultBt.Click += new System.EventHandler(this.consultBt_Click);
            // 
            // menuLb
            // 
            this.menuLb.AutoSize = true;
            this.menuLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.menuLb.Location = new System.Drawing.Point(258, 75);
            this.menuLb.Name = "menuLb";
            this.menuLb.Size = new System.Drawing.Size(284, 46);
            this.menuLb.TabIndex = 4;
            this.menuLb.Text = "Menu Principal";
            // 
            // registrarBt
            // 
            this.registrarBt.Location = new System.Drawing.Point(12, 41);
            this.registrarBt.Name = "registrarBt";
            this.registrarBt.Size = new System.Drawing.Size(75, 36);
            this.registrarBt.TabIndex = 5;
            this.registrarBt.Text = "Gerenciar Colabs.";
            this.registrarBt.UseVisualStyleBackColor = true;
            this.registrarBt.Click += new System.EventHandler(this.registrarBt_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrarBt);
            this.Controls.Add(this.menuLb);
            this.Controls.Add(this.consultBt);
            this.Controls.Add(this.movimBt);
            this.Controls.Add(this.cadastrBt);
            this.Controls.Add(this.logoffBt);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoffBt;
        private System.Windows.Forms.Button cadastrBt;
        private System.Windows.Forms.Button movimBt;
        private System.Windows.Forms.Button consultBt;
        private System.Windows.Forms.Label menuLb;
        private System.Windows.Forms.Button registrarBt;
    }
}

