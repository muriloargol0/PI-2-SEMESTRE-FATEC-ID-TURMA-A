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
    public partial class CadastroFuncionario : Form
    {
        Bitmap bmp;

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            MemoryStream imagem = new MemoryStream();
            bmp.Save(imagem, ImageFormat.Bmp);
            byte[] foto = imagem.ToArray();

            SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
            SqlCommand cad_cliente = new SqlCommand("insert into tblFuncionario(Nome, CPF, RG, Nascimento, NomePai, NomeMae, Admissão, Cargo, NFilhos, Cidade, Bairro, Endereco, NCasa, Telefone, Email, NCredencial, ftCredencial, CNH) values(@Nome, @CPF, @RG, @Nascimento, @NomePai, @NomeMae, @Admissão, @Cargo, @NFilhos, @Cidade, @Bairro, @Endereco, @NCasa, @Telefone, @Email, @NCredencial, @ftCredencial, @CNH)", sql);
            cad_cliente.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = txtNome.Text;
            cad_cliente.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = txtCPF1.Text;
            cad_cliente.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txtRG.Text;
            cad_cliente.Parameters.Add("@Nascimento", SqlDbType.Date).Value = dateNascimento.Value;
            cad_cliente.Parameters.Add("@NomePai", SqlDbType.NVarChar).Value = txtPai.Text;
            cad_cliente.Parameters.Add("@NomeMae", SqlDbType.NVarChar).Value = txtMae.Text;
            cad_cliente.Parameters.Add("@Admissão", SqlDbType.Date).Value = dateAdmissao.Value;
            cad_cliente.Parameters.Add("@Cargo", SqlDbType.NVarChar).Value = txtCargo.Text;
            cad_cliente.Parameters.Add("@NFilhos", SqlDbType.Int).Value = txtFilho.Text;
            cad_cliente.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = txtCidade.Text;
            cad_cliente.Parameters.Add("@Bairro", SqlDbType.NVarChar).Value = txtBairro.Text;
            cad_cliente.Parameters.Add("@Endereco", SqlDbType.NVarChar).Value = txtEndereco.Text;
            cad_cliente.Parameters.Add("@NCasa", SqlDbType.Int).Value = txtNumero.Text;
            cad_cliente.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = txtTelefone.Text;
            cad_cliente.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            cad_cliente.Parameters.Add("@NCredencial", SqlDbType.NVarChar).Value = txtNCredencial.Text;
            cad_cliente.Parameters.Add("@ftCredencial", SqlDbType.VarBinary).Value = foto;
            cad_cliente.Parameters.Add("@CNH", SqlDbType.NVarChar).Value = txtNCNH.Text;

            if (txtNome.Text != "" && txtCPF1.Text != "" && txtRG.Text != "" && txtCargo.Text != "" && txtFilho.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "" && txtNCredencial.Text != "" && txtNCNH.Text != "" && pictureBox1 != null)
            {
                try
                {
                    sql.Open();
                    cad_cliente.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Text = "";
                    txtCPF1.Text = "";
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
                MessageBox.Show("Digite todas as informações", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String nome = openFileDialog1.FileName;
                bmp = new Bitmap(nome);
                pictureBox1.Image = bmp;
            }
        }

        private void dateAdmissao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtNCNH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtNCredencial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtFilho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtMae_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
