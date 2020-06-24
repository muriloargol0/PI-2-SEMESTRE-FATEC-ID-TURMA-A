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
    public partial class ConsultaVeiculo : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_veiculo;
        public ConsultaVeiculo()
        {
            InitializeComponent();

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultaVeiculo_Load(object sender, EventArgs e)
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

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            SqlCommand att_veiculo = new SqlCommand("Update tblVeiculo set AnoFabricacao=@AnoFabricacao, Renavan=@Renavan, Placa=@Placa where Modelo=@Modelo", sql);
            att_veiculo.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = cbModelo.SelectedItem;
            att_veiculo.Parameters.Add("@AnoFabricacao", SqlDbType.Date).Value = dateFabricacao.Value;
            att_veiculo.Parameters.Add("@Renavan", SqlDbType.NChar).Value = txtRenavam.Text;
            att_veiculo.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = txtPlaca.Text;
            if (cbModelo.Text != "" && txtPlaca.Text != "" && txtRenavam.Text != "")
            {
                try
                {
                    sql.Open();
                    att_veiculo.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!", "Auto Escola Líder - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbModelo.Text = "";
                    txtPlaca.Text = "";
                    txtRenavam.Text = "";
                    dateFabricacao.Value = DateTime.Today;
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
                txtRenavam.Text = Convert.ToString(lerpesquisa["Renavan"]);
                dateFabricacao.Value = Convert.ToDateTime(lerpesquisa["AnoFabricacao"]);
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand excluir = new SqlCommand("Delete from tblVeiculo where Modelo=@Modelo", sql);
            excluir.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = cbModelo.SelectedItem;

            if (cbModelo.Text != "" && txtPlaca.Text != "" && txtRenavam.Text != "")
            {
                try
                {
                    sql.Open();
                    excluir.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido com sucesso!", "Auto Escola Líder - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbModelo.Text = "";
                    txtPlaca.Text = "";
                    txtRenavam.Text = "";
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

