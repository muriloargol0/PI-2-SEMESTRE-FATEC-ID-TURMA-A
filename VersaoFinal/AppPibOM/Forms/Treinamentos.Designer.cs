namespace AppPibOM
{
    partial class Treinamentos
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
            this.Painel_Treinamento = new System.Windows.Forms.Panel();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.dtxbDataLimite = new System.Windows.Forms.DateTimePicker();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.txbSubtitulo = new System.Windows.Forms.TextBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.Label_Descrição_Treinamento = new System.Windows.Forms.Label();
            this.Label_Data_Limite = new System.Windows.Forms.Label();
            this.Label_Autor = new System.Windows.Forms.Label();
            this.Label_Id_Treinamento = new System.Windows.Forms.Label();
            this.Label_Subtitulo = new System.Windows.Forms.Label();
            this.Label_Titulo_Treinamento = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.txbConsulta = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Painel_Treinamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Treinamento
            // 
            this.Painel_Treinamento.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Painel_Treinamento.Controls.Add(this.txbDescricao);
            this.Painel_Treinamento.Controls.Add(this.dtxbDataLimite);
            this.Painel_Treinamento.Controls.Add(this.txbAutor);
            this.Painel_Treinamento.Controls.Add(this.txbSubtitulo);
            this.Painel_Treinamento.Controls.Add(this.txbTitulo);
            this.Painel_Treinamento.Controls.Add(this.txbID);
            this.Painel_Treinamento.Controls.Add(this.btnConsultar);
            this.Painel_Treinamento.Controls.Add(this.btnExcluir);
            this.Painel_Treinamento.Controls.Add(this.btnEditar);
            this.Painel_Treinamento.Controls.Add(this.btnLimpar);
            this.Painel_Treinamento.Controls.Add(this.btnSalvar);
            this.Painel_Treinamento.Controls.Add(this.Label_Descrição_Treinamento);
            this.Painel_Treinamento.Controls.Add(this.Label_Data_Limite);
            this.Painel_Treinamento.Controls.Add(this.Label_Autor);
            this.Painel_Treinamento.Controls.Add(this.Label_Id_Treinamento);
            this.Painel_Treinamento.Controls.Add(this.Label_Subtitulo);
            this.Painel_Treinamento.Controls.Add(this.Label_Titulo_Treinamento);
            this.Painel_Treinamento.Controls.Add(this.lblDia);
            this.Painel_Treinamento.Controls.Add(this.txbConsulta);
            this.Painel_Treinamento.Controls.Add(this.lblData);
            this.Painel_Treinamento.Controls.Add(this.lblSegundos);
            this.Painel_Treinamento.Controls.Add(this.lblHora);
            this.Painel_Treinamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Treinamento.Location = new System.Drawing.Point(0, 0);
            this.Painel_Treinamento.Name = "Painel_Treinamento";
            this.Painel_Treinamento.Size = new System.Drawing.Size(1044, 597);
            this.Painel_Treinamento.TabIndex = 0;
            this.Painel_Treinamento.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Treinamento_Paint);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricao.Location = new System.Drawing.Point(200, 357);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(200, 131);
            this.txbDescricao.TabIndex = 66;
            // 
            // dtxbDataLimite
            // 
            this.dtxbDataLimite.CustomFormat = "dd/MM/yyyy";
            this.dtxbDataLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtxbDataLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtxbDataLimite.Location = new System.Drawing.Point(200, 284);
            this.dtxbDataLimite.Name = "dtxbDataLimite";
            this.dtxbDataLimite.Size = new System.Drawing.Size(200, 29);
            this.dtxbDataLimite.TabIndex = 64;
            // 
            // txbAutor
            // 
            this.txbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAutor.Location = new System.Drawing.Point(200, 233);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(200, 29);
            this.txbAutor.TabIndex = 63;
            // 
            // txbSubtitulo
            // 
            this.txbSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubtitulo.Location = new System.Drawing.Point(200, 184);
            this.txbSubtitulo.Name = "txbSubtitulo";
            this.txbSubtitulo.Size = new System.Drawing.Size(200, 29);
            this.txbSubtitulo.TabIndex = 62;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitulo.Location = new System.Drawing.Point(200, 138);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(200, 29);
            this.txbTitulo.TabIndex = 61;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(200, 93);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(200, 29);
            this.txbID.TabIndex = 60;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnConsultar.Location = new System.Drawing.Point(356, 29);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 29);
            this.btnConsultar.TabIndex = 59;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnExcluir.Location = new System.Drawing.Point(357, 529);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 35);
            this.btnExcluir.TabIndex = 56;
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
            this.btnEditar.Location = new System.Drawing.Point(201, 529);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 35);
            this.btnEditar.TabIndex = 55;
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
            this.btnLimpar.Location = new System.Drawing.Point(45, 529);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 35);
            this.btnLimpar.TabIndex = 54;
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
            this.btnSalvar.Location = new System.Drawing.Point(549, 529);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 35);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Label_Descrição_Treinamento
            // 
            this.Label_Descrição_Treinamento.AutoSize = true;
            this.Label_Descrição_Treinamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Descrição_Treinamento.Location = new System.Drawing.Point(44, 357);
            this.Label_Descrição_Treinamento.Name = "Label_Descrição_Treinamento";
            this.Label_Descrição_Treinamento.Size = new System.Drawing.Size(92, 18);
            this.Label_Descrição_Treinamento.TabIndex = 45;
            this.Label_Descrição_Treinamento.Text = "Descrição :";
            // 
            // Label_Data_Limite
            // 
            this.Label_Data_Limite.AutoSize = true;
            this.Label_Data_Limite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Data_Limite.Location = new System.Drawing.Point(42, 286);
            this.Label_Data_Limite.Name = "Label_Data_Limite";
            this.Label_Data_Limite.Size = new System.Drawing.Size(95, 18);
            this.Label_Data_Limite.TabIndex = 40;
            this.Label_Data_Limite.Text = "Data limite :";
            // 
            // Label_Autor
            // 
            this.Label_Autor.AutoSize = true;
            this.Label_Autor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Autor.Location = new System.Drawing.Point(42, 240);
            this.Label_Autor.Name = "Label_Autor";
            this.Label_Autor.Size = new System.Drawing.Size(55, 18);
            this.Label_Autor.TabIndex = 38;
            this.Label_Autor.Text = "Autor :";
            // 
            // Label_Id_Treinamento
            // 
            this.Label_Id_Treinamento.AutoSize = true;
            this.Label_Id_Treinamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Id_Treinamento.Location = new System.Drawing.Point(44, 104);
            this.Label_Id_Treinamento.Name = "Label_Id_Treinamento";
            this.Label_Id_Treinamento.Size = new System.Drawing.Size(31, 18);
            this.Label_Id_Treinamento.TabIndex = 35;
            this.Label_Id_Treinamento.Text = "ID :";
            // 
            // Label_Subtitulo
            // 
            this.Label_Subtitulo.AutoSize = true;
            this.Label_Subtitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Subtitulo.Location = new System.Drawing.Point(44, 195);
            this.Label_Subtitulo.Name = "Label_Subtitulo";
            this.Label_Subtitulo.Size = new System.Drawing.Size(74, 18);
            this.Label_Subtitulo.TabIndex = 34;
            this.Label_Subtitulo.Text = "Subtítulo:";
            // 
            // Label_Titulo_Treinamento
            // 
            this.Label_Titulo_Treinamento.AutoSize = true;
            this.Label_Titulo_Treinamento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo_Treinamento.Location = new System.Drawing.Point(43, 145);
            this.Label_Titulo_Treinamento.Name = "Label_Titulo_Treinamento";
            this.Label_Titulo_Treinamento.Size = new System.Drawing.Size(53, 18);
            this.Label_Titulo_Treinamento.TabIndex = 33;
            this.Label_Titulo_Treinamento.Text = "Título :";
            // 
            // lblDia
            // 
            this.lblDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(945, 526);
            this.lblDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(51, 30);
            this.lblDia.TabIndex = 7;
            this.lblDia.Text = "dia";
            // 
            // txbConsulta
            // 
            this.txbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsulta.Location = new System.Drawing.Point(46, 29);
            this.txbConsulta.Name = "txbConsulta";
            this.txbConsulta.Size = new System.Drawing.Size(312, 29);
            this.txbConsulta.TabIndex = 6;
            this.txbConsulta.TextChanged += new System.EventHandler(this.Textobox_Consulta_TextChanged);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(770, 526);
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
            this.lblSegundos.Location = new System.Drawing.Point(952, 467);
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
            this.lblHora.Location = new System.Drawing.Point(736, 441);
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
            // Treinamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 597);
            this.Controls.Add(this.Painel_Treinamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Treinamentos";
            this.Text = "Treinamentos";
            this.Painel_Treinamento.ResumeLayout(false);
            this.Painel_Treinamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Treinamento;
        private System.Windows.Forms.TextBox txbConsulta;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Label_Descrição_Treinamento;
        private System.Windows.Forms.Label Label_Data_Limite;
        private System.Windows.Forms.Label Label_Autor;
        private System.Windows.Forms.Label Label_Id_Treinamento;
        private System.Windows.Forms.Label Label_Subtitulo;
        private System.Windows.Forms.Label Label_Titulo_Treinamento;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.DateTimePicker dtxbDataLimite;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.TextBox txbSubtitulo;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbID;
    }
}