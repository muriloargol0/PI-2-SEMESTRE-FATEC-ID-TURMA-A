namespace ControleDoações
{
    partial class Entrada
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
            this.dinheiroEntradaLb = new System.Windows.Forms.Label();
            this.saldoEntradaLb = new System.Windows.Forms.Label();
            this.entradaLb = new System.Windows.Forms.Label();
            this.voltarEntradaBt = new System.Windows.Forms.Button();
            this.depositLb = new System.Windows.Forms.Label();
            this.depositTb = new System.Windows.Forms.TextBox();
            this.sendEntradaBt = new System.Windows.Forms.Button();
            this.origemLb = new System.Windows.Forms.Label();
            this.origemDp = new System.Windows.Forms.ComboBox();
            this.newLb = new System.Windows.Forms.Label();
            this.deleteBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descripLb = new System.Windows.Forms.Label();
            this.descripTb = new System.Windows.Forms.TextBox();
            this.alterarBt = new System.Windows.Forms.Button();
            this.alterarLb = new System.Windows.Forms.Label();
            this.saveBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.respLb = new System.Windows.Forms.Label();
            this.notaLb = new System.Windows.Forms.Label();
            this.notaTb = new System.Windows.Forms.TextBox();
            this.respDp = new System.Windows.Forms.ComboBox();
            this.newBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dinheiroEntradaLb
            // 
            this.dinheiroEntradaLb.AutoSize = true;
            this.dinheiroEntradaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinheiroEntradaLb.Location = new System.Drawing.Point(386, 156);
            this.dinheiroEntradaLb.Name = "dinheiroEntradaLb";
            this.dinheiroEntradaLb.Size = new System.Drawing.Size(79, 25);
            this.dinheiroEntradaLb.TabIndex = 17;
            this.dinheiroEntradaLb.Text = "R$ 0,00";
            // 
            // saldoEntradaLb
            // 
            this.saldoEntradaLb.AutoSize = true;
            this.saldoEntradaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoEntradaLb.Location = new System.Drawing.Point(310, 156);
            this.saldoEntradaLb.Name = "saldoEntradaLb";
            this.saldoEntradaLb.Size = new System.Drawing.Size(69, 25);
            this.saldoEntradaLb.TabIndex = 16;
            this.saldoEntradaLb.Text = "Saldo:";
            // 
            // entradaLb
            // 
            this.entradaLb.AutoSize = true;
            this.entradaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.entradaLb.Location = new System.Drawing.Point(314, 76);
            this.entradaLb.Name = "entradaLb";
            this.entradaLb.Size = new System.Drawing.Size(179, 46);
            this.entradaLb.TabIndex = 19;
            this.entradaLb.Text = "Entradas";
            // 
            // voltarEntradaBt
            // 
            this.voltarEntradaBt.Location = new System.Drawing.Point(12, 12);
            this.voltarEntradaBt.Name = "voltarEntradaBt";
            this.voltarEntradaBt.Size = new System.Drawing.Size(75, 23);
            this.voltarEntradaBt.TabIndex = 18;
            this.voltarEntradaBt.Text = "Voltar";
            this.voltarEntradaBt.UseVisualStyleBackColor = true;
            this.voltarEntradaBt.Click += new System.EventHandler(this.voltarEntradaBt_Click);
            // 
            // depositLb
            // 
            this.depositLb.AutoSize = true;
            this.depositLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.depositLb.Location = new System.Drawing.Point(108, 260);
            this.depositLb.Name = "depositLb";
            this.depositLb.Size = new System.Drawing.Size(142, 17);
            this.depositLb.TabIndex = 22;
            this.depositLb.Text = "Valor a depositar: R$";
            // 
            // depositTb
            // 
            this.depositTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.depositTb.Location = new System.Drawing.Point(256, 257);
            this.depositTb.Name = "depositTb";
            this.depositTb.Size = new System.Drawing.Size(126, 23);
            this.depositTb.TabIndex = 21;
            this.depositTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depositTb_KeyPress);
            // 
            // sendEntradaBt
            // 
            this.sendEntradaBt.Location = new System.Drawing.Point(281, 384);
            this.sendEntradaBt.Name = "sendEntradaBt";
            this.sendEntradaBt.Size = new System.Drawing.Size(116, 39);
            this.sendEntradaBt.TabIndex = 20;
            this.sendEntradaBt.Text = "Enviar";
            this.sendEntradaBt.UseVisualStyleBackColor = true;
            this.sendEntradaBt.Click += new System.EventHandler(this.sendEntradaBt_Click);
            // 
            // origemLb
            // 
            this.origemLb.AutoSize = true;
            this.origemLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.origemLb.Location = new System.Drawing.Point(120, 295);
            this.origemLb.Name = "origemLb";
            this.origemLb.Size = new System.Drawing.Size(130, 17);
            this.origemLb.TabIndex = 24;
            this.origemLb.Text = "Origem do dinhero:";
            // 
            // origemDp
            // 
            this.origemDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.origemDp.FormattingEnabled = true;
            this.origemDp.Location = new System.Drawing.Point(256, 292);
            this.origemDp.Name = "origemDp";
            this.origemDp.Size = new System.Drawing.Size(126, 24);
            this.origemDp.TabIndex = 25;
            // 
            // newLb
            // 
            this.newLb.AutoSize = true;
            this.newLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newLb.Location = new System.Drawing.Point(336, 208);
            this.newLb.Name = "newLb";
            this.newLb.Size = new System.Drawing.Size(131, 25);
            this.newLb.TabIndex = 26;
            this.newLb.Text = "Nova Entrada";
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(463, 384);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(116, 39);
            this.deleteBt.TabIndex = 29;
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
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // descripLb
            // 
            this.descripLb.AutoSize = true;
            this.descripLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descripLb.Location = new System.Drawing.Point(113, 330);
            this.descripLb.Name = "descripLb";
            this.descripLb.Size = new System.Drawing.Size(137, 17);
            this.descripLb.TabIndex = 35;
            this.descripLb.Text = "Formato da entrada:";
            // 
            // descripTb
            // 
            this.descripTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descripTb.Location = new System.Drawing.Point(256, 327);
            this.descripTb.Name = "descripTb";
            this.descripTb.Size = new System.Drawing.Size(126, 23);
            this.descripTb.TabIndex = 34;
            this.descripTb.Text = "Dinheiro";
            this.descripTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descripTb_KeyPress);
            // 
            // alterarBt
            // 
            this.alterarBt.Location = new System.Drawing.Point(341, 384);
            this.alterarBt.Name = "alterarBt";
            this.alterarBt.Size = new System.Drawing.Size(116, 39);
            this.alterarBt.TabIndex = 36;
            this.alterarBt.Text = "Alterar";
            this.alterarBt.UseVisualStyleBackColor = true;
            this.alterarBt.Click += new System.EventHandler(this.alterarBt_Click);
            // 
            // alterarLb
            // 
            this.alterarLb.AutoSize = true;
            this.alterarLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.alterarLb.Location = new System.Drawing.Point(330, 208);
            this.alterarLb.Name = "alterarLb";
            this.alterarLb.Size = new System.Drawing.Size(142, 25);
            this.alterarLb.TabIndex = 37;
            this.alterarLb.Text = "Alterar Entrada";
            // 
            // saveBt
            // 
            this.saveBt.Location = new System.Drawing.Point(281, 384);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(116, 39);
            this.saveBt.TabIndex = 38;
            this.saveBt.Text = "Salvar";
            this.saveBt.UseVisualStyleBackColor = true;
            this.saveBt.Click += new System.EventHandler(this.saveBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(403, 384);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(116, 39);
            this.cancelBt.TabIndex = 39;
            this.cancelBt.Text = "Cancelar";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // respLb
            // 
            this.respLb.AutoSize = true;
            this.respLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.respLb.Location = new System.Drawing.Point(441, 260);
            this.respLb.Name = "respLb";
            this.respLb.Size = new System.Drawing.Size(94, 17);
            this.respLb.TabIndex = 22;
            this.respLb.Text = "Responsável:";
            // 
            // notaLb
            // 
            this.notaLb.AutoSize = true;
            this.notaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notaLb.Location = new System.Drawing.Point(453, 295);
            this.notaLb.Name = "notaLb";
            this.notaLb.Size = new System.Drawing.Size(82, 17);
            this.notaLb.TabIndex = 24;
            this.notaLb.Text = "Nota Fiscal:";
            // 
            // notaTb
            // 
            this.notaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notaTb.Location = new System.Drawing.Point(541, 292);
            this.notaTb.Name = "notaTb";
            this.notaTb.Size = new System.Drawing.Size(126, 23);
            this.notaTb.TabIndex = 21;
            this.notaTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depositTb_KeyPress);
            // 
            // respDp
            // 
            this.respDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.respDp.FormattingEnabled = true;
            this.respDp.Location = new System.Drawing.Point(541, 257);
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
            this.newBt.Text = "Nova Entrada";
            this.newBt.UseVisualStyleBackColor = true;
            this.newBt.Click += new System.EventHandler(this.newBt_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newBt);
            this.Controls.Add(this.respDp);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.alterarLb);
            this.Controls.Add(this.alterarBt);
            this.Controls.Add(this.descripLb);
            this.Controls.Add(this.descripTb);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.newLb);
            this.Controls.Add(this.notaLb);
            this.Controls.Add(this.origemDp);
            this.Controls.Add(this.respLb);
            this.Controls.Add(this.origemLb);
            this.Controls.Add(this.notaTb);
            this.Controls.Add(this.depositLb);
            this.Controls.Add(this.depositTb);
            this.Controls.Add(this.sendEntradaBt);
            this.Controls.Add(this.entradaLb);
            this.Controls.Add(this.voltarEntradaBt);
            this.Controls.Add(this.dinheiroEntradaLb);
            this.Controls.Add(this.saldoEntradaLb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dinheiroEntradaLb;
        private System.Windows.Forms.Label saldoEntradaLb;
        private System.Windows.Forms.Label entradaLb;
        private System.Windows.Forms.Button voltarEntradaBt;
        private System.Windows.Forms.Label depositLb;
        private System.Windows.Forms.TextBox depositTb;
        private System.Windows.Forms.Button sendEntradaBt;
        private System.Windows.Forms.Label origemLb;
        private System.Windows.Forms.ComboBox origemDp;
        private System.Windows.Forms.Label newLb;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label descripLb;
        private System.Windows.Forms.TextBox descripTb;
        private System.Windows.Forms.Button alterarBt;
        private System.Windows.Forms.Label alterarLb;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Label respLb;
        private System.Windows.Forms.Label notaLb;
        private System.Windows.Forms.TextBox notaTb;
        private System.Windows.Forms.ComboBox respDp;
        private System.Windows.Forms.Button newBt;
    }
}