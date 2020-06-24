namespace AutoEscola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btFechar = new System.Windows.Forms.Button();
            this.tbConsulta = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuConsulta1 = new AutoEscola.MenuConsulta();
            this.menuCadastro1 = new AutoEscola.MenuCadastro();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btFechar);
            this.panel1.Controls.Add(this.tbConsulta);
            this.panel1.Controls.Add(this.btCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 502);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Tomato;
            this.SidePanel.Location = new System.Drawing.Point(0, 139);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 51);
            this.SidePanel.TabIndex = 2;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.Location = new System.Drawing.Point(12, 253);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(156, 51);
            this.btFechar.TabIndex = 4;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbConsulta
            // 
            this.tbConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbConsulta.FlatAppearance.BorderSize = 0;
            this.tbConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbConsulta.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsulta.ForeColor = System.Drawing.Color.White;
            this.tbConsulta.Location = new System.Drawing.Point(12, 196);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Size = new System.Drawing.Size(156, 51);
            this.tbConsulta.TabIndex = 2;
            this.tbConsulta.Text = "Consulta";
            this.tbConsulta.UseVisualStyleBackColor = false;
            this.tbConsulta.Click += new System.EventHandler(this.button3_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCadastro.FlatAppearance.BorderSize = 0;
            this.btCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastro.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.ForeColor = System.Drawing.Color.White;
            this.btCadastro.Location = new System.Drawing.Point(12, 139);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(156, 51);
            this.btCadastro.TabIndex = 0;
            this.btCadastro.Text = "Cadastro";
            this.btCadastro.UseVisualStyleBackColor = false;
            this.btCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 73);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Auto Escola Líder";
            // 
            // menuConsulta1
            // 
            this.menuConsulta1.BackColor = System.Drawing.Color.White;
            this.menuConsulta1.Location = new System.Drawing.Point(168, 71);
            this.menuConsulta1.Name = "menuConsulta1";
            this.menuConsulta1.Size = new System.Drawing.Size(763, 431);
            this.menuConsulta1.TabIndex = 6;
            // 
            // menuCadastro1
            // 
            this.menuCadastro1.BackColor = System.Drawing.Color.White;
            this.menuCadastro1.Location = new System.Drawing.Point(168, 71);
            this.menuCadastro1.Name = "menuCadastro1";
            this.menuCadastro1.Size = new System.Drawing.Size(763, 431);
            this.menuCadastro1.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 502);
            this.Controls.Add(this.menuConsulta1);
            this.Controls.Add(this.menuCadastro1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbConsulta;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MenuCadastro menuCadastro1;
        private MenuConsulta menuConsulta1;

    }
}

