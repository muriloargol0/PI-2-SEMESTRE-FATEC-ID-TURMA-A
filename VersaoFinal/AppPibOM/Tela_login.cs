using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace AppPibOM
{
    public partial class Tela_login : Form
    {
        public Tela_login()
        {
            InitializeComponent();
        }

        SqlConnection conexao = null;
        private string stringConexao = @"Data Source=DESKTOP-LJ01IDN\SQLEXPRESS;Initial Catalog=DbEmpresa;Integrated Security=True";
        private string strSql = string.Empty;

        private void botao_entrar_Click(object sender, EventArgs e)
        {
            strSql = "SELECT * FROM Usuarios WHERE Login=@Login and Senha=@Senha";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@Login", txbLogin.Text);
            comando.Parameters.AddWithValue("@Senha", txbSenha.Text);

            try
            {
                conexao.Open();
                SqlDataReader drms = comando.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("Usuário ou senha incorreta!!");
                }

                drms.Read();
                MessageBox.Show("Login com sucesso, Seja bem vindo!!");

                Tela_admin frmAdmin = new Tela_admin();
                frmAdmin.Show();
                this.Visible = false;
            }
            
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                conexao.Close();
            }
        }

        private void outraForm()
        {
            //Application.Run(new tela_funcionario());
        }

        private void novaForm()
        {
            Application.Run(new Tela_admin());
        }

        private void botao_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botao_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Tela_login_Load(object sender, EventArgs e)
        {

        }
    }
}
