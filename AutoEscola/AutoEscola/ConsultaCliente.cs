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
    public partial class ConsultaCliente : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_cliente;

        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            cbNome.Items.Clear();
            sql.Open();
            con_cliente = sql.CreateCommand();
            con_cliente.CommandType = CommandType.Text;
            con_cliente.CommandText = "SELECT Nome FROM tblCliente";
            con_cliente.ExecuteNonQuery();
            DataTable nome = new DataTable();
            SqlDataAdapter sql1 = new SqlDataAdapter(con_cliente);
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
            SqlCommand pesquisar = new SqlCommand("Select Nome, CPF, RG, Nascimento, NomePai, NomeMae, Nacionalidade, Naturalidade, Profissao, EstadoCivil, Escolaridade, Cidade, Bairro, Endereco, NCasa, Telefone, Email, PGU, Inicio, Fim, Categoria, format(ValorTotal, 'c', 'pt-br') as ValorTotal, format(ValorParcela, 'c', 'pt-br') as ValorParcela, vencimento1, vencimento2, vencimento3, pag1, pag2, pag3, format(ValorEntrada, 'c', 'pt-br') as ValorEntrada, FormaPag from tblCliente where Nome=@Nome", sql);
            pesquisar.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cbNome.SelectedItem;

            try
            {
                sql.Open();
                SqlDataReader lerpesquisa = pesquisar.ExecuteReader();
                if (lerpesquisa.HasRows == false)
                {
                    throw new Exception("Cliente não encontrado!");
                }
                lerpesquisa.Read();
                txtCPF.Text = Convert.ToString(lerpesquisa["CPF"]);
                txtRG.Text = Convert.ToString(lerpesquisa["RG"]);
                txtPai.Text = Convert.ToString(lerpesquisa["NomePai"]);
                txtMae.Text = Convert.ToString(lerpesquisa["NomeMae"]);
                txtNacionalidade.Text = Convert.ToString(lerpesquisa["Nacionalidade"]);
                txtNaturalidade.Text = Convert.ToString(lerpesquisa["Naturalidade"]);
                txtProfissao.Text = Convert.ToString(lerpesquisa["Profissao"]);
                txtEstadoCivil.Text = Convert.ToString(lerpesquisa["EstadoCivil"]);
                txtEscolaridade.Text = Convert.ToString(lerpesquisa["Escolaridade"]);
                txtCidade.Text = Convert.ToString(lerpesquisa["Cidade"]);
                txtBairro.Text = Convert.ToString(lerpesquisa["Bairro"]);
                txtEndereco.Text = Convert.ToString(lerpesquisa["Endereco"]);
                txtNumero.Text = Convert.ToString(lerpesquisa["NCasa"]);
                txtTelefone.Text = Convert.ToString(lerpesquisa["Telefone"]);
                txtEmail.Text = Convert.ToString(lerpesquisa["Email"]);
                txtPGU.Text = Convert.ToString(lerpesquisa["PGU"]);
                txtCategoria.Text = Convert.ToString(lerpesquisa["Categoria"]);
                txtValor.Text = Convert.ToString(lerpesquisa["ValorTotal"]);
                txtValorParcela.Text = Convert.ToString(lerpesquisa["ValorParcela"]);
                txtValorEntrada.Text = Convert.ToString(lerpesquisa["ValorEntrada"]);
                date1parcela.Value = Convert.ToDateTime(lerpesquisa["vencimento1"]);
                date2parcela.Value = Convert.ToDateTime(lerpesquisa["vencimento2"]);
                date3parcela.Value = Convert.ToDateTime(lerpesquisa["vencimento3"]);
                dateFim.Value = Convert.ToDateTime(lerpesquisa["Fim"]);
                dateInicio.Value = Convert.ToDateTime(lerpesquisa["Inicio"]);
                dateNascimento.Value = Convert.ToDateTime(lerpesquisa["Nascimento"]);
                status1parcela.Checked = Convert.ToBoolean(lerpesquisa["pag1"]);
                status2parcela.Checked = Convert.ToBoolean(lerpesquisa["pag2"]);
                status3parcela.Checked = Convert.ToBoolean(lerpesquisa["pag3"]);
                cbPagamento.Text = Convert.ToString(lerpesquisa["FormaPag"]);
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
            SqlCommand att_cliente = new SqlCommand("Update tblCliente set CPF=@CPF, RG=@RG, Nascimento=@Nascimento, NomePai=@NomePai, NomeMae=@NomeMae, Nacionalidade=@Nacionalidade, Naturalidade=@Naturalidade, Profissao=@Profissao, EstadoCivil=@EstadoCivil, Escolaridade=@Escolaridade, Cidade=@Cidade, Bairro=@Bairro, Endereco=@Endereco, NCasa=@NCasa, Telefone=@Telefone, Email=@Email, PGU=@PGU, Inicio=@Inicio, Fim=@Fim, Categoria=@Categoria, ValorTotal=@ValorTotal, ValorParcela=@ValorParcela, vencimento1=@vencimento1, vencimento2=@vencimento2, vencimento3=@vencimento3, pag1=@pag1, pag2=@pag2, pag3=@pag3, ValorEntrada=@ValorEntrada, FormaPag=@FormaPag where Nome=@Nome", sql);
            att_cliente.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cbNome.SelectedItem;
            att_cliente.Parameters.Add("@CPF", SqlDbType.NVarChar).Value = txtCPF.Text;
            att_cliente.Parameters.Add("@RG", SqlDbType.NVarChar).Value = txtRG.Text;
            att_cliente.Parameters.Add("@Nascimento", SqlDbType.Date).Value = dateNascimento.Value;
            att_cliente.Parameters.Add("@NomePai", SqlDbType.NVarChar).Value = txtPai.Text;
            att_cliente.Parameters.Add("@NomeMae", SqlDbType.NVarChar).Value = txtMae.Text;
            att_cliente.Parameters.Add("@Nacionalidade", SqlDbType.NVarChar).Value = txtNacionalidade.Text;
            att_cliente.Parameters.Add("@Naturalidade", SqlDbType.NVarChar).Value = txtNaturalidade.Text;
            att_cliente.Parameters.Add("@Profissao", SqlDbType.NVarChar).Value = txtProfissao.Text;
            att_cliente.Parameters.Add("@EstadoCivil", SqlDbType.NVarChar).Value = txtEstadoCivil.Text;
            att_cliente.Parameters.Add("@Escolaridade", SqlDbType.NVarChar).Value = txtEscolaridade.Text;
            att_cliente.Parameters.Add("@Cidade", SqlDbType.NVarChar).Value = txtCidade.Text;
            att_cliente.Parameters.Add("@Bairro", SqlDbType.NVarChar).Value = txtBairro.Text;
            att_cliente.Parameters.Add("@Endereco", SqlDbType.NVarChar).Value = txtEndereco.Text;
            att_cliente.Parameters.Add("@NCasa", SqlDbType.Int).Value = txtNumero.Text;
            att_cliente.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = txtTelefone.Text;
            att_cliente.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
            att_cliente.Parameters.Add("@PGU", SqlDbType.NVarChar).Value = txtPGU.Text;
            att_cliente.Parameters.Add("@Inicio", SqlDbType.Date).Value = dateInicio.Value;
            att_cliente.Parameters.Add("@Fim", SqlDbType.Date).Value = dateFim.Value;
            att_cliente.Parameters.Add("@Categoria", SqlDbType.NVarChar).Value = txtCategoria.Text;
            att_cliente.Parameters.Add("@ValorTotal", SqlDbType.Money).Value = txtValor.Text;
            att_cliente.Parameters.Add("@ValorParcela", SqlDbType.Money).Value = txtValorParcela.Text;
            att_cliente.Parameters.Add("@vencimento1", SqlDbType.Date).Value = date1parcela.Value;
            att_cliente.Parameters.Add("@vencimento2", SqlDbType.Date).Value = date2parcela.Value;
            att_cliente.Parameters.Add("@vencimento3", SqlDbType.Date).Value = date3parcela.Value;
            att_cliente.Parameters.Add("@pag1", SqlDbType.Bit).Value = status1parcela.Checked;
            att_cliente.Parameters.Add("@pag2", SqlDbType.Bit).Value = status2parcela.Checked;
            att_cliente.Parameters.Add("@pag3", SqlDbType.Bit).Value = status3parcela.Checked;
            att_cliente.Parameters.Add("@ValorEntrada", SqlDbType.Money).Value = txtValorEntrada.Text;
            att_cliente.Parameters.Add("@FormaPag", SqlDbType.NVarChar).Value = cbPagamento.Text;

            if (cbNome.Text != "" && txtCPF.Text != "" && txtRG.Text != "" && txtNacionalidade.Text != "" && txtNaturalidade.Text != "" && txtProfissao.Text != "" && txtEstadoCivil.Text != "" && txtEscolaridade.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "" && txtPGU.Text != "" && txtCategoria.Text != "" && txtValor.Text != "" && txtValorEntrada.Text != "" && txtValorParcela.Text != "" && cbPagamento.Text != "")
            {
                try
                {
                    sql.Open();
                    att_cliente.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado com sucesso!", "Auto Escola Líder - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbNome.Text = "";
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
                    txtValor.Text = "";
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
                    cbPagamento.Text = "";
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand excluir = new SqlCommand("Delete from tblCliente where Nome=@Nome", sql);
            excluir.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cbNome.SelectedItem;

            if (cbNome.Text != "" && txtCPF.Text != "" && txtRG.Text != "" && txtNacionalidade.Text != "" && txtNaturalidade.Text != "" && txtProfissao.Text != "" && txtEstadoCivil.Text != "" && txtEscolaridade.Text != "" && txtCidade.Text != "" && txtBairro.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtTelefone.Text != "" && txtEmail.Text != "" && txtPGU.Text != "" && txtCategoria.Text != "" && txtValor.Text != "" && txtValorEntrada.Text != "" && txtValorParcela.Text != "" && cbPagamento.Text != "")
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
                    txtValor.Text = "";
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
                    cbPagamento.Text = "";
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

        private void btRecibo_Click(object sender, EventArgs e)
        {
            Recibo recibo = new Recibo();
            recibo.ShowDialog();
        }
    }
}
