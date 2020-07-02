using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btCadAlunos_Click(object sender, EventArgs e)
        {
            CadAlunos a = new CadAlunos();
            a.ShowDialog();
            a.Dispose();
        }

        private void btCadFunc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção");
            /*CadFunc func = new CadFunc();
            func.ShowDialog();
            func.Dispose();*/
        }

        private void btConsAlunos_Click(object sender, EventArgs e)
        {
            ConsAlunos consa = new ConsAlunos();
            consa.ShowDialog();
            consa.Dispose();
        }

        private void btConsFunc_Click(object sender, EventArgs e)
        {
            ConsFunc consf = new ConsFunc();
            consf.Show();
            consf.Dispose();
        }

        private void btTurmas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção");   
        }

        private void btAnivers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção");
        }

        private void btRestricoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção");
        }

        private void bbtValores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Manutenção");
        }
    }
}
