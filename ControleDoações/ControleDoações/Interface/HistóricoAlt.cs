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
    public partial class HistóricoAlt : Form
    {
        public HistóricoAlt()
        {
            InitializeComponent();

            DAO.HistoricoDAO hDAO = new DAO.HistoricoDAO();

            //dataGridView1.DataSource = hDAO.();
        }

        private void voltarHistOrgmBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas goCons = new Consultas();
            goCons.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
