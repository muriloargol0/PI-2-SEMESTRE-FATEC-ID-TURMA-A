namespace AppPibOM
{
    partial class Tela_admin
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
            this.painel_menu = new System.Windows.Forms.Panel();
            this.Botao_Sair = new FontAwesome.Sharp.IconButton();
            this.Botao_Treinamento = new FontAwesome.Sharp.IconButton();
            this.Botao_Projeto = new FontAwesome.Sharp.IconButton();
            this.Botao_Funcionario = new FontAwesome.Sharp.IconButton();
            this.Botao_Home = new FontAwesome.Sharp.IconButton();
            this.painel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painel_titulo = new System.Windows.Forms.Panel();
            this.label_home = new System.Windows.Forms.Label();
            this.botao_min = new System.Windows.Forms.Panel();
            this.botao_restaurar = new System.Windows.Forms.Button();
            this.Icone_home = new FontAwesome.Sharp.IconPictureBox();
            this.botao_minimizar = new System.Windows.Forms.Button();
            this.botao_max = new System.Windows.Forms.Button();
            this.botao_fechar = new System.Windows.Forms.Button();
            this.painel_central = new System.Windows.Forms.Panel();
            this.botaoProHome = new FontAwesome.Sharp.IconButton();
            this.botaoTreHome = new FontAwesome.Sharp.IconButton();
            this.botaoFunHome = new FontAwesome.Sharp.IconButton();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.painel_menu.SuspendLayout();
            this.painel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.botao_min.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone_home)).BeginInit();
            this.painel_central.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_menu
            // 
            this.painel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
            this.painel_menu.Controls.Add(this.Botao_Sair);
            this.painel_menu.Controls.Add(this.Botao_Treinamento);
            this.painel_menu.Controls.Add(this.Botao_Projeto);
            this.painel_menu.Controls.Add(this.Botao_Funcionario);
            this.painel_menu.Controls.Add(this.Botao_Home);
            this.painel_menu.Controls.Add(this.painel_logo);
            this.painel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.painel_menu.Location = new System.Drawing.Point(0, 0);
            this.painel_menu.Name = "painel_menu";
            this.painel_menu.Size = new System.Drawing.Size(220, 681);
            this.painel_menu.TabIndex = 0;
            this.painel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_menu_Paint);
            // 
            // Botao_Sair
            // 
            this.Botao_Sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.Botao_Sair.FlatAppearance.BorderSize = 0;
            this.Botao_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Sair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Botao_Sair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Sair.ForeColor = System.Drawing.Color.GhostWhite;
            this.Botao_Sair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.Botao_Sair.IconColor = System.Drawing.Color.GhostWhite;
            this.Botao_Sair.IconSize = 32;
            this.Botao_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Sair.Location = new System.Drawing.Point(0, 310);
            this.Botao_Sair.Name = "Botao_Sair";
            this.Botao_Sair.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Botao_Sair.Rotation = 0D;
            this.Botao_Sair.Size = new System.Drawing.Size(220, 60);
            this.Botao_Sair.TabIndex = 12;
            this.Botao_Sair.Text = "  Sair";
            this.Botao_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botao_Sair.UseVisualStyleBackColor = true;
            this.Botao_Sair.Click += new System.EventHandler(this.Botao_Sair_Click);
            // 
            // Botao_Treinamento
            // 
            this.Botao_Treinamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.Botao_Treinamento.FlatAppearance.BorderSize = 0;
            this.Botao_Treinamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Treinamento.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Botao_Treinamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Treinamento.ForeColor = System.Drawing.Color.GhostWhite;
            this.Botao_Treinamento.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.Botao_Treinamento.IconColor = System.Drawing.Color.GhostWhite;
            this.Botao_Treinamento.IconSize = 32;
            this.Botao_Treinamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Treinamento.Location = new System.Drawing.Point(0, 250);
            this.Botao_Treinamento.Name = "Botao_Treinamento";
            this.Botao_Treinamento.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Botao_Treinamento.Rotation = 0D;
            this.Botao_Treinamento.Size = new System.Drawing.Size(220, 60);
            this.Botao_Treinamento.TabIndex = 11;
            this.Botao_Treinamento.Text = "  Projetos";
            this.Botao_Treinamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Treinamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botao_Treinamento.UseVisualStyleBackColor = true;
            this.Botao_Treinamento.Click += new System.EventHandler(this.Botao_Treinamento_Click);
            // 
            // Botao_Projeto
            // 
            this.Botao_Projeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Botao_Projeto.FlatAppearance.BorderSize = 0;
            this.Botao_Projeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Projeto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Botao_Projeto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Projeto.ForeColor = System.Drawing.Color.GhostWhite;
            this.Botao_Projeto.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.Botao_Projeto.IconColor = System.Drawing.Color.GhostWhite;
            this.Botao_Projeto.IconSize = 32;
            this.Botao_Projeto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Projeto.Location = new System.Drawing.Point(0, 190);
            this.Botao_Projeto.Name = "Botao_Projeto";
            this.Botao_Projeto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Botao_Projeto.Rotation = 0D;
            this.Botao_Projeto.Size = new System.Drawing.Size(220, 60);
            this.Botao_Projeto.TabIndex = 10;
            this.Botao_Projeto.Text = "  Treinamentos";
            this.Botao_Projeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Projeto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botao_Projeto.UseVisualStyleBackColor = true;
            this.Botao_Projeto.Click += new System.EventHandler(this.Botao_Projeto_Click);
            // 
            // Botao_Funcionario
            // 
            this.Botao_Funcionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Botao_Funcionario.FlatAppearance.BorderSize = 0;
            this.Botao_Funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Funcionario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Botao_Funcionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Funcionario.ForeColor = System.Drawing.Color.GhostWhite;
            this.Botao_Funcionario.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.Botao_Funcionario.IconColor = System.Drawing.Color.GhostWhite;
            this.Botao_Funcionario.IconSize = 32;
            this.Botao_Funcionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Funcionario.Location = new System.Drawing.Point(0, 130);
            this.Botao_Funcionario.Name = "Botao_Funcionario";
            this.Botao_Funcionario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Botao_Funcionario.Rotation = 0D;
            this.Botao_Funcionario.Size = new System.Drawing.Size(220, 60);
            this.Botao_Funcionario.TabIndex = 9;
            this.Botao_Funcionario.Text = "  Funcionarios";
            this.Botao_Funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Funcionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botao_Funcionario.UseVisualStyleBackColor = true;
            this.Botao_Funcionario.Click += new System.EventHandler(this.Botao_Funcionario_Click);
            // 
            // Botao_Home
            // 
            this.Botao_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Botao_Home.FlatAppearance.BorderSize = 0;
            this.Botao_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Botao_Home.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Home.ForeColor = System.Drawing.Color.GhostWhite;
            this.Botao_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Botao_Home.IconColor = System.Drawing.Color.GhostWhite;
            this.Botao_Home.IconSize = 32;
            this.Botao_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Home.Location = new System.Drawing.Point(0, 70);
            this.Botao_Home.Name = "Botao_Home";
            this.Botao_Home.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Botao_Home.Rotation = 0D;
            this.Botao_Home.Size = new System.Drawing.Size(220, 60);
            this.Botao_Home.TabIndex = 8;
            this.Botao_Home.Text = "  Home";
            this.Botao_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botao_Home.UseVisualStyleBackColor = true;
            this.Botao_Home.Click += new System.EventHandler(this.Botao_Home_Click_1);
            // 
            // painel_logo
            // 
            this.painel_logo.BackColor = System.Drawing.Color.Black;
            this.painel_logo.Controls.Add(this.pictureBox1);
            this.painel_logo.Controls.Add(this.painel_titulo);
            this.painel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_logo.ForeColor = System.Drawing.Color.GhostWhite;
            this.painel_logo.Location = new System.Drawing.Point(0, 0);
            this.painel_logo.Margin = new System.Windows.Forms.Padding(3, 3, 21, 3);
            this.painel_logo.Name = "painel_logo";
            this.painel_logo.Size = new System.Drawing.Size(220, 70);
            this.painel_logo.TabIndex = 0;
            this.painel_logo.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_logo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPibOM.Properties.Resources.virtualrh;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // painel_titulo
            // 
            this.painel_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.painel_titulo.Location = new System.Drawing.Point(226, -22);
            this.painel_titulo.Name = "painel_titulo";
            this.painel_titulo.Size = new System.Drawing.Size(1026, 100);
            this.painel_titulo.TabIndex = 1;
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.BackColor = System.Drawing.Color.Black;
            this.label_home.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.ForeColor = System.Drawing.Color.GhostWhite;
            this.label_home.Location = new System.Drawing.Point(56, 26);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(45, 16);
            this.label_home.TabIndex = 1;
            this.label_home.Text = "Home";
            this.label_home.Click += new System.EventHandler(this.label_home_Click);
            // 
            // botao_min
            // 
            this.botao_min.BackColor = System.Drawing.Color.Black;
            this.botao_min.Controls.Add(this.botao_restaurar);
            this.botao_min.Controls.Add(this.Icone_home);
            this.botao_min.Controls.Add(this.botao_minimizar);
            this.botao_min.Controls.Add(this.label_home);
            this.botao_min.Controls.Add(this.botao_max);
            this.botao_min.Controls.Add(this.botao_fechar);
            this.botao_min.Dock = System.Windows.Forms.DockStyle.Top;
            this.botao_min.Location = new System.Drawing.Point(220, 0);
            this.botao_min.Name = "botao_min";
            this.botao_min.Size = new System.Drawing.Size(1044, 70);
            this.botao_min.TabIndex = 2;
            this.botao_min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // botao_restaurar
            // 
            this.botao_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_restaurar.BackgroundImage = global::AppPibOM.Properties.Resources.Restore_Window_2_48px;
            this.botao_restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_restaurar.FlatAppearance.BorderSize = 0;
            this.botao_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_restaurar.Location = new System.Drawing.Point(981, 0);
            this.botao_restaurar.Name = "botao_restaurar";
            this.botao_restaurar.Size = new System.Drawing.Size(25, 26);
            this.botao_restaurar.TabIndex = 5;
            this.botao_restaurar.UseVisualStyleBackColor = true;
            this.botao_restaurar.Visible = false;
            this.botao_restaurar.Click += new System.EventHandler(this.botao_restaurar_Click);
            // 
            // Icone_home
            // 
            this.Icone_home.ForeColor = System.Drawing.Color.GhostWhite;
            this.Icone_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Icone_home.IconColor = System.Drawing.Color.GhostWhite;
            this.Icone_home.IconSize = 44;
            this.Icone_home.Location = new System.Drawing.Point(6, 9);
            this.Icone_home.Name = "Icone_home";
            this.Icone_home.Size = new System.Drawing.Size(44, 48);
            this.Icone_home.TabIndex = 0;
            this.Icone_home.TabStop = false;
            this.Icone_home.Click += new System.EventHandler(this.botao_home_Click);
            // 
            // botao_minimizar
            // 
            this.botao_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_minimizar.BackgroundImage = global::AppPibOM.Properties.Resources.Minimize_Window_2_48px1;
            this.botao_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_minimizar.FlatAppearance.BorderSize = 0;
            this.botao_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_minimizar.Location = new System.Drawing.Point(950, 0);
            this.botao_minimizar.Name = "botao_minimizar";
            this.botao_minimizar.Size = new System.Drawing.Size(25, 26);
            this.botao_minimizar.TabIndex = 4;
            this.botao_minimizar.UseVisualStyleBackColor = true;
            this.botao_minimizar.Click += new System.EventHandler(this.botao_minimizar_Click);
            // 
            // botao_max
            // 
            this.botao_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_max.BackgroundImage = global::AppPibOM.Properties.Resources.Maximize_Window_2_48px;
            this.botao_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_max.FlatAppearance.BorderSize = 0;
            this.botao_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_max.Location = new System.Drawing.Point(981, 0);
            this.botao_max.Name = "botao_max";
            this.botao_max.Size = new System.Drawing.Size(27, 26);
            this.botao_max.TabIndex = 3;
            this.botao_max.UseVisualStyleBackColor = true;
            this.botao_max.Click += new System.EventHandler(this.botao_max_Click);
            // 
            // botao_fechar
            // 
            this.botao_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botao_fechar.BackgroundImage = global::AppPibOM.Properties.Resources.Close_Window__2_48px3;
            this.botao_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_fechar.FlatAppearance.BorderSize = 0;
            this.botao_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_fechar.Location = new System.Drawing.Point(1014, 0);
            this.botao_fechar.Name = "botao_fechar";
            this.botao_fechar.Size = new System.Drawing.Size(27, 26);
            this.botao_fechar.TabIndex = 2;
            this.botao_fechar.UseVisualStyleBackColor = true;
            this.botao_fechar.Click += new System.EventHandler(this.botao_fechar_Click_2);
            // 
            // painel_central
            // 
            this.painel_central.BackColor = System.Drawing.Color.AntiqueWhite;
            this.painel_central.Controls.Add(this.botaoProHome);
            this.painel_central.Controls.Add(this.botaoTreHome);
            this.painel_central.Controls.Add(this.botaoFunHome);
            this.painel_central.Controls.Add(this.lblDia);
            this.painel_central.Controls.Add(this.lblData);
            this.painel_central.Controls.Add(this.lblSegundos);
            this.painel_central.Controls.Add(this.lblHora);
            this.painel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_central.Location = new System.Drawing.Point(220, 70);
            this.painel_central.Name = "painel_central";
            this.painel_central.Size = new System.Drawing.Size(1044, 611);
            this.painel_central.TabIndex = 3;
            this.painel_central.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_central_Paint);
            // 
            // botaoProHome
            // 
            this.botaoProHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoProHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botaoProHome.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.botaoProHome.IconColor = System.Drawing.Color.Black;
            this.botaoProHome.IconSize = 64;
            this.botaoProHome.Location = new System.Drawing.Point(497, 60);
            this.botaoProHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botaoProHome.Name = "botaoProHome";
            this.botaoProHome.Rotation = 0D;
            this.botaoProHome.Size = new System.Drawing.Size(148, 110);
            this.botaoProHome.TabIndex = 9;
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
            this.botaoTreHome.Location = new System.Drawing.Point(310, 60);
            this.botaoTreHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botaoTreHome.Name = "botaoTreHome";
            this.botaoTreHome.Rotation = 0D;
            this.botaoTreHome.Size = new System.Drawing.Size(148, 110);
            this.botaoTreHome.TabIndex = 8;
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
            this.botaoFunHome.Location = new System.Drawing.Point(122, 60);
            this.botaoFunHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botaoFunHome.Name = "botaoFunHome";
            this.botaoFunHome.Rotation = 0D;
            this.botaoFunHome.Size = new System.Drawing.Size(148, 110);
            this.botaoFunHome.TabIndex = 4;
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
            this.lblDia.Location = new System.Drawing.Point(928, 526);
            this.lblDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(51, 30);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "dia";
            this.lblDia.Click += new System.EventHandler(this.lblDia_Click);
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(753, 526);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(137, 30);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "01/01/1900";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblSegundos
            // 
            this.lblSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(936, 467);
            this.lblSegundos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(39, 30);
            this.lblSegundos.TabIndex = 1;
            this.lblSegundos.Text = "00";
            this.lblSegundos.Click += new System.EventHandler(this.lblSegundos_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(719, 441);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(191, 78);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00:00";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tela_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.painel_central);
            this.Controls.Add(this.botao_min);
            this.Controls.Add(this.painel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_admin";
            this.Text = "tela_admin";
            this.Load += new System.EventHandler(this.Tela_admin_Load);
            this.painel_menu.ResumeLayout(false);
            this.painel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.botao_min.ResumeLayout(false);
            this.botao_min.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icone_home)).EndInit();
            this.painel_central.ResumeLayout(false);
            this.painel_central.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel_menu;
        private System.Windows.Forms.Panel painel_logo;
        private System.Windows.Forms.Panel painel_titulo;
        private System.Windows.Forms.Panel botao_min;
        private FontAwesome.Sharp.IconPictureBox Icone_home;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Panel painel_central;
        private System.Windows.Forms.Button botao_fechar;
        private System.Windows.Forms.Button botao_max;
        private System.Windows.Forms.Button botao_minimizar;
        private System.Windows.Forms.Button botao_restaurar;
        private FontAwesome.Sharp.IconButton Botao_Home;
        private FontAwesome.Sharp.IconButton Botao_Sair;
        private FontAwesome.Sharp.IconButton Botao_Treinamento;
        private FontAwesome.Sharp.IconButton Botao_Projeto;
        private FontAwesome.Sharp.IconButton Botao_Funcionario;
        private System.Windows.Forms.PictureBox pictureBox1;
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