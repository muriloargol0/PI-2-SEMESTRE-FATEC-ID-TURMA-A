namespace AppPibOM
{
    partial class Funcionarios
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
            this.painel_funcionarios = new System.Windows.Forms.Panel();
            this.mtxbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.mtxbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxbDataContrato = new System.Windows.Forms.DateTimePicker();
            this.mtxbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxbRG = new System.Windows.Forms.MaskedTextBox();
            this.txbFuncao = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txbConsultar = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_RG = new System.Windows.Forms.Label();
            this.Label_Data_Contrato = new System.Windows.Forms.Label();
            this.Label_CPF = new System.Windows.Forms.Label();
            this.Label_Id_Funcionario = new System.Windows.Forms.Label();
            this.Label_Funcao = new System.Windows.Forms.Label();
            this.Label_Nome = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.painel_funcionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_funcionarios
            // 
            this.painel_funcionarios.BackColor = System.Drawing.Color.AntiqueWhite;
            this.painel_funcionarios.Controls.Add(this.mtxbCEP);
            this.painel_funcionarios.Controls.Add(this.txbEndereco);
            this.painel_funcionarios.Controls.Add(this.mtxbTelefone);
            this.painel_funcionarios.Controls.Add(this.mtxbDataContrato);
            this.painel_funcionarios.Controls.Add(this.mtxbCPF);
            this.painel_funcionarios.Controls.Add(this.mtxbRG);
            this.painel_funcionarios.Controls.Add(this.txbFuncao);
            this.painel_funcionarios.Controls.Add(this.txbNome);
            this.painel_funcionarios.Controls.Add(this.txbID);
            this.painel_funcionarios.Controls.Add(this.btnConsultar);
            this.painel_funcionarios.Controls.Add(this.txbConsultar);
            this.painel_funcionarios.Controls.Add(this.btnExcluir);
            this.painel_funcionarios.Controls.Add(this.btnEditar);
            this.painel_funcionarios.Controls.Add(this.btnLimpar);
            this.painel_funcionarios.Controls.Add(this.btnSalvar);
            this.painel_funcionarios.Controls.Add(this.label3);
            this.painel_funcionarios.Controls.Add(this.label2);
            this.painel_funcionarios.Controls.Add(this.label1);
            this.painel_funcionarios.Controls.Add(this.Label_RG);
            this.painel_funcionarios.Controls.Add(this.Label_Data_Contrato);
            this.painel_funcionarios.Controls.Add(this.Label_CPF);
            this.painel_funcionarios.Controls.Add(this.Label_Id_Funcionario);
            this.painel_funcionarios.Controls.Add(this.Label_Funcao);
            this.painel_funcionarios.Controls.Add(this.Label_Nome);
            this.painel_funcionarios.Controls.Add(this.lblDia);
            this.painel_funcionarios.Controls.Add(this.lblData);
            this.painel_funcionarios.Controls.Add(this.lblSegundos);
            this.painel_funcionarios.Controls.Add(this.lblHora);
            this.painel_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_funcionarios.Location = new System.Drawing.Point(0, 0);
            this.painel_funcionarios.Name = "painel_funcionarios";
            this.painel_funcionarios.Size = new System.Drawing.Size(1047, 599);
            this.painel_funcionarios.TabIndex = 0;
            this.painel_funcionarios.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_funcionarios_Paint);
            // 
            // mtxbCEP
            // 
            this.mtxbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbCEP.Location = new System.Drawing.Point(655, 194);
            this.mtxbCEP.Mask = "00000-000";
            this.mtxbCEP.Name = "mtxbCEP";
            this.mtxbCEP.Size = new System.Drawing.Size(207, 29);
            this.mtxbCEP.TabIndex = 80;
            this.mtxbCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(655, 146);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(207, 29);
            this.txbEndereco.TabIndex = 79;
            // 
            // mtxbTelefone
            // 
            this.mtxbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbTelefone.Location = new System.Drawing.Point(655, 100);
            this.mtxbTelefone.Mask = "(99) 00000-0000";
            this.mtxbTelefone.Name = "mtxbTelefone";
            this.mtxbTelefone.Size = new System.Drawing.Size(207, 29);
            this.mtxbTelefone.TabIndex = 78;
            this.mtxbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxbDataContrato
            // 
            this.mtxbDataContrato.CustomFormat = "dd/MM/yyyy";
            this.mtxbDataContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbDataContrato.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtxbDataContrato.Location = new System.Drawing.Point(190, 333);
            this.mtxbDataContrato.Name = "mtxbDataContrato";
            this.mtxbDataContrato.Size = new System.Drawing.Size(207, 29);
            this.mtxbDataContrato.TabIndex = 77;
            // 
            // mtxbCPF
            // 
            this.mtxbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbCPF.Location = new System.Drawing.Point(190, 287);
            this.mtxbCPF.Mask = "000.000.000-00";
            this.mtxbCPF.Name = "mtxbCPF";
            this.mtxbCPF.Size = new System.Drawing.Size(207, 29);
            this.mtxbCPF.TabIndex = 76;
            this.mtxbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxbRG
            // 
            this.mtxbRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbRG.Location = new System.Drawing.Point(190, 237);
            this.mtxbRG.Mask = "00.000.000-0";
            this.mtxbRG.Name = "mtxbRG";
            this.mtxbRG.Size = new System.Drawing.Size(207, 29);
            this.mtxbRG.TabIndex = 75;
            this.mtxbRG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbFuncao
            // 
            this.txbFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFuncao.Location = new System.Drawing.Point(190, 191);
            this.txbFuncao.Name = "txbFuncao";
            this.txbFuncao.Size = new System.Drawing.Size(207, 29);
            this.txbFuncao.TabIndex = 74;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(190, 146);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(207, 29);
            this.txbNome.TabIndex = 73;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(190, 104);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(207, 29);
            this.txbID.TabIndex = 72;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnConsultar.Location = new System.Drawing.Point(335, 37);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 29);
            this.btnConsultar.TabIndex = 71;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txbConsultar
            // 
            this.txbConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsultar.Location = new System.Drawing.Point(46, 37);
            this.txbConsultar.Name = "txbConsultar";
            this.txbConsultar.Size = new System.Drawing.Size(291, 29);
            this.txbConsultar.TabIndex = 70;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnExcluir.Location = new System.Drawing.Point(339, 449);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 35);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEditar.Location = new System.Drawing.Point(194, 449);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 35);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnLimpar.Location = new System.Drawing.Point(50, 449);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 35);
            this.btnLimpar.TabIndex = 67;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSalvar.Location = new System.Drawing.Point(525, 449);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 35);
            this.btnSalvar.TabIndex = 66;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "CEP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Endereço :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Telefone :";
            // 
            // Label_RG
            // 
            this.Label_RG.AutoSize = true;
            this.Label_RG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RG.Location = new System.Drawing.Point(47, 245);
            this.Label_RG.Name = "Label_RG";
            this.Label_RG.Size = new System.Drawing.Size(35, 18);
            this.Label_RG.TabIndex = 40;
            this.Label_RG.Text = "Rg :";
            // 
            // Label_Data_Contrato
            // 
            this.Label_Data_Contrato.AutoSize = true;
            this.Label_Data_Contrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Data_Contrato.Location = new System.Drawing.Point(47, 341);
            this.Label_Data_Contrato.Name = "Label_Data_Contrato";
            this.Label_Data_Contrato.Size = new System.Drawing.Size(117, 18);
            this.Label_Data_Contrato.TabIndex = 35;
            this.Label_Data_Contrato.Text = "Data contrato :";
            // 
            // Label_CPF
            // 
            this.Label_CPF.AutoSize = true;
            this.Label_CPF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CPF.Location = new System.Drawing.Point(47, 291);
            this.Label_CPF.Name = "Label_CPF";
            this.Label_CPF.Size = new System.Drawing.Size(43, 18);
            this.Label_CPF.TabIndex = 33;
            this.Label_CPF.Text = "CPF :";
            // 
            // Label_Id_Funcionario
            // 
            this.Label_Id_Funcionario.AutoSize = true;
            this.Label_Id_Funcionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Id_Funcionario.Location = new System.Drawing.Point(47, 111);
            this.Label_Id_Funcionario.Name = "Label_Id_Funcionario";
            this.Label_Id_Funcionario.Size = new System.Drawing.Size(31, 18);
            this.Label_Id_Funcionario.TabIndex = 30;
            this.Label_Id_Funcionario.Text = "ID :";
            // 
            // Label_Funcao
            // 
            this.Label_Funcao.AutoSize = true;
            this.Label_Funcao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Funcao.Location = new System.Drawing.Point(47, 202);
            this.Label_Funcao.Name = "Label_Funcao";
            this.Label_Funcao.Size = new System.Drawing.Size(71, 18);
            this.Label_Funcao.TabIndex = 29;
            this.Label_Funcao.Text = "Função :";
            // 
            // Label_Nome
            // 
            this.Label_Nome.AutoSize = true;
            this.Label_Nome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nome.Location = new System.Drawing.Point(47, 157);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(61, 18);
            this.Label_Nome.TabIndex = 28;
            this.Label_Nome.Text = "Nome :";
            // 
            // lblDia
            // 
            this.lblDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(934, 522);
            this.lblDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(51, 30);
            this.lblDia.TabIndex = 7;
            this.lblDia.Text = "dia";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(759, 522);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(137, 30);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "01/01/1900";
            // 
            // lblSegundos
            // 
            this.lblSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(942, 463);
            this.lblSegundos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(39, 30);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "00";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(725, 437);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(191, 78);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 599);
            this.Controls.Add(this.painel_funcionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.painel_funcionarios.ResumeLayout(false);
            this.painel_funcionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_funcionarios;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_RG;
        private System.Windows.Forms.Label Label_Data_Contrato;
        private System.Windows.Forms.Label Label_CPF;
        private System.Windows.Forms.Label Label_Id_Funcionario;
        private System.Windows.Forms.Label Label_Funcao;
        private System.Windows.Forms.Label Label_Nome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txbConsultar;
        private System.Windows.Forms.TextBox txbFuncao;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.MaskedTextBox mtxbCPF;
        private System.Windows.Forms.MaskedTextBox mtxbRG;
        private System.Windows.Forms.MaskedTextBox mtxbCEP;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.MaskedTextBox mtxbTelefone;
        private System.Windows.Forms.DateTimePicker mtxbDataContrato;
    }
}