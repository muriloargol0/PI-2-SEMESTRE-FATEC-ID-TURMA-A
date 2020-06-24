namespace AutoEscola
{
    partial class ConsultaAgendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAgendar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btTodos = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btAtt = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.dtGridAgenda = new System.Windows.Forms.DataGridView();
            this.txtObservação = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.data_hora = new System.Windows.Forms.DateTimePicker();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtCliente = new System.Windows.Forms.ComboBox();
            this.txtFuncionario = new System.Windows.Forms.ComboBox();
            this.txtVeiculo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1252, 53);
            this.panel1.TabIndex = 25;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(232, 33);
            this.label30.TabIndex = 2;
            this.label30.Text = "Consulta da Agenda";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtInicio);
            this.panel2.Controls.Add(this.dtFim);
            this.panel2.Controls.Add(this.cbFuncionario);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btTodos);
            this.panel2.Controls.Add(this.cbCliente);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btPesquisar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 96);
            this.panel2.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Fim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Inicio:";
            // 
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Location = new System.Drawing.Point(112, 54);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(340, 27);
            this.dtInicio.TabIndex = 77;
            this.dtInicio.Value = new System.DateTime(2020, 6, 15, 0, 0, 0, 0);
            // 
            // dtFim
            // 
            this.dtFim.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Location = new System.Drawing.Point(662, 54);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(340, 27);
            this.dtFim.TabIndex = 78;
            this.dtFim.Value = new System.DateTime(2020, 6, 15, 23, 59, 0, 0);
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(662, 10);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(392, 28);
            this.cbFuncionario.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(541, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Funcionário:";
            // 
            // btTodos
            // 
            this.btTodos.BackColor = System.Drawing.Color.Gold;
            this.btTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTodos.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTodos.Location = new System.Drawing.Point(1100, 50);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(100, 31);
            this.btTodos.TabIndex = 33;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = false;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(112, 11);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(423, 28);
            this.cbCliente.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cliente:";
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Gold;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(1101, 10);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(100, 31);
            this.btPesquisar.TabIndex = 30;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btAtt
            // 
            this.btAtt.BackColor = System.Drawing.Color.Gold;
            this.btAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtt.Location = new System.Drawing.Point(1102, 195);
            this.btAtt.Name = "btAtt";
            this.btAtt.Size = new System.Drawing.Size(100, 31);
            this.btAtt.TabIndex = 61;
            this.btAtt.Text = "Atualizar";
            this.btAtt.UseVisualStyleBackColor = false;
            this.btAtt.Click += new System.EventHandler(this.btAtt_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Gold;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(1102, 232);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 31);
            this.btExcluir.TabIndex = 60;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Gold;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(1102, 269);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(100, 31);
            this.btFechar.TabIndex = 51;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
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
            this.dtGridAgenda.Location = new System.Drawing.Point(10, 309);
            this.dtGridAgenda.Name = "dtGridAgenda";
            this.dtGridAgenda.ReadOnly = true;
            this.dtGridAgenda.RowHeadersVisible = false;
            this.dtGridAgenda.Size = new System.Drawing.Size(1230, 230);
            this.dtGridAgenda.TabIndex = 50;
            this.dtGridAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAgenda_CellContentClick);
            // 
            // txtObservação
            // 
            this.txtObservação.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservação.Location = new System.Drawing.Point(121, 155);
            this.txtObservação.Name = "txtObservação";
            this.txtObservação.Size = new System.Drawing.Size(373, 27);
            this.txtObservação.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Observação:";
            // 
            // data_hora
            // 
            this.data_hora.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_hora.Location = new System.Drawing.Point(725, 220);
            this.data_hora.Name = "data_hora";
            this.data_hora.Size = new System.Drawing.Size(340, 27);
            this.data_hora.TabIndex = 71;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(725, 186);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(233, 27);
            this.txtPlaca.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(659, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Data/Hora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Veículo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Funcionário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "Cliente:";
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.Gold;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(1101, 158);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(100, 31);
            this.btPrint.TabIndex = 77;
            this.btPrint.Text = "Imprimir";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.FormattingEnabled = true;
            this.txtCliente.Location = new System.Drawing.Point(121, 188);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(492, 28);
            this.txtCliente.TabIndex = 81;
            this.txtCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionario.FormattingEnabled = true;
            this.txtFuncionario.Location = new System.Drawing.Point(121, 222);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(492, 28);
            this.txtFuncionario.TabIndex = 82;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVeiculo.FormattingEnabled = true;
            this.txtVeiculo.Location = new System.Drawing.Point(725, 155);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(233, 28);
            this.txtVeiculo.TabIndex = 81;
            // 
            // ConsultaAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 551);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.txtObservação);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data_hora);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btAtt);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.dtGridAgenda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaAgendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaAgendar";
            this.Load += new System.EventHandler(this.ConsultaAgendar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btAtt;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.DataGridView dtGridAgenda;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservação;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker data_hora;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox txtCliente;
        private System.Windows.Forms.ComboBox txtFuncionario;
        private System.Windows.Forms.ComboBox txtVeiculo;
    }
}