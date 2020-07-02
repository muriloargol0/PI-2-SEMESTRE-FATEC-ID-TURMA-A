using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPibOM.Forms
{
    public partial class Home : Form
    {
        private Form currentChildForm;
        public Home()
        {
            InitializeComponent();
        }

        private void Painel_Home_Enter(object sender, EventArgs e)
        {
           
        }
        private void Painel_Home_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblSegundos.Text = DateTime.Now.ToString("ss");
            lblData.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDia.Text = DateTime.Now.ToString("ddd");
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
            childForm.BringToFront();
            childForm.Show();
        }

        private void botaoFunHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Funcionarios());
        }

        private void botaoTreHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Treinamentos());
        }

        private void botaoProHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Projetos());
        }
    }
}





