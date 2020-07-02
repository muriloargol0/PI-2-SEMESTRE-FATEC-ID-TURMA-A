namespace AppPibOM.Forms
{
    partial class Projetos
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
            this.Painel_Projeto = new System.Windows.Forms.Panel();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbIntegrantes = new System.Windows.Forms.TextBox();
            this.dtxbData = new System.Windows.Forms.DateTimePicker();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txbConsultar = new System.Windows.Forms.TextBox();
            this.Descricao_Projeto = new System.Windows.Forms.Label();
            this.Label_Data_Contrato = new System.Windows.Forms.Label();
            this.Label_Integrante = new System.Windows.Forms.Label();
            this.Label_Autor_Projeto = new System.Windows.Forms.Label();
            this.Label_Subtitulo = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Painel_Projeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Projeto
            // 
            this.Painel_Projeto.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Painel_Projeto.Controls.Add(this.txbDescricao);
            this.Painel_Projeto.Controls.Add(this.txbIntegrantes);
            this.Painel_Projeto.Controls.Add(this.dtxbData);
            this.Painel_Projeto.Controls.Add(this.txbAutor);
            this.Painel_Projeto.Controls.Add(this.txbTitulo);
            this.Painel_Projeto.Controls.Add(this.txbID);
            this.Painel_Projeto.Controls.Add(this.btnExcluir);
            this.Painel_Projeto.Controls.Add(this.btnEditar);
            this.Painel_Projeto.Controls.Add(this.btnLimpar);
            this.Painel_Projeto.Controls.Add(this.btnSalvar);
            this.Painel_Projeto.Controls.Add(this.btnConsultar);
            this.Painel_Projeto.Controls.Add(this.txbConsultar);
            this.Painel_Projeto.Controls.Add(this.Descricao_Projeto);
            this.Painel_Projeto.Controls.Add(this.Label_Data_Contrato);
            this.Painel_Projeto.Controls.Add(this.Label_Integrante);
            this.Painel_Projeto.Controls.Add(this.Label_Autor_Projeto);
            this.Painel_Projeto.Controls.Add(this.Label_Subtitulo);
            this.Painel_Projeto.Controls.Add(this.labelID);
            this.Painel_Projeto.Controls.Add(this.lblDia);
            this.Painel_Projeto.Controls.Add(this.lblData);
            this.Painel_Projeto.Controls.Add(this.lblSegundos);
            this.Painel_Projeto.Controls.Add(this.lblHora);
            this.Painel_Projeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Projeto.Location = new System.Drawing.Point(0, 0);
            this.Painel_Projeto.Name = "Painel_Projeto";
            this.Painel_Projeto.Size = new System.Drawing.Size(1047, 599);
            this.Painel_Projeto.TabIndex = 0;
            this.Painel_Projeto.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Projeto_Paint);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricao.Location = new System.Drawing.Point(215, 352);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(225, 152);
            this.txbDescricao.TabIndex = 71;
            // 
            // txbIntegrantes
            // 
            this.txbIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIntegrantes.Location = new System.Drawing.Point(215, 269);
            this.txbIntegrantes.Multiline = true;
            this.txbIntegrantes.Name = "txbIntegrantes";
            this.txbIntegrantes.Size = new System.Drawing.Size(225, 68);
            this.txbIntegrantes.TabIndex = 70;
            // 
            // dtxbData
            // 
            this.dtxbData.CustomFormat = "dd/MM/yyyy";
            this.dtxbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtxbData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtxbData.Location = new System.Drawing.Point(215, 225);
            this.dtxbData.Name = "dtxbData";
            this.dtxbData.Size = new System.Drawing.Size(225, 29);
            this.dtxbData.TabIndex = 69;
            // 
            // txbAutor
            // 
            this.txbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(215, 170);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(225, 29);
            this.txbAutor.TabIndex = 68;
            this.txbAutor.TextChanged += new System.EventHandler(this.txbAutor_TextChanged);
            // 
            // txbTitulo
            // 
            this.txbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(215, 125);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(225, 29);
            this.txbTitulo.TabIndex = 67;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(215, 83);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(225, 29);
            this.txbID.TabIndex = 66;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnExcluir.Location = new System.Drawing.Point(371, 531);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 35);
            this.btnExcluir.TabIndex = 65;
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
            this.btnEditar.Location = new System.Drawing.Point(215, 531);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 35);
            this.btnEditar.TabIndex = 64;
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
            this.btnLimpar.Location = new System.Drawing.Point(49, 531);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 35);
            this.btnLimpar.TabIndex = 63;
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
            this.btnSalvar.Location = new System.Drawing.Point(563, 531);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 35);
            this.btnSalvar.TabIndex = 62;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnConsultar.Location = new System.Drawing.Point(338, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(157, 29);
            this.btnConsultar.TabIndex = 61;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txbConsultar
            // 
            this.txbConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsultar.Location = new System.Drawing.Point(49, 20);
            this.txbConsultar.Name = "txbConsultar";
            this.txbConsultar.Size = new System.Drawing.Size(291, 29);
            this.txbConsultar.TabIndex = 60;
            this.txbConsultar.TextChanged += new System.EventHandler(this.txbConsultar_TextChanged);
            // 
            // Descricao_Projeto
            // 
            this.Descricao_Projeto.AutoSize = true;
            this.Descricao_Projeto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao_Projeto.Location = new System.Drawing.Point(46, 341);
            this.Descricao_Projeto.Name = "Descricao_Projeto";
            this.Descricao_Projeto.Size = new System.Drawing.Size(92, 18);
            this.Descricao_Projeto.TabIndex = 41;
            this.Descricao_Projeto.Text = "Descrição :";
            // 
            // Label_Data_Contrato
            // 
            this.Label_Data_Contrato.AutoSize = true;
            this.Label_Data_Contrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Data_Contrato.Location = new System.Drawing.Point(46, 227);
            this.Label_Data_Contrato.Name = "Label_Data_Contrato";
            this.Label_Data_Contrato.Size = new System.Drawing.Size(51, 18);
            this.Label_Data_Contrato.TabIndex = 38;
            this.Label_Data_Contrato.Text = "Data :";
            // 
            // Label_Integrante
            // 
            this.Label_Integrante.AutoSize = true;
            this.Label_Integrante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Integrante.Location = new System.Drawing.Point(46, 276);
            this.Label_Integrante.Name = "Label_Integrante";
            this.Label_Integrante.Size = new System.Drawing.Size(97, 18);
            this.Label_Integrante.TabIndex = 36;
            this.Label_Integrante.Text = "Integrantes :";
            // 
            // Label_Autor_Projeto
            // 
            this.Label_Autor_Projeto.AutoSize = true;
            this.Label_Autor_Projeto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Autor_Projeto.Location = new System.Drawing.Point(46, 181);
            this.Label_Autor_Projeto.Name = "Label_Autor_Projeto";
            this.Label_Autor_Projeto.Size = new System.Drawing.Size(55, 18);
            this.Label_Autor_Projeto.TabIndex = 33;
            this.Label_Autor_Projeto.Text = "Autor :";
            // 
            // Label_Subtitulo
            // 
            this.Label_Subtitulo.AutoSize = true;
            this.Label_Subtitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Subtitulo.Location = new System.Drawing.Point(46, 136);
            this.Label_Subtitulo.Name = "Label_Subtitulo";
            this.Label_Subtitulo.Size = new System.Drawing.Size(45, 18);
            this.Label_Subtitulo.TabIndex = 32;
            this.Label_Subtitulo.Text = "Titulo";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(46, 90);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 18);
            this.labelID.TabIndex = 31;
            this.labelID.Text = "ID :";
            // 
            // lblDia
            // 
            this.lblDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(932, 498);
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
            this.lblData.Location = new System.Drawing.Point(756, 498);
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
            this.lblSegundos.Location = new System.Drawing.Point(939, 440);
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
            this.lblHora.Location = new System.Drawing.Point(722, 414);
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
            // Projetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 599);
            this.Controls.Add(this.Painel_Projeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projetos";
            this.Text = "Projetos";
            this.Painel_Projeto.ResumeLayout(false);
            this.Painel_Projeto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Projeto;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Descricao_Projeto;
        private System.Windows.Forms.Label Label_Data_Contrato;
        private System.Windows.Forms.Label Label_Integrante;
        private System.Windows.Forms.Label Label_Autor_Projeto;
        private System.Windows.Forms.Label Label_Subtitulo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txbConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbIntegrantes;
        private System.Windows.Forms.DateTimePicker dtxbData;
    }
}