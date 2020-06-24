namespace AutoEscola
{
    partial class MenuCadastro
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cliente = new System.Windows.Forms.Button();
            this.Funcionário = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btDespesa = new System.Windows.Forms.Button();
            this.btAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.BackColor = System.Drawing.Color.Gold;
            this.Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cliente.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(56, 78);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(179, 92);
            this.Cliente.TabIndex = 0;
            this.Cliente.Text = "Cliente";
            this.Cliente.UseVisualStyleBackColor = false;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // Funcionário
            // 
            this.Funcionário.BackColor = System.Drawing.Color.Gold;
            this.Funcionário.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Funcionário.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcionário.Location = new System.Drawing.Point(298, 78);
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.Size = new System.Drawing.Size(179, 92);
            this.Funcionário.TabIndex = 1;
            this.Funcionário.Text = "Funcionário";
            this.Funcionário.UseVisualStyleBackColor = false;
            this.Funcionário.Click += new System.EventHandler(this.Funcionário_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(536, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "Veículo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btDespesa
            // 
            this.btDespesa.BackColor = System.Drawing.Color.Gold;
            this.btDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDespesa.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDespesa.Location = new System.Drawing.Point(170, 241);
            this.btDespesa.Name = "btDespesa";
            this.btDespesa.Size = new System.Drawing.Size(179, 92);
            this.btDespesa.TabIndex = 3;
            this.btDespesa.Text = "Despesa";
            this.btDespesa.UseVisualStyleBackColor = false;
            this.btDespesa.Click += new System.EventHandler(this.btDespesa_Click);
            // 
            // btAgenda
            // 
            this.btAgenda.BackColor = System.Drawing.Color.Gold;
            this.btAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgenda.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgenda.Location = new System.Drawing.Point(421, 241);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(179, 92);
            this.btAgenda.TabIndex = 4;
            this.btAgenda.Text = "Agenda";
            this.btAgenda.UseVisualStyleBackColor = false;
            this.btAgenda.Click += new System.EventHandler(this.btAgenda_Click);
            // 
            // MenuCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btAgenda);
            this.Controls.Add(this.btDespesa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Funcionário);
            this.Controls.Add(this.Cliente);
            this.Name = "MenuCadastro";
            this.Size = new System.Drawing.Size(763, 431);
            this.Load += new System.EventHandler(this.MenuCadastro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cliente;
        private System.Windows.Forms.Button Funcionário;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btDespesa;
        private System.Windows.Forms.Button btAgenda;
    }
}
