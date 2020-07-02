using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDoações
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void voltarConsBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu goMenu = new Menu();
            goMenu.ShowDialog();
            this.Close();
        }

        private void histMovBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistóricoMov goHistMov = new HistóricoMov();
            goHistMov.ShowDialog();
            this.Close();
        }

        private void histAltBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistóricoAlt goHistAlt = new HistóricoAlt();
            goHistAlt.ShowDialog();
            this.Close();
        }
    }
}
