namespace ControleDoações
{
    partial class HistóricoMov
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
            this.histDataLb = new System.Windows.Forms.Label();
            this.printBt = new System.Windows.Forms.Button();
            this.voltarHistDataBt = new System.Windows.Forms.Button();
            this.tabelaMov = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMov)).BeginInit();
            this.SuspendLayout();
            // 
            // histDataLb
            // 
            this.histDataLb.AutoSize = true;
            this.histDataLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.histDataLb.Location = new System.Drawing.Point(136, 29);
            this.histDataLb.Name = "histDataLb";
            this.histDataLb.Size = new System.Drawing.Size(524, 46);
            this.histDataLb.TabIndex = 13;
            this.histDataLb.Text = "Histórico de Movimentações";
            // 
            // printBt
            // 
            this.printBt.Location = new System.Drawing.Point(655, 399);
            this.printBt.Name = "printBt";
            this.printBt.Size = new System.Drawing.Size(133, 39);
            this.printBt.TabIndex = 11;
            this.printBt.Text = "Imprimir";
            this.printBt.UseVisualStyleBackColor = true;
            // 
            // voltarHistDataBt
            // 
            this.voltarHistDataBt.Location = new System.Drawing.Point(12, 12);
            this.voltarHistDataBt.Name = "voltarHistDataBt";
            this.voltarHistDataBt.Size = new System.Drawing.Size(75, 23);
            this.voltarHistDataBt.TabIndex = 10;
            this.voltarHistDataBt.Text = "Voltar";
            this.voltarHistDataBt.UseVisualStyleBackColor = true;
            this.voltarHistDataBt.Click += new System.EventHandler(this.voltarHistDataBt_Click);
            // 
            // tabelaMov
            // 
            this.tabelaMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaMov.Location = new System.Drawing.Point(12, 84);
            this.tabelaMov.Name = "tabelaMov";
            this.tabelaMov.Size = new System.Drawing.Size(776, 307);
            this.tabelaMov.TabIndex = 20;
            this.tabelaMov.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tabelaMov_CellFormatting);
            this.tabelaMov.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.tabelaMov_DataBindingComplete);
            // 
            // HistóricoMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabelaMov);
            this.Controls.Add(this.histDataLb);
            this.Controls.Add(this.printBt);
            this.Controls.Add(this.voltarHistDataBt);
            this.Name = "HistóricoMov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label histDataLb;
        private System.Windows.Forms.Button printBt;
        private System.Windows.Forms.Button voltarHistDataBt;
        private System.Windows.Forms.DataGridView tabelaMov;
    }
}