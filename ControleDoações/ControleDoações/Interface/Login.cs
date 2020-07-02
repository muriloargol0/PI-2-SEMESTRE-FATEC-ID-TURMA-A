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
    public partial class Login : Form
    {
        int i = 0;
        
        public Login()
        {
            InitializeComponent();

            senhaTb.UseSystemPasswordChar = true;
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            loginTest();
        }

        private void userTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                loginTest();
        }

        private void senhaTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                loginTest();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (senhaTb.UseSystemPasswordChar)
                senhaTb.UseSystemPasswordChar = false;
            else
                senhaTb.UseSystemPasswordChar = true;
        }

        private void loginTest()
        {
            if (userTb.Text == "")
            {
                MessageBox.Show("Insira um nome de login!");
                userTb.Focus();
            }
            else if (senhaTb.Text == "")
            {
                MessageBox.Show("Insira a senha!");
                senhaTb.Focus();
            }
            else
            {
                Objetos.Colaborador user = new Objetos.Colaborador();
                DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();

                user.Usuario = userTb.Text;
                user.HashSenha = senhaTb.Text;


                if (uDAO.LogarUsuario(user))
                {
                    this.Hide();
                    Menu login = new Menu();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (i == 2)
                        this.Close();

                    i++;
                }
            }
        }
    }
}
