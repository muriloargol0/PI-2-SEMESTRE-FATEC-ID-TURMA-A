using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEscola
{
    public partial class ConsultaFuncionario : Form
    {
        Bitmap bmp;

        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_funcionario;

        public ConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {
            cbNome.Items.Clear();
            sql.Open();
            con_funcionario = sql.CreateCommand();
            con_funcionario.CommandType = CommandType.Text;
            con_funcionario.CommandText = "SELECT Nome FROM tblFuncionario";
            con_funcionario.ExecuteNonQuery();
            DataTable nome = new DataTable();
            SqlDataAdapter sql1 = new SqlDataAdapter(con_funcionario);
            sql1.Fill(nome);
            foreach (DataRow dr in nome.Rows)
            {
                cbNome.Items.Add(dr["Nome"].ToString());
                sql.Close();
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand pesquisar = new SqlCommand("Select * from tblFuncionario where Nome=@Nome", sql);
            pesquisar.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cbNome.SelectedItem;

            try
            {
                sql.Open();
                SqlDataReader lerpesquisa = pesquisar.ExecuteReader();
                if (lerpesquisa.HasRows == false)
                {
                    throw new Exception("Funcionário não encontrado!");
                }
                lerpesquisa.Read();
                txtCPF.Text = Convert.ToString(lerpesquisa["CPF"]);
                txtRG.Text = Convert.ToString(lerpesquisa["RG"]);
                txtPai.Text = Convert.ToString(lerpesquisa["NomePai"]);
                txtMae.Text = Convert.ToString(lerpesquisa["NomeMae"]);
                txtCargo.Text = Convert.ToString(lerpesquisa["Cargo"]);
                txtFilho.Text = Convert.ToString(lerpesquisa["NFilhos"]);
                txtNCredencial.Text = Convert.ToString(lerpesquisa["NCredencial"]);
                txtNCNH.Text = Convert.ToString(lerpesquisa["CNH"]);
                txtCidade.Text = Convert.ToString(lerpesquisa["Cidade"]);
                txtBairro.Text = Convert.ToString(lerpesquisa["Bairro"]);
                txtEndereco.Text = Convert.ToString(lerpesquisa["Endereco"]);
                txtNumero.Text = Convert.ToString(lerpesquisa["NCasa"]);
                txtTelefone.Text = Convert.ToString(lerpesquisa["Telefone"]);
                txtEmail.Text = Convert.ToString(lerpesquisa["Email"]);
                dateAdmissao.Value = Convert.ToDateTime(lerpesquisa["Admissão"]);
                dateNascimento.Value = Convert.ToDateTime(lerpesquisa["Nascimento"]);
                byte[] imagem = (byte[])(lerpesquisa[17]);
                MemoryStream memory = new MemoryStream(imagem);
                pictureBox1.Image = Image.FromStream(memory);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

                MemoryStream imagem = new MemoryStream();
            bmp.Save(imagem, ImageFormat.Bmp);
            byte[] foto = imagem.ToArray();

            SqlCommand att_funcionario = new SqlCommand("Update tblFuncionario set CPF=@CPF, RG=@RG, Nascimento=@Nascimento, NomePai=@NomePai, NomeMae=@NomeMae, Admissão=@Admissão, Cargo=@Cargo, NFilhos=@NFilhos, Cidade=@Cidade, Bairro=@Bairro, Endereco=@Endereco, NCasa=@NCasa, Telefone=@Telefone, Email=@Email, NCredencial=@NCredencial, ftCredencial=@ftCredencial, CNH=@CNH where Nome=@Nome", sql);
            att_funcionario.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cbNome.Text;
            att_funcionario.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = txtCPF.Text;
            att_funcionario.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txtRG.Text;
            att_funcionario.Parameters.Add("@Nascimento", SqlDbType.Date).Value = dateNascimento.Value;
            att_funcionario.Parameters.Add("@NomePai", SqlDbType.NVarChar).Value = txtPai.Text;
            att_funcionario.Parameters.Add("@NomeMae", SqlDbType.NVarChar).Value = txtMae.Text;
            att_funcionario.Parameters.Add("@Admissão", SqlDbType.Date).Value = dateAdmissao.Value;
            att_funcionario.Parameters.Add("@Cargo", SqlDbType.NVarChar).Value = txtCargo.Text;
            att_funcionario.Parameters.Add("@NFilhos", SqlDbType.NVarChar).Value = txtFilho.Text;
            att_funcionario.Parameters.Add("@NCredencial", SqlDbType.NVarChar).Value = txtNCredencial.Text;
            att_funcionario.Parameters.Add("@CNH", SqlDbType.NVarChar).Value = txtNCNH.Text;
            att_funcionario.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = txtCidade.Text;
            att_funcionario.Parameters.Add("@Bairro", SqlDbType.NVarChar).Value = txtBairro.Text;
            att_funcionario.Parameters.Add("@Endereco", SqlDbType.NVarChar).Value = txtEndereco.Text;
            att_funcionario.Parameters.Add("@NCasa", SqlDbType.Int).Value = txtNumero.Text;
            att_funcionario.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = txtTelefone.Text;
            att_funcionario.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            att_funcionario.Parameters.Add("ftCredencial", SqlDbType.VarBinary).Value = foto;

            if (cbNome.Text != "" && txtCPF.Text != "" && txtRG.Text != "" && txtCargo.Text != "" && txtFilho.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "" && txtNCredencial.Text != "" && txtNCNH.Text != "" && pictureBox1 != null)
            {
                try
                {
                    sql.Open();
                    att_funcionario.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado com sucesso!", "Auto Escola Líder - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbNome.Text = "";
                    txtCPF.Text = "";
                    txtRG.Text = "";
                    txtPai.Text = "";
                    txtMae.Text = "";
                    txtCargo.Text = "";
                    txtFilho.Text = "";
                    txtCidade.Text = "";
                    txtBairro.Text = "";
                    txtEndereco.Text = "";
                    txtNumero.Text = "";
                    txtTelefone.Text = "";
                    txtEmail.Text = "";
                    txtNCNH.Text = "";
                    dateAdmissao.Value = DateTime.Today;
                    dateNascimento.Value = DateTime.Today;
                    pictureBox1.Image = null;
                    txtNCredencial.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                }

            }
            else
            {
                MessageBox.Show("Digite todas as informações", "Auto Escola Líder - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                pictureBox1.Image = bmp;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand excluir = new SqlCommand("Delete from tblFuncionario where Nome=@Nome", sql);
            excluir.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cbNome.SelectedItem;

            if (cbNome.Text != "" && txtCPF.Text != "" && txtRG.Text != "" && txtCargo.Text != "" && txtFilho.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "" && txtNCredencial.Text != "" && txtNCNH.Text != "" && pictureBox1 != null)
            {
                try
                {
                    sql.Open();
                    excluir.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido com sucesso!", "Auto Escola Líder - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbNome.Text = "";
                    txtCPF.Text = "";
                    txtRG.Text = "";
                    txtPai.Text = "";
                    txtMae.Text = "";
                    txtCargo.Text = "";
                    txtFilho.Text = "";
                    txtCidade.Text = "";
                    txtBairro.Text = "";
                    txtEndereco.Text = "";
                    txtNumero.Text = "";
                    txtTelefone.Text = "";
                    txtEmail.Text = "";
                    txtNCNH.Text = "";
                    dateAdmissao.Value = DateTime.Today;
                    dateNascimento.Value = DateTime.Today;
                    pictureBox1.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite todas as informações", "Auto Escola Líder - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
