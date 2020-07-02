namespace ControleDoações
{
    partial class Saída
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
            this.dinheiroSaidaLb = new System.Windows.Forms.Label();
            this.saldoSaidaLb = new System.Windows.Forms.Label();
            this.saidaLb = new System.Windows.Forms.Label();
            this.sendSaidaBt = new System.Windows.Forms.Button();
            this.voltarSaidaBt = new System.Windows.Forms.Button();
            this.saqueTb = new System.Windows.Forms.TextBox();
            this.saqueLb = new System.Windows.Forms.Label();
            this.descripLb = new System.Windows.Forms.Label();
            this.descripTb = new System.Windows.Forms.TextBox();
            this.newLb = new System.Windows.Forms.Label();
            this.deleteBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alterarBt = new System.Windows.Forms.Button();
            this.saveBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.alterarLb = new System.Windows.Forms.Label();
            this.tipoLb = new System.Windows.Forms.Label();
            this.respLb = new System.Windows.Forms.Label();
            this.notaTb = new System.Windows.Forms.TextBox();
            this.notaLb = new System.Windows.Forms.Label();
            this.tipoDp = new System.Windows.Forms.ComboBox();
            this.respDp = new System.Windows.Forms.ComboBox();
            this.newBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dinheiroSaidaLb
            // 
            this.dinheiroSaidaLb.AutoSize = true;
            this.dinheiroSaidaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinheiroSaidaLb.Location = new System.Drawing.Point(386, 156);
            this.dinheiroSaidaLb.Name = "dinheiroSaidaLb";
            this.dinheiroSaidaLb.Size = new System.Drawing.Size(79, 25);
            this.dinheiroSaidaLb.TabIndex = 17;
            this.dinheiroSaidaLb.Text = "R$ 0,00";
            // 
            // saldoSaidaLb
            // 
            this.saldoSaidaLb.AutoSize = true;
            this.saldoSaidaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoSaidaLb.Location = new System.Drawing.Point(310, 156);
            this.saldoSaidaLb.Name = "saldoSaidaLb";
            this.saldoSaidaLb.Size = new System.Drawing.Size(69, 25);
            this.saldoSaidaLb.TabIndex = 16;
            this.saldoSaidaLb.Text = "Saldo:";
            // 
            // saidaLb
            // 
            this.saidaLb.AutoSize = true;
            this.saidaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.saidaLb.Location = new System.Drawing.Point(328, 76);
            this.saidaLb.Name = "saidaLb";
            this.saidaLb.Size = new System.Drawing.Size(142, 46);
            this.saidaLb.TabIndex = 15;
            this.saidaLb.Text = "Saídas";
            // 
            // sendSaidaBt
            // 
            this.sendSaidaBt.Location = new System.Drawing.Point(281, 384);
            this.sendSaidaBt.Name = "sendSaidaBt";
            this.sendSaidaBt.Size = new System.Drawing.Size(116, 39);
            this.sendSaidaBt.TabIndex = 14;
            this.sendSaidaBt.Text = "Enviar";
            this.sendSaidaBt.UseVisualStyleBackColor = true;
            this.sendSaidaBt.Click += new System.EventHandler(this.sendSaidaBt_Click);
            // 
            // voltarSaidaBt
            // 
            this.voltarSaidaBt.Location = new System.Drawing.Point(12, 12);
            this.voltarSaidaBt.Name = "voltarSaidaBt";
            this.voltarSaidaBt.Size = new System.Drawing.Size(75, 23);
            this.voltarSaidaBt.TabIndex = 12;
            this.voltarSaidaBt.Text = "Voltar";
            this.voltarSaidaBt.UseVisualStyleBackColor = true;
            this.voltarSaidaBt.Click += new System.EventHandler(this.voltarSaidaBt_Click);
            // 
            // saqueTb
            // 
            this.saqueTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saqueTb.Location = new System.Drawing.Point(242, 257);
            this.saqueTb.Name = "saqueTb";
            this.saqueTb.Size = new System.Drawing.Size(126, 23);
            this.saqueTb.TabIndex = 18;
            this.saqueTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.saqueTb_KeyPress);
            // 
            // saqueLb
            // 
            this.saqueLb.AutoSize = true;
            this.saqueLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saqueLb.Location = new System.Drawing.Point(115, 260);
            this.saqueLb.Name = "saqueLb";
            this.saqueLb.Size = new System.Drawing.Size(121, 17);
            this.saqueLb.TabIndex = 19;
            this.saqueLb.Text = "Valor a retirar: R$";
            // 
            // descripLb
            // 
            this.descripLb.AutoSize = true;
            this.descripLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descripLb.Location = new System.Drawing.Point(161, 330);
            this.descripLb.Name = "descripLb";
            this.descripLb.Size = new System.Drawing.Size(75, 17);
            this.descripLb.TabIndex = 21;
            this.descripLb.Text = "Descrição:";
            // 
            // descripTb
            // 
            this.descripTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descripTb.Location = new System.Drawing.Point(242, 327);
            this.descripTb.Name = "descripTb";
            this.descripTb.Size = new System.Drawing.Size(411, 23);
            this.descripTb.TabIndex = 20;
            this.descripTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripTb_KeyPress);
            // 
            // newLb
            // 
            this.newLb.AutoSize = true;
            this.newLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newLb.Location = new System.Drawing.Point(343, 208);
            this.newLb.Name = "newLb";
            this.newLb.Size = new System.Drawing.Size(114, 25);
            this.newLb.TabIndex = 27;
            this.newLb.Text = "Nova Saída";
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(463, 384);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(116, 39);
            this.deleteBt.TabIndex = 31;
            this.deleteBt.Text = "Apagar";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(738, 168);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // alterarBt
            // 
            this.alterarBt.Location = new System.Drawing.Point(341, 384);
            this.alterarBt.Name = "alterarBt";
            this.alterarBt.Size = new System.Drawing.Size(116, 39);
            this.alterarBt.TabIndex = 33;
            this.alterarBt.Text = "Alterar";
            this.alterarBt.UseVisualStyleBackColor = true;
            this.alterarBt.Click += new System.EventHandler(this.alterarBt_Click);
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(281, 384);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(116, 39);
            this.saveBt.TabIndex = 34;
            this.saveBt.Text = "Salvar";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(403, 384);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(116, 39);
            this.cancelBt.TabIndex = 35;
            this.cancelBt.Text = "Cancelar";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // alterarLb
            // 
            this.alterarLb.AutoSize = true;
            this.alterarLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.alterarLb.Location = new System.Drawing.Point(338, 208);
            this.alterarLb.Name = "alterarLb";
            this.alterarLb.Size = new System.Drawing.Size(125, 25);
            this.alterarLb.TabIndex = 36;
            this.alterarLb.Text = "Alterar Saída";
            // 
            // tipoLb
            // 
            this.tipoLb.AutoSize = true;
            this.tipoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tipoLb.Location = new System.Drawing.Point(118, 295);
            this.tipoLb.Name = "tipoLb";
            this.tipoLb.Size = new System.Drawing.Size(118, 17);
            this.tipoLb.TabIndex = 38;
            this.tipoLb.Text = "Tipo da despesa:";
            // 
            // respLb
            // 
            this.respLb.AutoSize = true;
            this.respLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.respLb.Location = new System.Drawing.Point(427, 260);
            this.respLb.Name = "respLb";
            this.respLb.Size = new System.Drawing.Size(94, 17);
            this.respLb.TabIndex = 19;
            this.respLb.Text = "Responsável:";
            // 
            // notaTb
            // 
            this.notaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notaTb.Location = new System.Drawing.Point(527, 292);
            this.notaTb.Name = "notaTb";
            this.notaTb.Size = new System.Drawing.Size(126, 23);
            this.notaTb.TabIndex = 37;
            // 
            // notaLb
            // 
            this.notaLb.AutoSize = true;
            this.notaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notaLb.Location = new System.Drawing.Point(439, 295);
            this.notaLb.Name = "notaLb";
            this.notaLb.Size = new System.Drawing.Size(82, 17);
            this.notaLb.TabIndex = 38;
            this.notaLb.Text = "Nota Fiscal:";
            // 
            // tipoDp
            // 
            this.tipoDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tipoDp.FormattingEnabled = true;
            this.tipoDp.Items.AddRange(new object[] {
            "Fixa",
            "Variável"});
            this.tipoDp.Location = new System.Drawing.Point(242, 292);
            this.tipoDp.Name = "tipoDp";
            this.tipoDp.Size = new System.Drawing.Size(126, 24);
            this.tipoDp.TabIndex = 39;
            // 
            // respDp
            // 
            this.respDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.respDp.FormattingEnabled = true;
            this.respDp.Items.AddRange(new object[] {
            "Fixa",
            "Variável"});
            this.respDp.Location = new System.Drawing.Point(527, 257);
            this.respDp.Name = "respDp";
            this.respDp.Size = new System.Drawing.Size(126, 24);
            this.respDp.TabIndex = 40;
            // 
            // newBt
            // 
            this.newBt.Location = new System.Drawing.Point(219, 384);
            this.newBt.Name = "newBt";
            this.newBt.Size = new System.Drawing.Size(116, 39);
            this.newBt.TabIndex = 41;
            this.newBt.Text = "Nova Saída";
            this.newBt.UseVisualStyleBackColor = true;
            this.newBt.Click += new System.EventHandler(this.newBt_Click);
            // 
            // Saída
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newBt);
            this.Controls.Add(this.respDp);
            this.Controls.Add(this.tipoDp);
            this.Controls.Add(this.notaLb);
            this.Controls.Add(this.tipoLb);
            this.Controls.Add(this.notaTb);
            this.Controls.Add(this.alterarLb);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.alterarBt);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.newLb);
            this.Controls.Add(this.descripLb);
            this.Controls.Add(this.respLb);
            this.Controls.Add(this.descripTb);
            this.Controls.Add(this.saqueLb);
            this.Controls.Add(this.saqueTb);
            this.Controls.Add(this.dinheiroSaidaLb);
            this.Controls.Add(this.saldoSaidaLb);
            this.Controls.Add(this.saidaLb);
            this.Controls.Add(this.sendSaidaBt);
            this.Controls.Add(this.voltarSaidaBt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Saída";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dinheiroSaidaLb;
        private System.Windows.Forms.Label saldoSaidaLb;
        private System.Windows.Forms.Label saidaLb;
        private System.Windows.Forms.Button sendSaidaBt;
        private System.Windows.Forms.Button voltarSaidaBt;
        private System.Windows.Forms.TextBox saqueTb;
        private System.Windows.Forms.Label saqueLb;
        private System.Windows.Forms.Label descripLb;
        private System.Windows.Forms.TextBox descripTb;
        private System.Windows.Forms.Label newLb;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button alterarBt;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Label alterarLb;
        private System.Windows.Forms.Label tipoLb;
        private System.Windows.Forms.Label respLb;
        private System.Windows.Forms.TextBox notaTb;
        private System.Windows.Forms.Label notaLb;
        private System.Windows.Forms.ComboBox tipoDp;
        private System.Windows.Forms.ComboBox respDp;
        private System.Windows.Forms.Button newBt;
    }
}