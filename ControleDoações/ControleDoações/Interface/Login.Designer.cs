namespace ControleDoações
{
    partial class Login
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
            this.loginLb = new System.Windows.Forms.Label();
            this.loginBt = new System.Windows.Forms.Button();
            this.userLb = new System.Windows.Forms.Label();
            this.senhaLb = new System.Windows.Forms.Label();
            this.userTb = new System.Windows.Forms.TextBox();
            this.senhaTb = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.loginLb.Location = new System.Drawing.Point(343, 75);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(118, 46);
            this.loginLb.TabIndex = 9;
            this.loginLb.Text = "Login";
            // 
            // loginBt
            // 
            this.loginBt.Location = new System.Drawing.Point(337, 353);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(133, 39);
            this.loginBt.TabIndex = 8;
            this.loginBt.Text = "Entrar";
            this.loginBt.UseVisualStyleBackColor = true;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userLb.Location = new System.Drawing.Point(304, 213);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(57, 17);
            this.userLb.TabIndex = 10;
            this.userLb.Text = "Usuário";
            this.userLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // senhaLb
            // 
            this.senhaLb.AutoSize = true;
            this.senhaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.senhaLb.Location = new System.Drawing.Point(312, 245);
            this.senhaLb.Name = "senhaLb";
            this.senhaLb.Size = new System.Drawing.Size(49, 17);
            this.senhaLb.TabIndex = 11;
            this.senhaLb.Text = "Senha";
            this.senhaLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userTb
            // 
            this.userTb.Location = new System.Drawing.Point(367, 213);
            this.userTb.Name = "userTb";
            this.userTb.Size = new System.Drawing.Size(127, 20);
            this.userTb.TabIndex = 12;
            this.userTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userTb_KeyPress);
            // 
            // senhaTb
            // 
            this.senhaTb.Location = new System.Drawing.Point(367, 245);
            this.senhaTb.Name = "senhaTb";
            this.senhaTb.Size = new System.Drawing.Size(127, 20);
            this.senhaTb.TabIndex = 13;
            this.senhaTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senhaTb_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.checkBox1.Location = new System.Drawing.Point(500, 248);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Revelar senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.senhaTb);
            this.Controls.Add(this.userTb);
            this.Controls.Add(this.senhaLb);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.loginBt);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Doações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Button loginBt;
        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.Label senhaLb;
        private System.Windows.Forms.TextBox userTb;
        private System.Windows.Forms.TextBox senhaTb;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}