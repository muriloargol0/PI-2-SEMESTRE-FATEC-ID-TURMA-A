using ControleDoações.DAO;
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
    public partial class Movimentações : Form
    {
        public Movimentações()
        {
            InitializeComponent();

            DAO.CaixaDAO cDAO = new DAO.CaixaDAO();

            dinheiroLb.Text = "R$" + String.Format("{0:0.00}", cDAO.ConsultarSaldo());
        }

        private void voltarMovBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu goMenu = new Menu();
            goMenu.ShowDialog();
            this.Close();
        }

        private void entradaBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entrada goEntrada = new Entrada();
            goEntrada.ShowDialog();
            this.Close();
        }

        private void saidaBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saída goSaida = new Saída();
            goSaida.ShowDialog();
            this.Close();
        }
    }
}
