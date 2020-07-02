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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void consultBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas goCons = new Consultas();
            goCons.ShowDialog();
            this.Close();
        }

        private void movimBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimentações goMov = new Movimentações();
            goMov.ShowDialog();
            this.Close();
        }

        private void cadastrBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro goCad = new Cadastro();
            goCad.ShowDialog();
            this.Close();
        }

        private void logoffBt_Click(object sender, EventArgs e)
        {
            DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();
            uDAO.DeslogarUsuario();

            this.Hide();
            Login logoff = new Login();
            logoff.ShowDialog();
            this.Close();
        }

        private void registrarBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro register = new Registro();
            register.ShowDialog();
            this.Close();
        }
    }
}
