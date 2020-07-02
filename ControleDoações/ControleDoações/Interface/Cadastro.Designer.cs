namespace ControleDoações
{
    partial class Cadastro
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
            this.gerenciarOrigensLb = new System.Windows.Forms.Label();
            this.saveBt = new System.Windows.Forms.Button();
            this.voltarCadBt = new System.Windows.Forms.Button();
            this.origemTb = new System.Windows.Forms.TextBox();
            this.origemLb = new System.Windows.Forms.Label();
            this.descripLb = new System.Windows.Forms.Label();
            this.descripTb = new System.Windows.Forms.TextBox();
            this.novaOrigemLb = new System.Windows.Forms.Label();
            this.deleteBt = new System.Windows.Forms.Button();
            this.alterarBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.confirmBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.alterarLb = new System.Windows.Forms.Label();
            this.cpfLb = new System.Windows.Forms.Label();
            this.cnpjLb = new System.Windows.Forms.Label();
            this.mailLb = new System.Windows.Forms.Label();
            this.mailTb = new System.Windows.Forms.TextBox();
            this.foneLb = new System.Windows.Forms.Label();
            this.foneTb = new System.Windows.Forms.TextBox();
            this.endLb = new System.Windows.Forms.Label();
            this.endTb = new System.Windows.Forms.TextBox();
            this.newBt = new System.Windows.Forms.Button();
            this.cpfTb = new System.Windows.Forms.MaskedTextBox();
            this.cnpjTb = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gerenciarOrigensLb
            // 
            this.gerenciarOrigensLb.AutoSize = true;
            this.gerenciarOrigensLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.gerenciarOrigensLb.Location = new System.Drawing.Point(227, 75);
            this.gerenciarOrigensLb.Name = "gerenciarOrigensLb";
            this.gerenciarOrigensLb.Size = new System.Drawing.Size(345, 46);
            this.gerenciarOrigensLb.TabIndex = 9;
            this.gerenciarOrigensLb.Text = "Gerenciar Origens";
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(265, 378);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(133, 39);
            this.saveBt.TabIndex = 8;
            this.saveBt.Text = "Salvar";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // voltarCadBt
            // 
            this.voltarCadBt.Location = new System.Drawing.Point(12, 12);
            this.voltarCadBt.Name = "voltarCadBt";
            this.voltarCadBt.Size = new System.Drawing.Size(75, 23);
            this.voltarCadBt.TabIndex = 5;
            this.voltarCadBt.Text = "Voltar";
            this.voltarCadBt.UseVisualStyleBackColor = true;
            this.voltarCadBt.Click += new System.EventHandler(this.voltarCadBt_Click);
            // 
            // origemTb
            // 
            this.origemTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.origemTb.Location = new System.Drawing.Point(145, 212);
            this.origemTb.Name = "origemTb";
            this.origemTb.Size = new System.Drawing.Size(206, 23);
            this.origemTb.TabIndex = 10;
            this.origemTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.origemTb_KeyPress);
            // 
            // origemLb
            // 
            this.origemLb.AutoSize = true;
            this.origemLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.origemLb.Location = new System.Drawing.Point(90, 215);
            this.origemLb.Name = "origemLb";
            this.origemLb.Size = new System.Drawing.Size(49, 17);
            this.origemLb.TabIndex = 11;
            this.origemLb.Text = "Nome:";
            // 
            // descripLb
            // 
            this.descripLb.AutoSize = true;
            this.descripLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descripLb.Location = new System.Drawing.Point(64, 320);
            this.descripLb.Name = "descripLb";
            this.descripLb.Size = new System.Drawing.Size(75, 17);
            this.descripLb.TabIndex = 13;
            this.descripLb.Text = "Descrição:";
            // 
            // descripTb
            // 
            this.descripTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descripTb.Location = new System.Drawing.Point(145, 317);
            this.descripTb.Name = "descripTb";
            this.descripTb.Size = new System.Drawing.Size(553, 23);
            this.descripTb.TabIndex = 12;
            this.descripTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripTb_KeyPress);
            // 
            // novaOrigemLb
            // 
            this.novaOrigemLb.AutoSize = true;
            this.novaOrigemLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.novaOrigemLb.Location = new System.Drawing.Point(295, 154);
            this.novaOrigemLb.Name = "novaOrigemLb";
            this.novaOrigemLb.Size = new System.Drawing.Size(218, 25);
            this.novaOrigemLb.TabIndex = 14;
            this.novaOrigemLb.Text = "Cadastrar Nova Origem";
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(465, 378);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(116, 39);
            this.deleteBt.TabIndex = 27;
            this.deleteBt.Text = "Apagar";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // alterarBt
            // 
            this.alterarBt.Location = new System.Drawing.Point(343, 378);
            this.alterarBt.Name = "alterarBt";
            this.alterarBt.Size = new System.Drawing.Size(116, 39);
            this.alterarBt.TabIndex = 26;
            this.alterarBt.Text = "Alterar";
            this.alterarBt.UseVisualStyleBackColor = true;
            this.alterarBt.Click += new System.EventHandler(this.alterarBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(739, 204);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // confirmBt
            // 
            this.confirmBt.Location = new System.Drawing.Point(265, 378);
            this.confirmBt.Name = "confirmBt";
            this.confirmBt.Size = new System.Drawing.Size(133, 39);
            this.confirmBt.TabIndex = 29;
            this.confirmBt.Text = "Confirmar alteração";
            this.confirmBt.UseVisualStyleBackColor = true;
            this.confirmBt.Click += new System.EventHandler(this.confirmBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(404, 378);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(133, 39);
            this.cancelBt.TabIndex = 30;
            this.cancelBt.Text = "Cancelar";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // alterarLb
            // 
            this.alterarLb.AutoSize = true;
            this.alterarLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.alterarLb.Location = new System.Drawing.Point(334, 154);
            this.alterarLb.Name = "alterarLb";
            this.alterarLb.Size = new System.Drawing.Size(138, 25);
            this.alterarLb.TabIndex = 31;
            this.alterarLb.Text = "Alterar Origem";
            // 
            // cpfLb
            // 
            this.cpfLb.AutoSize = true;
            this.cpfLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpfLb.Location = new System.Drawing.Point(101, 250);
            this.cpfLb.Name = "cpfLb";
            this.cpfLb.Size = new System.Drawing.Size(38, 17);
            this.cpfLb.TabIndex = 33;
            this.cpfLb.Text = "CPF:";
            // 
            // cnpjLb
            // 
            this.cnpjLb.AutoSize = true;
            this.cnpjLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cnpjLb.Location = new System.Drawing.Point(92, 285);
            this.cnpjLb.Name = "cnpjLb";
            this.cnpjLb.Size = new System.Drawing.Size(47, 17);
            this.cnpjLb.TabIndex = 35;
            this.cnpjLb.Text = "CNPJ:";
            // 
            // mailLb
            // 
            this.mailLb.AutoSize = true;
            this.mailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mailLb.Location = new System.Drawing.Point(435, 285);
            this.mailLb.Name = "mailLb";
            this.mailLb.Size = new System.Drawing.Size(51, 17);
            this.mailLb.TabIndex = 41;
            this.mailLb.Text = "E-mail:";
            // 
            // mailTb
            // 
            this.mailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mailTb.Location = new System.Drawing.Point(492, 282);
            this.mailTb.Name = "mailTb";
            this.mailTb.Size = new System.Drawing.Size(206, 23);
            this.mailTb.TabIndex = 40;
            // 
            // foneLb
            // 
            this.foneLb.AutoSize = true;
            this.foneLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.foneLb.Location = new System.Drawing.Point(418, 250);
            this.foneLb.Name = "foneLb";
            this.foneLb.Size = new System.Drawing.Size(68, 17);
            this.foneLb.TabIndex = 39;
            this.foneLb.Text = "Telefone:";
            // 
            // foneTb
            // 
            this.foneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.foneTb.Location = new System.Drawing.Point(492, 247);
            this.foneTb.Name = "foneTb";
            this.foneTb.Size = new System.Drawing.Size(206, 23);
            this.foneTb.TabIndex = 38;
            // 
            // endLb
            // 
            this.endLb.AutoSize = true;
            this.endLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.endLb.Location = new System.Drawing.Point(413, 215);
            this.endLb.Name = "endLb";
            this.endLb.Size = new System.Drawing.Size(73, 17);
            this.endLb.TabIndex = 37;
            this.endLb.Text = "Endereço:";
            // 
            // endTb
            // 
            this.endTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.endTb.Location = new System.Drawing.Point(492, 212);
            this.endTb.Name = "endTb";
            this.endTb.Size = new System.Drawing.Size(206, 23);
            this.endTb.TabIndex = 36;
            // 
            // newBt
            // 
            this.newBt.Location = new System.Drawing.Point(221, 378);
            this.newBt.Name = "newBt";
            this.newBt.Size = new System.Drawing.Size(116, 39);
            this.newBt.TabIndex = 42;
            this.newBt.Text = "Cadastrar Nova Origem";
            this.newBt.UseVisualStyleBackColor = true;
            this.newBt.Click += new System.EventHandler(this.newBt_Click);
            // 
            // cpfTb
            // 
            this.cpfTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpfTb.Location = new System.Drawing.Point(145, 247);
            this.cpfTb.Mask = "000000000-00";
            this.cpfTb.Name = "cpfTb";
            this.cpfTb.Size = new System.Drawing.Size(206, 23);
            this.cpfTb.TabIndex = 43;
            // 
            // cnpjTb
            // 
            this.cnpjTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cnpjTb.Location = new System.Drawing.Point(145, 282);
            this.cnpjTb.Mask = "00000000/0000-00";
            this.cnpjTb.Name = "cnpjTb";
            this.cnpjTb.Size = new System.Drawing.Size(206, 23);
            this.cnpjTb.TabIndex = 44;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnpjTb);
            this.Controls.Add(this.cpfTb);
            this.Controls.Add(this.newBt);
            this.Controls.Add(this.mailLb);
            this.Controls.Add(this.mailTb);
            this.Controls.Add(this.foneLb);
            this.Controls.Add(this.foneTb);
            this.Controls.Add(this.endLb);
            this.Controls.Add(this.endTb);
            this.Controls.Add(this.cnpjLb);
            this.Controls.Add(this.cpfLb);
            this.Controls.Add(this.alterarLb);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.confirmBt);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.alterarBt);
            this.Controls.Add(this.novaOrigemLb);
            this.Controls.Add(this.descripLb);
            this.Controls.Add(this.descripTb);
            this.Controls.Add(this.origemLb);
            this.Controls.Add(this.origemTb);
            this.Controls.Add(this.gerenciarOrigensLb);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.voltarCadBt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gerenciarOrigensLb;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button voltarCadBt;
        private System.Windows.Forms.TextBox origemTb;
        private System.Windows.Forms.Label origemLb;
        private System.Windows.Forms.Label descripLb;
        private System.Windows.Forms.TextBox descripTb;
        private System.Windows.Forms.Label novaOrigemLb;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button alterarBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button confirmBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Label alterarLb;
        private System.Windows.Forms.Label cpfLb;
        private System.Windows.Forms.Label cnpjLb;
        private System.Windows.Forms.Label mailLb;
        private System.Windows.Forms.TextBox mailTb;
        private System.Windows.Forms.Label foneLb;
        private System.Windows.Forms.TextBox foneTb;
        private System.Windows.Forms.Label endLb;
        private System.Windows.Forms.TextBox endTb;
        private System.Windows.Forms.Button newBt;
        private System.Windows.Forms.MaskedTextBox cpfTb;
        private System.Windows.Forms.MaskedTextBox cnpjTb;
    }
}