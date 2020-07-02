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

namespace AppPibOM
{
    public partial class Treinamentos : Form
    {
        private Form currentChildForm;
        public Treinamentos()
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
            Painel_Treinamento.Controls.Add(childForm);
            Painel_Treinamento.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Painel_Treinamento_Paint(object sender, PaintEventArgs e)
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

        private void Textobox_Consulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Treinamentos (Titulo, Subtitulo, Autor, DataLimite, Descricao) values (@Titulo, @Subtitulo, @Autor, @DataLimite, @Descricao)";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@Titulo", txbTitulo.Text);
            comando.Parameters.AddWithValue("@Subtitulo", txbSubtitulo.Text);
            comando.Parameters.AddWithValue("@Autor", txbAutor.Text);
            comando.Parameters.AddWithValue("@DataLimite", this.dtxbDataLimite.Text);
            comando.Parameters.AddWithValue("@Descricao", txbDescricao.Text);

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
            txbSubtitulo.Clear();
            txbAutor.Clear();
            txbDescricao.Clear();
            txbConsulta.Clear();
            txbID.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "update Treinamentos set Titulo=@Titulo,Subtitulo=@Subtitulo,  Autor=@Autor,  DataLimite=@DataLimite, Descricao=@Descricao where ID=@ID";
             
            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@ID", txbID.Text);
            comando.Parameters.AddWithValue("@Titulo", txbTitulo.Text);
            comando.Parameters.AddWithValue("@Subtitulo", txbSubtitulo.Text);
            comando.Parameters.AddWithValue("@Autor", txbAutor.Text);
            comando.Parameters.AddWithValue("@DataLimite", dtxbDataLimite.Text);
            comando.Parameters.AddWithValue("@Descricao", txbDescricao.Text);

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
            txbSubtitulo.Clear();
            txbAutor.Clear();
            txbDescricao.Clear();
            txbConsulta.Clear();
            txbID.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            strSql = "Select * from Treinamentos where ID=@Consulta";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.Add("@Consulta", SqlDbType.VarChar).Value = txbConsulta.Text;

            try
            {
                if (txbConsulta.Text == "")
                {
                    MessageBox.Show("Digite um nome para realizar a consultar!!");
                }

                conexao.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("ID não está no cadastro!!");
                }

                dr.Read();

                txbID.Text = Convert.ToString(dr["ID"]);
                txbTitulo.Text = Convert.ToString(dr["Titulo"]);
                txbSubtitulo.Text = Convert.ToString(dr["Subtitulo"]);
                txbAutor.Text = Convert.ToString(dr["Autor"]);
                dtxbDataLimite.Text = Convert.ToString(dr["DataLimite"]);
                txbDescricao.Text = Convert.ToString(dr["Descricao"]);

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

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txbTitulo.Clear();
            txbSubtitulo.Clear();
            txbAutor.Clear();
            txbDescricao.Clear();
            txbConsulta.Clear();
            txbID.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM Treinamentos WHERE ID=@Id";

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
            txbSubtitulo.Clear();
            txbAutor.Clear();
            txbDescricao.Clear();
            txbConsulta.Clear();
            txbID.Clear();
        }
    }
}


