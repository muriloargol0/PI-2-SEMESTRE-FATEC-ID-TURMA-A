namespace AppPibOM.Forms
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.Painel_Home = new System.Windows.Forms.Panel();
            this.botaoProHome = new FontAwesome.Sharp.IconButton();
            this.botaoTreHome = new FontAwesome.Sharp.IconButton();
            this.botaoFunHome = new FontAwesome.Sharp.IconButton();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Painel_Home.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Home
            // 
            this.Painel_Home.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Painel_Home.Controls.Add(this.botaoProHome);
            this.Painel_Home.Controls.Add(this.botaoTreHome);
            this.Painel_Home.Controls.Add(this.botaoFunHome);
            this.Painel_Home.Controls.Add(this.lblDia);
            this.Painel_Home.Controls.Add(this.lblData);
            this.Painel_Home.Controls.Add(this.lblSegundos);
            this.Painel_Home.Controls.Add(this.lblHora);
            this.Painel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Home.Location = new System.Drawing.Point(0, 0);
            this.Painel_Home.Name = "Painel_Home";
            this.Painel_Home.Size = new System.Drawing.Size(1044, 597);
            this.Painel_Home.TabIndex = 0;
            this.Painel_Home.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Home_Paint);
            this.Painel_Home.Enter += new System.EventHandler(this.Painel_Home_Enter);
            // 
            // botaoProHome
            // 
            this.botaoProHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoProHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botaoProHome.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.botaoProHome.IconColor = System.Drawing.Color.Black;
            this.botaoProHome.IconSize = 64;
            this.botaoProHome.Location = new System.Drawing.Point(464, 64);
            this.botaoProHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botaoProHome.Name = "botaoProHome";
            this.botaoProHome.Rotation = 0D;
            this.botaoProHome.Size = new System.Drawing.Size(148, 110);
            this.botaoProHome.TabIndex = 13;
            this.botaoProHome.Text = "0 Projetos Cadastrados";
            this.botaoProHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botaoProHome.UseVisualStyleBackColor = true;
            this.botaoProHome.Click += new System.EventHandler(this.botaoProHome_Click);
            // 
            // botaoTreHome
            // 
            this.botaoTreHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoTreHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botaoTreHome.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.botaoTreHome.IconColor = System.Drawing.Color.Black;
            this.botaoTreHome.IconSize = 64;
            this.botaoTreHome.Location = new System.Drawing.Point(277, 64);
            this.botaoTreHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botaoTreHome.Name = "botaoTreHome";
            this.botaoTreHome.Rotation = 0D;
            this.botaoTreHome.Size = new System.Drawing.Size(148, 110);
            this.botaoTreHome.TabIndex = 12;
            this.botaoTreHome.Text = "0 Treinamentos Cadastrados";
            this.botaoTreHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botaoTreHome.UseVisualStyleBackColor = true;
            this.botaoTreHome.Click += new System.EventHandler(this.botaoTreHome_Click);
            // 
            // botaoFunHome
            // 
            this.botaoFunHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFunHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botaoFunHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.botaoFunHome.IconColor = System.Drawing.Color.Black;
            this.botaoFunHome.IconSize = 64;
            this.botaoFunHome.Location = new System.Drawing.Point(88, 64);
            this.botaoFunHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botaoFunHome.Name = "botaoFunHome";
            this.botaoFunHome.Rotation = 0D;
            this.botaoFunHome.Size = new System.Drawing.Size(148, 110);
            this.botaoFunHome.TabIndex = 10;
            this.botaoFunHome.Text = "0 Funcionários Cadastrados";
            this.botaoFunHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botaoFunHome.UseVisualStyleBackColor = true;
            this.botaoFunHome.Click += new System.EventHandler(this.botaoFunHome_Click);
            // 
            // lblDia
            // 
            this.lblDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(927, 505);
            this.lblDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(51, 30);
            this.lblDia.TabIndex = 7;
            this.lblDia.Text = "dia";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(755, 505);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(137, 30);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "01/01/1900";
            // 
            // lblSegundos
            // 
            this.lblSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(944, 447);
            this.lblSegundos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(39, 30);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "00";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(727, 421);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(191, 78);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 597);
            this.Controls.Add(this.Painel_Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Painel_Home.ResumeLayout(false);
            this.Painel_Home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Painel_Home;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton botaoProHome;
        private FontAwesome.Sharp.IconButton botaoTreHome;
        private FontAwesome.Sharp.IconButton botaoFunHome;
    }
}