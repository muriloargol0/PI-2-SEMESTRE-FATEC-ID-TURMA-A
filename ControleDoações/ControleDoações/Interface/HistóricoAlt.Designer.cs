namespace ControleDoações
{
    partial class HistóricoAlt
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
            this.histOrgmLb = new System.Windows.Forms.Label();
            this.imprimirHistOrgmBt = new System.Windows.Forms.Button();
            this.voltarHistOrgmBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // histOrgmLb
            // 
            this.histOrgmLb.AutoSize = true;
            this.histOrgmLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.histOrgmLb.Location = new System.Drawing.Point(186, 29);
            this.histOrgmLb.Name = "histOrgmLb";
            this.histOrgmLb.Size = new System.Drawing.Size(434, 46);
            this.histOrgmLb.TabIndex = 17;
            this.histOrgmLb.Text = "Histórico de Alterações";
            // 
            // imprimirHistOrgmBt
            // 
            this.imprimirHistOrgmBt.Location = new System.Drawing.Point(655, 399);
            this.imprimirHistOrgmBt.Name = "imprimirHistOrgmBt";
            this.imprimirHistOrgmBt.Size = new System.Drawing.Size(133, 39);
            this.imprimirHistOrgmBt.TabIndex = 16;
            this.imprimirHistOrgmBt.Text = "Imprimir";
            this.imprimirHistOrgmBt.UseVisualStyleBackColor = true;
            // 
            // voltarHistOrgmBt
            // 
            this.voltarHistOrgmBt.Location = new System.Drawing.Point(12, 12);
            this.voltarHistOrgmBt.Name = "voltarHistOrgmBt";
            this.voltarHistOrgmBt.Size = new System.Drawing.Size(75, 23);
            this.voltarHistOrgmBt.TabIndex = 15;
            this.voltarHistOrgmBt.Text = "Voltar";
            this.voltarHistOrgmBt.UseVisualStyleBackColor = true;
            this.voltarHistOrgmBt.Click += new System.EventHandler(this.voltarHistOrgmBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(184, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 307);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HistóricoPorOrigem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.histOrgmLb);
            this.Controls.Add(this.imprimirHistOrgmBt);
            this.Controls.Add(this.voltarHistOrgmBt);
            this.Name = "HistóricoPorOrigem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label histOrgmLb;
        private System.Windows.Forms.Button imprimirHistOrgmBt;
        private System.Windows.Forms.Button voltarHistOrgmBt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}