using AppPibOM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPibOM.Forms
{
    public partial class Projetos : Form
    {
        private Form currentChildForm;
        public Projetos()
        {
            InitializeComponent();
        }

        SqlConnection conexao = null;
        private string stringConexao = @"Data Source=DESKTOP-LJ01IDN\SQLEXPRESS;Initial Catalog=DBEmpresa;Integrated Security=True";
        private string strSql = string.Empty;

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
            Painel_Projeto.Controls.Add(childForm);
            Painel_Projeto.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Painel_Projeto_Paint(object sender, PaintEventArgs e)
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

        private void txbAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "update Projetos set TituloProjeto=@TituloProjeto, AutorProjeto=@AutorProjeto, DataProjeto=@DataProjeto, Integrantes=@Integrantes, DescricaoProjeto=@DescricaoProjeto where ID=@ID";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@ID", txbID.Text);
            comando.Parameters.AddWithValue("@TituloProjeto", txbTitulo.Text);
            comando.Parameters.AddWithValue("@AutorProjeto", txbAutor.Text);
            comando.Parameters.AddWithValue("@DataProjeto", this.dtxbData.Text); ;
            comando.Parameters.AddWithValue("@Integrantes", txbIntegrantes.Text);
            comando.Parameters.AddWithValue("@DescricaoProjeto", txbDescricao.Text);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro editado com sucesso!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            txbTitulo.Clear();
            txbAutor.Clear();
            txbIntegrantes.Clear();
            txbDescricao.Clear();
            txbConsultar.Clear();
            txbID.Clear();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Projetos (TituloProjeto, AutorProjeto, DataProjeto, Integrantes, DescricaoProjeto) values (@TituloProjeto, @AutorProjeto, @DataProjeto, @Integrantes, @DescricaoProjeto)";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@TituloProjeto", txbTitulo.Text);
            comando.Parameters.AddWithValue("@AutorProjeto", txbAutor.Text);
            comando.Parameters.AddWithValue("@DataProjeto", this.dtxbData.Text);
            comando.Parameters.AddWithValue("@Integrantes", txbIntegrantes.Text);
            comando.Parameters.AddWithValue("@DescricaoProjeto", txbDescricao.Text);


            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            txbTitulo.Clear();
            txbAutor.Clear();
            txbIntegrantes.Clear();
            txbDescricao.Clear();
            txbConsultar.Clear();
            txbID.Clear();
        }

        private void txbConsultar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            strSql = "Select * from Projetos where ID=@Consulta";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@Consulta", txbConsultar.Text);

            try
            {
                if (txbConsultar.Text == "")
                {
                    MessageBox.Show("Digite um ID para realizar a consultar!!");
                }

                conexao.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("ID não está no cadastro!!");
                }

                dr.Read();

                txbID.Text = Convert.ToString(dr["ID"]);
                txbTitulo.Text = Convert.ToString(dr["TituloProjeto"]);
                txbAutor.Text = Convert.ToString(dr["AutorProjeto"]);
                dtxbData.Text = Convert.ToString(dr["DataProjeto"]);
                txbIntegrantes.Text = Convert.ToString(dr["Integrantes"]);
                txbDescricao.Text = Convert.ToString(dr["DescricaoProjeto"]);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            strSql = "Delete from Funcionarios Where ID=@ID";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@ID", txbID.Text);

            try
            {
                conexao.Open();

                MessageBox.Show("Cadastrado excluido com sucesso!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            txbTitulo.Clear();
            txbAutor.Clear();
            txbIntegrantes.Clear();
            txbDescricao.Clear();
            txbConsultar.Clear();
            txbID.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTitulo.Clear();
            txbAutor.Clear();
            txbIntegrantes.Clear();
            txbDescricao.Clear();
            txbConsultar.Clear();
            txbID.Clear();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            strSql = "Delete from Funcionarios Where ID=@ID";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@ID", txbID.Text);

            try
            {
                conexao.Open();

                MessageBox.Show("Cadastrado excluido com sucesso!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            txbTitulo.Clear();
            txbAutor.Clear();
            txbIntegrantes.Clear();
            txbDescricao.Clear();
            txbConsultar.Clear();
            txbID.Clear();
        }
    }
}

