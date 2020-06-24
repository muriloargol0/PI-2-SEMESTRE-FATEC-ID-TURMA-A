using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEscola
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SidePanel.Height = btCadastro.Height;
            SidePanel.Top = btCadastro.Top;
            menuCadastro1.BringToFront();
        
           


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btFechar.Height;
            SidePanel.Top = btFechar.Top;
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btCadastro.Height;
            SidePanel.Top = btCadastro.Top;
            menuCadastro1.BringToFront();
            
        

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = tbConsulta.Height;
            SidePanel.Top = tbConsulta.Top;
            menuConsulta1.BringToFront();
        }

        private void menuCadastro1_Load(object sender, EventArgs e)
        {

        }
    }
}
