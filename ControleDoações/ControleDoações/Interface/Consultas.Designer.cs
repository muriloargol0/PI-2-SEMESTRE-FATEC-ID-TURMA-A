namespace ControleDoações
{
    partial class Consultas
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
            this.consultLb = new System.Windows.Forms.Label();
            this.histAltBt = new System.Windows.Forms.Button();
            this.histMovBt = new System.Windows.Forms.Button();
            this.voltarConsBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consultLb
            // 
            this.consultLb.AutoSize = true;
            this.consultLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.consultLb.Location = new System.Drawing.Point(303, 75);
            this.consultLb.Name = "consultLb";
            this.consultLb.Size = new System.Drawing.Size(198, 46);
            this.consultLb.TabIndex = 9;
            this.consultLb.Text = "Consultas";
            // 
            // histAltBt
            // 
            this.histAltBt.Location = new System.Drawing.Point(326, 311);
            this.histAltBt.Name = "histAltBt";
            this.histAltBt.Size = new System.Drawing.Size(153, 39);
            this.histAltBt.TabIndex = 8;
            this.histAltBt.Text = "Histórico de Alterações";
            this.histAltBt.UseVisualStyleBackColor = true;
            this.histAltBt.Click += new System.EventHandler(this.histAltBt_Click);
            // 
            // histMovBt
            // 
            this.histMovBt.Location = new System.Drawing.Point(326, 244);
            this.histMovBt.Name = "histMovBt";
            this.histMovBt.Size = new System.Drawing.Size(153, 39);
            this.histMovBt.TabIndex = 7;
            this.histMovBt.Text = "Histórico de Movimentações";
            this.histMovBt.UseVisualStyleBackColor = true;
            this.histMovBt.Click += new System.EventHandler(this.histMovBt_Click);
            // 
            // voltarConsBt
            // 
            this.voltarConsBt.Location = new System.Drawing.Point(12, 12);
            this.voltarConsBt.Name = "voltarConsBt";
            this.voltarConsBt.Size = new System.Drawing.Size(75, 23);
            this.voltarConsBt.TabIndex = 5;
            this.voltarConsBt.Text = "Voltar";
            this.voltarConsBt.UseVisualStyleBackColor = true;
            this.voltarConsBt.Click += new System.EventHandler(this.voltarConsBt_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consultLb);
            this.Controls.Add(this.histAltBt);
            this.Controls.Add(this.histMovBt);
            this.Controls.Add(this.voltarConsBt);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consultLb;
        private System.Windows.Forms.Button histAltBt;
        private System.Windows.Forms.Button histMovBt;
        private System.Windows.Forms.Button voltarConsBt;
    }
}