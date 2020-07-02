namespace ControleDoações
{
    partial class Registro
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
            this.userTitleLb = new System.Windows.Forms.Label();
            this.voltarRegisterBt = new System.Windows.Forms.Button();
            this.senhaTb = new System.Windows.Forms.TextBox();
            this.userTb = new System.Windows.Forms.TextBox();
            this.senhaLb = new System.Windows.Forms.Label();
            this.userLb = new System.Windows.Forms.Label();
            this.saveBt = new System.Windows.Forms.Button();
            this.confTb = new System.Windows.Forms.TextBox();
            this.confLb = new System.Windows.Forms.Label();
            this.passBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.newUserLb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cpfLb = new System.Windows.Forms.Label();
            this.cpfTb = new System.Windows.Forms.TextBox();
            this.rgTb = new System.Windows.Forms.TextBox();
            this.nomeTb = new System.Windows.Forms.TextBox();
            this.rgLb = new System.Windows.Forms.Label();
            this.nomeLb = new System.Windows.Forms.Label();
            this.accessLb = new System.Windows.Forms.Label();
            this.nascLb = new System.Windows.Forms.Label();
            this.newBt = new System.Windows.Forms.Button();
            this.accessDp = new System.Windows.Forms.ComboBox();
            this.cancelBt = new System.Windows.Forms.Button();
            this.nascTb = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userTitleLb
            // 
            this.userTitleLb.AutoSize = true;
            this.userTitleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.userTitleLb.Location = new System.Drawing.Point(169, 75);
            this.userTitleLb.Name = "userTitleLb";
            this.userTitleLb.Size = new System.Drawing.Size(469, 46);
            this.userTitleLb.TabIndex = 6;
            this.userTitleLb.Text = "Gerenciar Colaboradores";
            // 
            // voltarRegisterBt
            // 
            this.voltarRegisterBt.Location = new System.Drawing.Point(12, 12);
            this.voltarRegisterBt.Name = "voltarRegisterBt";
            this.voltarRegisterBt.Size = new System.Drawing.Size(75, 23);
            this.voltarRegisterBt.TabIndex = 5;
            this.voltarRegisterBt.Text = "Voltar";
            this.voltarRegisterBt.UseVisualStyleBackColor = true;
            this.voltarRegisterBt.Click += new System.EventHandler(this.voltarRegisterBt_Click);
            // 
            // senhaTb
            // 
            this.senhaTb.Location = new System.Drawing.Point(252, 277);
            this.senhaTb.Name = "senhaTb";
            this.senhaTb.Size = new System.Drawing.Size(127, 20);
            this.senhaTb.TabIndex = 18;
            this.senhaTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senhaTb_KeyPress);
            // 
            // userTb
            // 
            this.userTb.Location = new System.Drawing.Point(252, 213);
            this.userTb.Name = "userTb";
            this.userTb.Size = new System.Drawing.Size(127, 20);
            this.userTb.TabIndex = 17;
            this.userTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userTb_KeyPress);
            // 
            // senhaLb
            // 
            this.senhaLb.AutoSize = true;
            this.senhaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.senhaLb.Location = new System.Drawing.Point(193, 278);
            this.senhaLb.Name = "senhaLb";
            this.senhaLb.Size = new System.Drawing.Size(53, 17);
            this.senhaLb.TabIndex = 16;
            this.senhaLb.Text = "Senha:";
            this.senhaLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userLb.Location = new System.Drawing.Point(199, 214);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(47, 17);
            this.userLb.TabIndex = 15;
            this.userLb.Text = "Login:";
            this.userLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(282, 384);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(116, 39);
            this.saveBt.TabIndex = 14;
            this.saveBt.Text = "Salvar Novo Colaborador";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // confTb
            // 
            this.confTb.Location = new System.Drawing.Point(252, 309);
            this.confTb.Name = "confTb";
            this.confTb.Size = new System.Drawing.Size(127, 20);
            this.confTb.TabIndex = 20;
            this.confTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confTb_KeyPress);
            // 
            // confLb
            // 
            this.confLb.AutoSize = true;
            this.confLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.confLb.Location = new System.Drawing.Point(130, 310);
            this.confLb.Name = "confLb";
            this.confLb.Size = new System.Drawing.Size(116, 17);
            this.confLb.TabIndex = 21;
            this.confLb.Text = "Confirmar senha:";
            this.confLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passBt
            // 
            this.passBt.Location = new System.Drawing.Point(343, 384);
            this.passBt.Name = "passBt";
            this.passBt.Size = new System.Drawing.Size(116, 39);
            this.passBt.TabIndex = 23;
            this.passBt.Text = "Trocar senha";
            this.passBt.UseVisualStyleBackColor = true;
            this.passBt.Click += new System.EventHandler(this.passBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(470, 384);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(116, 39);
            this.deleteBt.TabIndex = 24;
            this.deleteBt.Text = "Apagar";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // newUserLb
            // 
            this.newUserLb.AutoSize = true;
            this.newUserLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.newUserLb.Location = new System.Drawing.Point(313, 160);
            this.newUserLb.Name = "newUserLb";
            this.newUserLb.Size = new System.Drawing.Size(188, 26);
            this.newUserLb.TabIndex = 25;
            this.newUserLb.Text = "Novo Colaborador";
            this.newUserLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(639, 216);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // cpfLb
            // 
            this.cpfLb.AutoSize = true;
            this.cpfLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cpfLb.Location = new System.Drawing.Point(474, 278);
            this.cpfLb.Name = "cpfLb";
            this.cpfLb.Size = new System.Drawing.Size(38, 17);
            this.cpfLb.TabIndex = 32;
            this.cpfLb.Text = "CPF:";
            this.cpfLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpfTb
            // 
            this.cpfTb.Location = new System.Drawing.Point(518, 277);
            this.cpfTb.Name = "cpfTb";
            this.cpfTb.Size = new System.Drawing.Size(127, 20);
            this.cpfTb.TabIndex = 31;
            this.cpfTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpfTb_KeyPress);
            // 
            // rgTb
            // 
            this.rgTb.Location = new System.Drawing.Point(518, 245);
            this.rgTb.Name = "rgTb";
            this.rgTb.Size = new System.Drawing.Size(127, 20);
            this.rgTb.TabIndex = 30;
            this.rgTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rgTb_KeyPress);
            // 
            // nomeTb
            // 
            this.nomeTb.Location = new System.Drawing.Point(518, 213);
            this.nomeTb.Name = "nomeTb";
            this.nomeTb.Size = new System.Drawing.Size(127, 20);
            this.nomeTb.TabIndex = 29;
            this.nomeTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeTb_KeyPress);
            // 
            // rgLb
            // 
            this.rgLb.AutoSize = true;
            this.rgLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rgLb.Location = new System.Drawing.Point(479, 246);
            this.rgLb.Name = "rgLb";
            this.rgLb.Size = new System.Drawing.Size(33, 17);
            this.rgLb.TabIndex = 28;
            this.rgLb.Text = "RG:";
            this.rgLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nomeLb
            // 
            this.nomeLb.AutoSize = true;
            this.nomeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomeLb.Location = new System.Drawing.Point(465, 214);
            this.nomeLb.Name = "nomeLb";
            this.nomeLb.Size = new System.Drawing.Size(49, 17);
            this.nomeLb.TabIndex = 27;
            this.nomeLb.Text = "Nome:";
            this.nomeLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accessLb
            // 
            this.accessLb.AutoSize = true;
            this.accessLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.accessLb.Location = new System.Drawing.Point(188, 246);
            this.accessLb.Name = "accessLb";
            this.accessLb.Size = new System.Drawing.Size(58, 17);
            this.accessLb.TabIndex = 34;
            this.accessLb.Text = "Acesso:";
            this.accessLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nascLb
            // 
            this.nascLb.AutoSize = true;
            this.nascLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nascLb.Location = new System.Drawing.Point(410, 310);
            this.nascLb.Name = "nascLb";
            this.nascLb.Size = new System.Drawing.Size(102, 17);
            this.nascLb.TabIndex = 33;
            this.nascLb.Text = "Data de Nasc.:";
            this.nascLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newBt
            // 
            this.newBt.Location = new System.Drawing.Point(217, 384);
            this.newBt.Name = "newBt";
            this.newBt.Size = new System.Drawing.Size(116, 39);
            this.newBt.TabIndex = 37;
            this.newBt.Text = "Novo Colaborador";
            this.newBt.UseVisualStyleBackColor = true;
            this.newBt.Click += new System.EventHandler(this.newBt_Click);
            // 
            // accessDp
            // 
            this.accessDp.FormattingEnabled = true;
            this.accessDp.Items.AddRange(new object[] {
            "Não",
            "Visualizar",
            "Incluir",
            "Alterar-Excluir",
            "Admin"});
            this.accessDp.Location = new System.Drawing.Point(252, 244);
            this.accessDp.Name = "accessDp";
            this.accessDp.Size = new System.Drawing.Size(127, 21);
            this.accessDp.TabIndex = 38;
            this.accessDp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accessDp_KeyPress);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(404, 384);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(116, 39);
            this.cancelBt.TabIndex = 39;
            this.cancelBt.Text = "Cancelar";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // nascTb
            // 
            this.nascTb.Location = new System.Drawing.Point(518, 310);
            this.nascTb.Mask = "00/00/0000";
            this.nascTb.Name = "nascTb";
            this.nascTb.Size = new System.Drawing.Size(127, 20);
            this.nascTb.TabIndex = 40;
            this.nascTb.ValidatingType = typeof(System.DateTime);
            this.nascTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nascTb_KeyPress);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nascTb);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.accessDp);
            this.Controls.Add(this.newBt);
            this.Controls.Add(this.accessLb);
            this.Controls.Add(this.nascLb);
            this.Controls.Add(this.cpfLb);
            this.Controls.Add(this.cpfTb);
            this.Controls.Add(this.rgTb);
            this.Controls.Add(this.nomeTb);
            this.Controls.Add(this.rgLb);
            this.Controls.Add(this.nomeLb);
            this.Controls.Add(this.newUserLb);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.passBt);
            this.Controls.Add(this.confLb);
            this.Controls.Add(this.confTb);
            this.Controls.Add(this.senhaTb);
            this.Controls.Add(this.userTb);
            this.Controls.Add(this.senhaLb);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.userTitleLb);
            this.Controls.Add(this.voltarRegisterBt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userTitleLb;
        private System.Windows.Forms.Button voltarRegisterBt;
        private System.Windows.Forms.TextBox senhaTb;
        private System.Windows.Forms.TextBox userTb;
        private System.Windows.Forms.Label senhaLb;
        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.TextBox confTb;
        private System.Windows.Forms.Label confLb;
        private System.Windows.Forms.Button passBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Label newUserLb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cpfLb;
        private System.Windows.Forms.TextBox cpfTb;
        private System.Windows.Forms.TextBox rgTb;
        private System.Windows.Forms.TextBox nomeTb;
        private System.Windows.Forms.Label rgLb;
        private System.Windows.Forms.Label nomeLb;
        private System.Windows.Forms.Label accessLb;
        private System.Windows.Forms.Label nascLb;
        private System.Windows.Forms.Button newBt;
        private System.Windows.Forms.ComboBox accessDp;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.MaskedTextBox nascTb;
    }
}