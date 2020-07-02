namespace ProjetoPI
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCadAlunos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCadFunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btTurmas = new System.Windows.Forms.Button();
            this.btAnivers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRestricoes = new System.Windows.Forms.Button();
            this.bbtValores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadAlunos
            // 
            this.btCadAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadAlunos.Location = new System.Drawing.Point(230, 122);
            this.btCadAlunos.Name = "btCadAlunos";
            this.btCadAlunos.Size = new System.Drawing.Size(173, 52);
            this.btCadAlunos.TabIndex = 0;
            this.btCadAlunos.Text = "Alunos";
            this.btCadAlunos.UseVisualStyleBackColor = true;
            this.btCadAlunos.Click += new System.EventHandler(this.btCadAlunos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoPI.Properties.Resources.Coruja;
            this.pictureBox1.Location = new System.Drawing.Point(43, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btCadFunc
            // 
            this.btCadFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadFunc.Location = new System.Drawing.Point(230, 194);
            this.btCadFunc.Name = "btCadFunc";
            this.btCadFunc.Size = new System.Drawing.Size(173, 52);
            this.btCadFunc.TabIndex = 2;
            this.btCadFunc.Text = "Funcionários";
            this.btCadFunc.UseVisualStyleBackColor = true;
            this.btCadFunc.Click += new System.EventHandler(this.btCadFunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Software desenvolvido por Unitech - (19) 99999-9999";
            // 
            // btTurmas
            // 
            this.btTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTurmas.Location = new System.Drawing.Point(230, 264);
            this.btTurmas.Name = "btTurmas";
            this.btTurmas.Size = new System.Drawing.Size(173, 52);
            this.btTurmas.TabIndex = 6;
            this.btTurmas.Text = "Turmas";
            this.btTurmas.UseVisualStyleBackColor = true;
            this.btTurmas.Click += new System.EventHandler(this.btTurmas_Click);
            // 
            // btAnivers
            // 
            this.btAnivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnivers.Location = new System.Drawing.Point(444, 122);
            this.btAnivers.Name = "btAnivers";
            this.btAnivers.Size = new System.Drawing.Size(173, 52);
            this.btAnivers.TabIndex = 7;
            this.btAnivers.Text = "Aniversariantes";
            this.btAnivers.UseVisualStyleBackColor = true;
            this.btAnivers.Click += new System.EventHandler(this.btAnivers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bradley Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 74);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cadastro /\r\nConsulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Relatórios";
            // 
            // btRestricoes
            // 
            this.btRestricoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestricoes.Location = new System.Drawing.Point(444, 194);
            this.btRestricoes.Name = "btRestricoes";
            this.btRestricoes.Size = new System.Drawing.Size(173, 52);
            this.btRestricoes.TabIndex = 11;
            this.btRestricoes.Text = "Restrições";
            this.btRestricoes.UseVisualStyleBackColor = true;
            this.btRestricoes.Click += new System.EventHandler(this.btRestricoes_Click);
            // 
            // bbtValores
            // 
            this.bbtValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtValores.Location = new System.Drawing.Point(444, 264);
            this.bbtValores.Name = "bbtValores";
            this.bbtValores.Size = new System.Drawing.Size(173, 52);
            this.bbtValores.TabIndex = 12;
            this.bbtValores.Text = "Mensalidades Pagas";
            this.bbtValores.UseVisualStyleBackColor = true;
            this.bbtValores.Click += new System.EventHandler(this.bbtValores_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(685, 404);
            this.Controls.Add(this.bbtValores);
            this.Controls.Add(this.btRestricoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAnivers);
            this.Controls.Add(this.btTurmas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadFunc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCadAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Colégio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadAlunos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCadFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTurmas;
        private System.Windows.Forms.Button btAnivers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRestricoes;
        private System.Windows.Forms.Button bbtValores;
    }
}

