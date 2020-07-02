using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using AppPibOM.Resources;
using AppPibOM.Forms;


namespace AppPibOM
{
    public partial class Tela_admin : Form
    {
        //campos
        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //contrustores
        public Tela_admin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            painel_menu.Controls.Add(leftBorderBtn);
            //form off
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true; 
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //estruturas
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 66, 134);
        }

        //metodos
        private void AtivarBotao(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DesativarBotao();
                //botao
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(128, 255, 255);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //lado esquerdo do botao
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icone da home
                Icone_home.IconChar = currentButton.IconChar;
                Icone_home.IconColor = color;
            }
        }

        private void DesativarBotao()
        {
            if(currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(0, 113, 188);
                currentButton.ForeColor = Color.GhostWhite;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.GhostWhite;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Abrir novas forms
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //abrir a form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            painel_central.Controls.Add(childForm);
            painel_central.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_home.Text = childForm.Text;
        }

        //resetar o menu
        private void Reset()
        {
            DesativarBotao();
            leftBorderBtn.Visible = false;
            Icone_home.IconChar = IconChar.Home;
            Icone_home.IconColor = Color.GhostWhite;
            label_home.Text = "Home";
            
        }

        private void botao_home_Click(object sender, EventArgs e)
        {
            
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void botao_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botao_fechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botao_fechar_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botao_max_Click(object sender, EventArgs e)
        {
             WindowState = FormWindowState.Maximized;
             botao_max.Visible = false;
             botao_restaurar.Visible = true;
            
        }

        private void botao_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void painel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_home_Click(object sender, EventArgs e)
        {

        }

        private void botao_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            botao_restaurar.Visible = false;
            botao_max.Visible = true;
        }

        private void painel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Botao_Home_Click_1(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new Home());
            AtivarBotao(sender, RGBColors.color1);
        }

        private void Botao_Funcionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Funcionarios());
            AtivarBotao(sender, RGBColors.color1);
        }

        private void Botao_Projeto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Treinamentos());
            AtivarBotao(sender, RGBColors.color1);
        }

        private void Botao_Treinamento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Projetos());
            AtivarBotao(sender, RGBColors.color1);
        }

        private void Botao_Sair_Click(object sender, EventArgs e)
        {

            Application.Exit();
            
            

        }

        private void Tela_admin_Load(object sender, EventArgs e)
        {
        
            timer1.Start();
        }
     
        private void lblDia_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblSegundos_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblSegundos.Text = DateTime.Now.ToString("ss");
            lblData.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDia.Text = DateTime.Now.ToString("ddd");
        }

        private void botaoFunHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Funcionarios());
        }

        private void painel_central_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoTreHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Treinamentos());
        }

        private void botaoProHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Projetos());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
