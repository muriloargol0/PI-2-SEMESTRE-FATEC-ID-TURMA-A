namespace AutoEscola
{
    partial class ConsultaDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDespesa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGridDespesa = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btTodos = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtt = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDespesa)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label30);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 53);
            this.panel1.TabIndex = 24;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(241, 33);
            this.label30.TabIndex = 2;
            this.label30.Text = "Consulta de Despesa";
            // 
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Location = new System.Drawing.Point(132, 40);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(326, 27);
            this.dtInicio.TabIndex = 25;
            // 
            // dtFim
            // 
            this.dtFim.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Location = new System.Drawing.Point(518, 40);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(324, 27);
            this.dtFim.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Fim:";
            // 
            // dtGridDespesa
            // 
            this.dtGridDespesa.AllowUserToAddRows = false;
            this.dtGridDespesa.AllowUserToDeleteRows = false;
            this.dtGridDespesa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridDespesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridDespesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridDespesa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridDespesa.EnableHeadersVisualStyles = false;
            this.dtGridDespesa.GridColor = System.Drawing.SystemColors.Control;
            this.dtGridDespesa.Location = new System.Drawing.Point(120, 249);
            this.dtGridDespesa.Name = "dtGridDespesa";
            this.dtGridDespesa.ReadOnly = true;
            this.dtGridDespesa.RowHeadersVisible = false;
            this.dtGridDespesa.Size = new System.Drawing.Size(710, 252);
            this.dtGridDespesa.TabIndex = 29;
            this.dtGridDespesa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDespesa_CellContentClick);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Gold;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(857, 5);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(100, 31);
            this.btPesquisar.TabIndex = 30;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // cbModelo
            // 
            this.cbModelo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(132, 6);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(326, 28);
            this.cbModelo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Modelo:";
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Gold;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(858, 256);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(100, 31);
            this.btFechar.TabIndex = 33;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Century", 12F);
            this.date.Location = new System.Drawing.Point(352, 188);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(361, 27);
            this.date.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(292, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Data:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Century", 12F);
            this.txtObservacao.Location = new System.Drawing.Point(133, 190);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(147, 27);
            this.txtObservacao.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Observação:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Century", 12F);
            this.txtValor.Location = new System.Drawing.Point(571, 156);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(142, 27);
            this.txtValor.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(505, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(54, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Modelo:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btTodos);
            this.panel2.Controls.Add(this.cbModelo);
            this.panel2.Controls.Add(this.dtInicio);
            this.panel2.Controls.Add(this.dtFim);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btPesquisar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 85);
            this.panel2.TabIndex = 44;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btTodos
            // 
            this.btTodos.BackColor = System.Drawing.Color.Gold;
            this.btTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTodos.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTodos.Location = new System.Drawing.Point(856, 45);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(100, 31);
            this.btTodos.TabIndex = 33;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = false;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Century", 12F);
            this.txtModelo.Location = new System.Drawing.Point(133, 156);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(147, 27);
            this.txtModelo.TabIndex = 45;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Gold;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(858, 219);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 31);
            this.btExcluir.TabIndex = 46;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtt
            // 
            this.btAtt.BackColor = System.Drawing.Color.Gold;
            this.btAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtt.Location = new System.Drawing.Point(858, 182);
            this.btAtt.Name = "btAtt";
            this.btAtt.Size = new System.Drawing.Size(100, 31);
            this.btAtt.TabIndex = 47;
            this.btAtt.Text = "Atualizar";
            this.btAtt.UseVisualStyleBackColor = false;
            this.btAtt.Click += new System.EventHandler(this.btAtt_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Century", 12F);
            this.txtPlaca.Location = new System.Drawing.Point(352, 155);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(147, 27);
            this.txtPlaca.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(286, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Placa:";
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.Gold;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(857, 145);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(100, 31);
            this.btPrint.TabIndex = 50;
            this.btPrint.Text = "Imprimir";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ConsultaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 524);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btAtt);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtGridDespesa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaDespesa";
            this.Load += new System.EventHandler(this.ConsultaDespesa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDespesa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtGridDespesa;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtt;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}