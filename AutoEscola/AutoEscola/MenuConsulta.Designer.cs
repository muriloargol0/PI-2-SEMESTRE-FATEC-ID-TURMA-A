namespace AutoEscola
{
    partial class MenuConsulta
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
            this.btVeiculo = new System.Windows.Forms.Button();
            this.btFuncionário = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.btGastos = new System.Windows.Forms.Button();
            this.btAgenda = new System.Windows.Forms.Button();
            this.btPagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVeiculo
            // 
            this.btVeiculo.BackColor = System.Drawing.Color.Gold;
            this.btVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVeiculo.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVeiculo.Location = new System.Drawing.Point(146, 311);
            this.btVeiculo.Name = "btVeiculo";
            this.btVeiculo.Size = new System.Drawing.Size(179, 92);
            this.btVeiculo.TabIndex = 5;
            this.btVeiculo.Text = "Veículo";
            this.btVeiculo.UseVisualStyleBackColor = false;
            this.btVeiculo.Click += new System.EventHandler(this.btVeiculo_Click);
            // 
            // btFuncionário
            // 
            this.btFuncionário.BackColor = System.Drawing.Color.Gold;
            this.btFuncionário.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionário.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionário.Location = new System.Drawing.Point(146, 170);
            this.btFuncionário.Name = "btFuncionário";
            this.btFuncionário.Size = new System.Drawing.Size(179, 92);
            this.btFuncionário.TabIndex = 4;
            this.btFuncionário.Text = "Funcionário";
            this.btFuncionário.UseVisualStyleBackColor = false;
            this.btFuncionário.Click += new System.EventHandler(this.btFuncionário_Click);
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.Gold;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCliente.Location = new System.Drawing.Point(146, 31);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(179, 92);
            this.btCliente.TabIndex = 3;
            this.btCliente.Text = "Cliente";
            this.btCliente.UseVisualStyleBackColor = false;
            this.btCliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // btGastos
            // 
            this.btGastos.BackColor = System.Drawing.Color.Gold;
            this.btGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGastos.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGastos.Location = new System.Drawing.Point(428, 170);
            this.btGastos.Name = "btGastos";
            this.btGastos.Size = new System.Drawing.Size(179, 92);
            this.btGastos.TabIndex = 7;
            this.btGastos.Text = "Despesa";
            this.btGastos.UseVisualStyleBackColor = false;
            this.btGastos.Click += new System.EventHandler(this.btGastos_Click);
            // 
            // btAgenda
            // 
            this.btAgenda.BackColor = System.Drawing.Color.Gold;
            this.btAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgenda.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgenda.Location = new System.Drawing.Point(428, 31);
            this.btAgenda.Name = "btAgenda";
            this.btAgenda.Size = new System.Drawing.Size(179, 92);
            this.btAgenda.TabIndex = 6;
            this.btAgenda.Text = "Agenda";
            this.btAgenda.UseVisualStyleBackColor = false;
            this.btAgenda.Click += new System.EventHandler(this.btAgenda_Click);
            // 
            // btPagamento
            // 
            this.btPagamento.BackColor = System.Drawing.Color.Gold;
            this.btPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPagamento.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagamento.Location = new System.Drawing.Point(428, 311);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(179, 92);
            this.btPagamento.TabIndex = 8;
            this.btPagamento.Text = "Pagamento";
            this.btPagamento.UseVisualStyleBackColor = false;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // MenuConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.btGastos);
            this.Controls.Add(this.btAgenda);
            this.Controls.Add(this.btVeiculo);
            this.Controls.Add(this.btFuncionário);
            this.Controls.Add(this.btCliente);
            this.Name = "MenuConsulta";
            this.Size = new System.Drawing.Size(763, 431);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btVeiculo;
        private System.Windows.Forms.Button btFuncionário;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btGastos;
        private System.Windows.Forms.Button btAgenda;
        private System.Windows.Forms.Button btPagamento;
    }
}
