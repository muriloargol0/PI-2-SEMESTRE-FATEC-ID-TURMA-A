namespace AppPibOM
{
    partial class Tela_login
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
            System.Windows.Forms.Label label_email;
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botao_min = new System.Windows.Forms.Button();
            this.botao_fechar = new System.Windows.Forms.Button();
            this.botao_entrar = new FontAwesome.Sharp.IconButton();
            label_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(82, 138);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(117, 20);
            this.txbLogin.TabIndex = 0;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(82, 185);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(117, 20);
            this.txbSenha.TabIndex = 1;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label_email.Location = new System.Drawing.Point(10, 141);
            label_email.Name = "label_email";
            label_email.Size = new System.Drawing.Size(51, 16);
            label_email.TabIndex = 3;
            label_email.Text = "Login :";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_senha.Location = new System.Drawing.Point(10, 186);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(56, 16);
            this.label_senha.TabIndex = 4;
            this.label_senha.Text = "Senha :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPibOM.Properties.Resources.logobranco_01;
            this.pictureBox1.Location = new System.Drawing.Point(82, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // botao_min
            // 
            this.botao_min.BackgroundImage = global::AppPibOM.Properties.Resources.Minimize_Window_2_48px;
            this.botao_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_min.FlatAppearance.BorderSize = 0;
            this.botao_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_min.Location = new System.Drawing.Point(213, 2);
            this.botao_min.Name = "botao_min";
            this.botao_min.Size = new System.Drawing.Size(20, 23);
            this.botao_min.TabIndex = 6;
            this.botao_min.UseVisualStyleBackColor = true;
            this.botao_min.Click += new System.EventHandler(this.botao_min_Click);
            // 
            // botao_fechar
            // 
            this.botao_fechar.BackgroundImage = global::AppPibOM.Properties.Resources.Close_Window__2_48px2;
            this.botao_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_fechar.FlatAppearance.BorderSize = 0;
            this.botao_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_fechar.Location = new System.Drawing.Point(239, 2);
            this.botao_fechar.Name = "botao_fechar";
            this.botao_fechar.Size = new System.Drawing.Size(22, 23);
            this.botao_fechar.TabIndex = 1;
            this.botao_fechar.UseVisualStyleBackColor = true;
            this.botao_fechar.Click += new System.EventHandler(this.botao_fechar_Click);
            // 
            // botao_entrar
            // 
            this.botao_entrar.BackColor = System.Drawing.Color.DimGray;
            this.botao_entrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botao_entrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_entrar.ForeColor = System.Drawing.Color.GhostWhite;
            this.botao_entrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botao_entrar.IconColor = System.Drawing.Color.Black;
            this.botao_entrar.IconSize = 16;
            this.botao_entrar.Location = new System.Drawing.Point(82, 236);
            this.botao_entrar.Name = "botao_entrar";
            this.botao_entrar.Rotation = 0D;
            this.botao_entrar.Size = new System.Drawing.Size(116, 32);
            this.botao_entrar.TabIndex = 2;
            this.botao_entrar.Text = "ENTRAR";
            this.botao_entrar.UseVisualStyleBackColor = false;
            this.botao_entrar.Click += new System.EventHandler(this.botao_entrar_Click);
            // 
            // Tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(263, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botao_min);
            this.Controls.Add(this.botao_fechar);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(label_email);
            this.Controls.Add(this.botao_entrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tela_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLogin;
        private FontAwesome.Sharp.IconButton botao_entrar;
        private System.Windows.Forms.Label label_senha;
        protected System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button botao_fechar;
        private System.Windows.Forms.Button botao_min;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

