namespace AutoEscola
{
    partial class CadastroAgenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAgenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.txtObservação = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.data_hora = new System.Windows.Forms.DateTimePicker();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastro = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridAgenda = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label30);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 53);
            this.panel1.TabIndex = 24;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(200, 33);
            this.label30.TabIndex = 2;
            this.label30.Text = "Cadastro de Aula";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Gold;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(677, 159);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(127, 39);
            this.btFechar.TabIndex = 38;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // txtObservação
            // 
            this.txtObservação.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservação.Location = new System.Drawing.Point(259, 92);
            this.txtObservação.Name = "txtObservação";
            this.txtObservação.Size = new System.Drawing.Size(373, 27);
            this.txtObservação.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Observação:";
            // 
            // data_hora
            // 
            this.data_hora.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_hora.Location = new System.Drawing.Point(259, 260);
            this.data_hora.Name = "data_hora";
            this.data_hora.Size = new System.Drawing.Size(280, 27);
            this.data_hora.TabIndex = 35;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(259, 227);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(200, 27);
            this.txtPlaca.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Data/Hora:";
            // 
            // cbModelo
            // 
            this.cbModelo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(259, 193);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(200, 28);
            this.cbModelo.TabIndex = 31;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Veículo:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(259, 159);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(373, 28);
            this.cbFuncionario.TabIndex = 29;
            this.cbFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbFuncionario_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Funcionário:";
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.Color.Gold;
            this.btCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastro.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.Location = new System.Drawing.Point(677, 92);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(127, 39);
            this.btCadastro.TabIndex = 27;
            this.btCadastro.Text = "Cadastrar";
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(259, 125);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(373, 28);
            this.cbCliente.TabIndex = 26;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cliente:";
            // 
            // dtGridAgenda
            // 
            this.dtGridAgenda.AllowUserToAddRows = false;
            this.dtGridAgenda.AllowUserToDeleteRows = false;
            this.dtGridAgenda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridAgenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridAgenda.EnableHeadersVisualStyles = false;
            this.dtGridAgenda.GridColor = System.Drawing.SystemColors.Control;
            this.dtGridAgenda.Location = new System.Drawing.Point(18, 309);
            this.dtGridAgenda.Name = "dtGridAgenda";
            this.dtGridAgenda.ReadOnly = true;
            this.dtGridAgenda.RowHeadersVisible = false;
            this.dtGridAgenda.Size = new System.Drawing.Size(730, 230);
            this.dtGridAgenda.TabIndex = 51;
            // 
            // CadastroAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 551);
            this.Controls.Add(this.dtGridAgenda);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.txtObservação);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data_hora);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroAgenda";
            this.Load += new System.EventHandler(this.CadastroAgenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.TextBox txtObservação;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker data_hora;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridAgenda;
    }
}