namespace PitangaBrasil
{
    partial class tlRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tlRanking));
            this.btFechar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btMenuInicial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listNickname = new System.Windows.Forms.ListView();
            this.Nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Caixa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.AutoSize = true;
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.White;
            this.btFechar.Location = new System.Drawing.Point(1313, 12);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(48, 44);
            this.btFechar.TabIndex = 32;
            this.btFechar.Text = "X";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1089, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 135);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // btMenuInicial
            // 
            this.btMenuInicial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btMenuInicial.AutoSize = true;
            this.btMenuInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btMenuInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuInicial.ForeColor = System.Drawing.Color.White;
            this.btMenuInicial.Location = new System.Drawing.Point(600, 690);
            this.btMenuInicial.Name = "btMenuInicial";
            this.btMenuInicial.Size = new System.Drawing.Size(168, 58);
            this.btMenuInicial.TabIndex = 38;
            this.btMenuInicial.Text = "Menu Inicial";
            this.btMenuInicial.UseVisualStyleBackColor = false;
            this.btMenuInicial.Click += new System.EventHandler(this.BtMenuInicial_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 114);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ranking";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listNickname
            // 
            this.listNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listNickname.BackColor = System.Drawing.Color.White;
            this.listNickname.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nickname,
            this.Caixa,
            this.Imagem});
            this.listNickname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNickname.FullRowSelect = true;
            this.listNickname.GridLines = true;
            this.listNickname.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listNickname.HideSelection = false;
            this.listNickname.LabelWrap = false;
            this.listNickname.Location = new System.Drawing.Point(147, 160);
            this.listNickname.MultiSelect = false;
            this.listNickname.Name = "listNickname";
            this.listNickname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listNickname.Size = new System.Drawing.Size(1037, 410);
            this.listNickname.TabIndex = 43;
            this.listNickname.UseCompatibleStateImageBehavior = false;
            this.listNickname.View = System.Windows.Forms.View.Details;
            // 
            // Nickname
            // 
            this.Nickname.Text = "Nickname";
            this.Nickname.Width = 510;
            // 
            // Caixa
            // 
            this.Caixa.Text = "Caixa";
            this.Caixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Caixa.Width = 250;
            // 
            // Imagem
            // 
            this.Imagem.Text = "Imagem";
            this.Imagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Imagem.Width = 250;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // tlRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PitangaBrasil.Properties.Resources.abstract_light_silver_background_67845_796;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.listNickname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMenuInicial);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tlRanking";
            this.ShowInTaskbar = false;
            this.Text = "Pitanga Brasil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btMenuInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listNickname;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ColumnHeader Nickname;
        private System.Windows.Forms.ColumnHeader Caixa;
        private System.Windows.Forms.ColumnHeader Imagem;
    }
}