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
    public partial class CadastroDespesas : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_veiculo;
        public CadastroDespesas()
        {
            InitializeComponent();
        }

        private void CadastroDespesas_Load(object sender, EventArgs e)
        {
            cbModelo.Items.Clear();
            sql.Open();
            con_veiculo = sql.CreateCommand();
            con_veiculo.CommandType = CommandType.Text;
            con_veiculo.CommandText = "SELECT Modelo FROM tblVeiculo";
            con_veiculo.ExecuteNonQuery();
            DataTable modelo = new DataTable();
            SqlDataAdapter sql1 = new SqlDataAdapter(con_veiculo);
            sql1.Fill(modelo);
            foreach (DataRow dr in modelo.Rows)
            {
                cbModelo.Items.Add(dr["Modelo"].ToString());
                sql.Close();
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
            SqlCommand cad_despesa = new SqlCommand("Insert into tblDespesa (Veiculo, Placa, Valor, Observacao, Data) values(@Veiculo, @Placa, @Valor, @Observacao, @Data)", sql);
            cad_despesa.Parameters.Add("@Veiculo", SqlDbType.NVarChar).Value = cbModelo.SelectedItem;
            cad_despesa.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = txtPlaca.Text;
            cad_despesa.Parameters.Add("@Valor", SqlDbType.NVarChar).Value = txtValor.Text;
            cad_despesa.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = txtObservacao.Text;
            cad_despesa.Parameters.Add("@Data", SqlDbType.Date).Value = date.Value;
            if (cbModelo.Text != "" && txtValor.Text != "" && txtObservacao.Text != "")
            {
                try
                {
                    sql.Open();
                    cad_despesa.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbModelo.Text = "";
                    txtValor.Text = "";
                    txtObservacao.Text = "";
                    date.Value = DateTime.Today;
                    txtPlaca.Text = "";
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

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand pesquisar = new SqlCommand("Select * from tblVeiculo where Modelo=@Modelo", sql);
            pesquisar.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = cbModelo.SelectedItem;

            try
            {
                sql.Open();
                SqlDataReader lerpesquisa = pesquisar.ExecuteReader();
                if (lerpesquisa.HasRows == false)
                {
                    throw new Exception("Veículo não encontrado!");
                }
                lerpesquisa.Read();
                txtPlaca.Text = Convert.ToString(lerpesquisa["Placa"]);
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
    }
}
