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
    public partial class CadastroVeiculo : Form
    {
        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
            SqlCommand cad_veiculo = new SqlCommand("Insert into tblVeiculo (Modelo, AnoFabricacao, Renavan, Placa) values(@Modelo, @AnoFabricacao, @Renavan, @Placa)",sql);
            cad_veiculo.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = txtModelo.Text;
            cad_veiculo.Parameters.Add("@AnoFabricacao", SqlDbType.Date).Value = dateFabricacao.Value;
            cad_veiculo.Parameters.Add("@Renavan", SqlDbType.NChar).Value = txtRenavam.Text;
            cad_veiculo.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = txtPlaca.Text;
            if (txtModelo.Text != "" && txtPlaca.Text != "" && txtRenavam.Text != "")
            {
                try
                {
                    sql.Open();
                    cad_veiculo.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtModelo.Text = "";
                    txtPlaca.Text = "";
                    txtRenavam.Text = "";
                    dateFabricacao.Value = DateTime.Today;
                }
                catch(Exception ex)
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
    }
}
