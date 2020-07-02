using AppPibOM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Data.SqlClient;

namespace AppPibOM
{
    public partial class Funcionarios : Form
    {

        private Form currentChildForm;
        public Funcionarios()
        {
            InitializeComponent();

        }

        SqlConnection conexao = null;
        private string stringConexao = @"Data Source=DESKTOP-LJ01IDN\SQLEXPRESS;Initial Catalog=DbEmpresa;Integrated Security=True";
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
            painel_funcionarios.Controls.Add(childForm);
            painel_funcionarios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Botao_Consultar_Click(object sender, EventArgs e)
        {

        }
        private void Funcionarios_Load(object sender, EventArgs e)
        {
           
        }

        private void painel_funcionarios_Paint(object sender, PaintEventArgs e)
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

        private void Textbox_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textbox_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = $"insert into Funcionarios (Nome, Funcao, RG, CPF, DataContrato, Telefone, Endereco, CEP) values (@Nome, @Funcao, @RG, @CPF, @DataContrato, @Telefone, @Endereco, @CEP)";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao); 

            comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = txbNome.Text;
            comando.Parameters.Add("Funcao", SqlDbType.VarChar).Value = txbFuncao.Text;
            comando.Parameters.Add("RG", SqlDbType.VarChar).Value = mtxbRG.Text;
            comando.Parameters.Add("CPF", SqlDbType.VarChar).Value = mtxbCPF.Text;
            comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = mtxbTelefone.Text;
            comando.Parameters.Add("DataContrato", SqlDbType.VarChar).Value = this.mtxbDataContrato.Text;
            comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = txbEndereco.Text;
            comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mtxbCEP.Text;

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

            txbNome.Clear();
            txbFuncao.Clear();
            mtxbRG.Clear();
            mtxbCPF.Clear();
            mtxbTelefone.Clear();
            txbEndereco.Clear();
            mtxbCEP.Clear();
            txbConsultar.Clear();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            strSql = "Select * from Funcionarios where ID=@Consulta";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.Add("@Consulta", SqlDbType.VarChar).Value = txbConsultar.Text;

            try
            {
                if (txbConsultar.Text == "")
                {
                    MessageBox.Show("Digite um ID para realizar a consultar!!");
                }

                conexao.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("ID não está no cadastro!!");
                }

                dr.Read();

                txbID.Text = Convert.ToString(dr["ID"]);
                txbNome.Text = Convert.ToString(dr["Nome"]);
                txbFuncao.Text = Convert.ToString(dr["Funcao"]);
                mtxbRG.Text = Convert.ToString(dr["RG"]);
                mtxbCPF.Text = Convert.ToString(dr["CPF"]);
                mtxbDataContrato.Text = Convert.ToString(dr["DataContrato"]);
                mtxbTelefone.Text = Convert.ToString(dr["Telefone"]);
                txbEndereco.Text = Convert.ToString(dr["Endereco"]);
                mtxbCEP.Text = Convert.ToString(dr["CEP"]);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            strSql = "update Funcionarios set Nome=@Nome, Funcao=@Funcao, RG=@RG, CPF=@CPF, DataContrato=@DataContrato, Telefone=@Telefone, Endereco=@Endereco, CEP=@CEP where ID=@ID";

            conexao = new SqlConnection(stringConexao);
            SqlCommand comando = new SqlCommand(strSql, conexao);

            comando.Parameters.AddWithValue("@ID", txbID.Text);
            comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = txbNome.Text;
            comando.Parameters.Add("Funcao", SqlDbType.VarChar).Value = txbFuncao.Text;
            comando.Parameters.Add("RG", SqlDbType.VarChar).Value = mtxbRG.Text;
            comando.Parameters.Add("CPF", SqlDbType.VarChar).Value = mtxbCPF.Text;
            comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = mtxbTelefone.Text;
            comando.Parameters.Add("DataContrato", SqlDbType.VarChar).Value = this.mtxbDataContrato.Text;
            comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = txbEndereco.Text;
            comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = mtxbCEP.Text;

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro editado com sucesso!!");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            txbNome.Clear();
            txbFuncao.Clear();
            mtxbRG.Clear();
            mtxbCPF.Clear();
            mtxbTelefone.Clear();
            txbEndereco.Clear();
            mtxbCEP.Clear();
            txbID.Clear();
            txbConsultar.Clear();

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

            txbNome.Clear();
            txbFuncao.Clear();
            mtxbRG.Clear();
            mtxbCPF.Clear();
            mtxbTelefone.Clear();
            txbEndereco.Clear();
            mtxbCEP.Clear();
            txbID.Clear();
            txbConsultar.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbFuncao.Clear();
            mtxbRG.Clear();
            mtxbCPF.Clear();
            mtxbTelefone.Clear();
            txbEndereco.Clear();
            mtxbCEP.Clear();
            txbID.Clear();
            txbConsultar.Clear();
        }
    }
}

