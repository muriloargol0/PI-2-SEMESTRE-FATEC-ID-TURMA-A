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

namespace AutoEscola
{
    public partial class CadastroCliente : Form
    {
        SqlConnection sqlverificar = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
            SqlCommand cad_cliente = new SqlCommand("insert into tblCliente(Nome, CPF, RG, Nascimento, NomePai, NomeMae, Nacionalidade, Naturalidade, Profissao, EstadoCivil, Escolaridade, Cidade, Bairro, Endereco, NCasa, Telefone, Email, PGU, Inicio, Fim, Categoria, ValorTotal, ValorParcela, vencimento1, vencimento2, vencimento3, pag1, pag2, pag3, ValorEntrada, FormaPag) values(@Nome, @CPF, @RG, @Nascimento, @NomePai, @NomeMae, @Nacionalidade, @Naturalidade, @Profissao, @EstadoCivil, @Escolaridade, @Cidade, @Bairro, @Endereco, @NCasa, @Telefone, @Email, @PGU, @Inicio, @Fim, @Categoria, @ValorTotal, @ValorParcela, @vencimento1, @vencimento2, @vencimento3, @pag1, @pag2, @pag3, @ValorEntrada, @FormaPag)", sql);
            cad_cliente.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = txtNome.Text;
            cad_cliente.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = txtCPF.Text;
            cad_cliente.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txtRG.Text;
            cad_cliente.Parameters.Add("@Nascimento", SqlDbType.Date).Value = dateNascimento.Value;
            cad_cliente.Parameters.Add("@NomePai", SqlDbType.NVarChar).Value = txtPai.Text;
            cad_cliente.Parameters.Add("@NomeMae", SqlDbType.NVarChar).Value = txtMae.Text;
            cad_cliente.Parameters.Add("@Nacionalidade", SqlDbType.NVarChar).Value = txtNacionalidade.Text;
            cad_cliente.Parameters.Add("@Naturalidade", SqlDbType.NVarChar).Value = txtNaturalidade.Text;
            cad_cliente.Parameters.Add("@Profissao", SqlDbType.NVarChar).Value = txtProfissao.Text;
            cad_cliente.Parameters.Add("@EstadoCivil", SqlDbType.NVarChar).Value = txtEstadoCivil.Text;
            cad_cliente.Parameters.Add("@Escolaridade", SqlDbType.NVarChar).Value = txtEscolaridade.Text;
            cad_cliente.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = txtCidade.Text;
            cad_cliente.Parameters.Add("@Bairro", SqlDbType.NVarChar).Value = txtBairro.Text;
            cad_cliente.Parameters.Add("@Endereco", SqlDbType.NVarChar).Value = txtEndereco.Text;
            cad_cliente.Parameters.Add("@NCasa", SqlDbType.Int).Value = txtNumero.Text;
            cad_cliente.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = txtTelefone.Text;
            cad_cliente.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            cad_cliente.Parameters.Add("@PGU", SqlDbType.NVarChar).Value = txtPGU.Text;
            cad_cliente.Parameters.Add("@Inicio", SqlDbType.Date).Value = dateInicio.Value;
            cad_cliente.Parameters.Add("@Fim", SqlDbType.Date).Value = dateFim.Value;
            cad_cliente.Parameters.Add("@Categoria", SqlDbType.NVarChar).Value = txtCategoria.Text;
            cad_cliente.Parameters.Add("@ValorTotal", SqlDbType.Money).Value = txtValorPagar.Text;
            cad_cliente.Parameters.Add("@ValorParcela", SqlDbType.Money).Value = txtValorParcela.Text;
            cad_cliente.Parameters.Add("@vencimento1", SqlDbType.Date).Value = date1parcela.Value;
            cad_cliente.Parameters.Add("@vencimento2", SqlDbType.Date).Value = date2parcela.Value;
            cad_cliente.Parameters.Add("@vencimento3", SqlDbType.Date).Value = date3parcela.Value;
            cad_cliente.Parameters.Add("@pag1", SqlDbType.Bit).Value = status1parcela.Checked;
            cad_cliente.Parameters.Add("@pag2", SqlDbType.Bit).Value = status2parcela.Checked;
            cad_cliente.Parameters.Add("@pag3", SqlDbType.Bit).Value = status3parcela.Checked;
            cad_cliente.Parameters.Add("@ValorEntrada", SqlDbType.Money).Value = txtValorEntrada.Text;
            cad_cliente.Parameters.Add("@FormaPag", SqlDbType.NVarChar).Value = cbPagamento.Text;

            SqlCommand buscar = new SqlCommand("select CPF from tblCliente where CPF=@CPF", sqlverificar);
            buscar.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = txtCPF.Text;

            if (txtNome.Text != "" && txtCPF.Text != "" && txtRG.Text != "" && txtNacionalidade.Text != "" && txtNaturalidade.Text != "" && txtProfissao.Text != "" && txtEstadoCivil.Text != "" && txtEscolaridade.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "" && txtPGU.Text != "" && txtCategoria.Text != "" && txtValorPagar.Text != "" && txtValorEntrada.Text != "" && txtValorParcela.Text != "" && cbPagamento.Text != "")
            {
                try
                {
                    sqlverificar.Open();
                    SqlDataReader ler = buscar.ExecuteReader();
                    if (ler.HasRows == true)
                    {

                        MessageBox.Show("Cliente já cadastrado!", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else
                    {

                        sql.Open();
                        cad_cliente.ExecuteNonQuery();
                        MessageBox.Show("Cadastro realizado com sucesso!", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Text = "";
                        txtCPF.Text = "";
                        txtRG.Text = "";
                        txtPai.Text = "";
                        txtMae.Text = "";
                        txtNacionalidade.Text = "";
                        txtNaturalidade.Text = "";
                        txtProfissao.Text = "";
                        txtEstadoCivil.Text = "";
                        txtEscolaridade.Text = "";
                        txtCidade.Text = "";
                        txtBairro.Text = "";
                        txtEndereco.Text = "";
                        txtNumero.Text = "";
                        txtTelefone.Text = "";
                        txtEmail.Text = "";
                        txtPGU.Text = "";
                        txtCategoria.Text = "";
                        txtValorPagar.Text = "";
                        txtValorParcela.Text = "";
                        txtValorEntrada.Text = "";
                        status1parcela.Checked = false;
                        status2parcela.Checked = false;
                        status3parcela.Checked = false;
                        date1parcela.Value = DateTime.Today;
                        date2parcela.Value = DateTime.Today;
                        date3parcela.Value = DateTime.Today;
                        dateFim.Value = DateTime.Today;
                        dateInicio.Value = DateTime.Today;
                        dateNascimento.Value = DateTime.Today;
                        txtValor.Text = "";
                        cbPagamento.Text = "";
                    }
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Close();
                    sqlverificar.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite todas as informações", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valor, valorpagar;


            if(txtValor.Text == "")
            {
                MessageBox.Show("Digite o Valor", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cbPagamento.Text = "";
            }
            else if (cbPagamento.SelectedItem == "Dinheiro")
            {
                valor = Convert.ToDouble(txtValor.Text);
                valorpagar = Convert.ToDouble(txtValor.Text);
                txtValorPagar.Text = Convert.ToString(valor - valor * 0.04);
            }
            else if (cbPagamento.SelectedItem == "Débito")
            {
                valor = Convert.ToDouble(txtValor.Text);
                valorpagar = Convert.ToDouble(txtValor.Text);
                txtValorPagar.Text = Convert.ToString(valor - valor * 0.03);
            }
            else if (cbPagamento.SelectedItem == "Crédito")
            {
                valor = Convert.ToDouble(txtValor.Text);
                valorpagar = Convert.ToDouble(txtValor.Text);
                txtValorPagar.Text = Convert.ToString(valor * 1.05);
            }
            else
            {
                MessageBox.Show("Forma de Pagamento não informada", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btRecibo_Click(object sender, EventArgs e)
        {
            Recibo recibo = new Recibo();
            recibo.ShowDialog();
        }
    }
    }

