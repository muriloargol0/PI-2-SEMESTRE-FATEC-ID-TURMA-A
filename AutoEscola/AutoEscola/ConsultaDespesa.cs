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
    public partial class ConsultaDespesa : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_veiculo;
        SqlCommand con_despesa;
        int id;

        public ConsultaDespesa()
        {
            InitializeComponent();
        }

        public void configDataGrid()
        {
            dtGridDespesa.Columns[0].HeaderText = "ID";
            dtGridDespesa.Columns[1].HeaderText = "Veículo";
            dtGridDespesa.Columns[2].HeaderText = "Placa";
            dtGridDespesa.Columns[3].HeaderText = "Valor";
            dtGridDespesa.Columns[4].HeaderText = "Data";
            dtGridDespesa.Columns[5].HeaderText = "Observação";

            dtGridDespesa.Columns[0].Width = 0;
            dtGridDespesa.Columns[1].Width = 100;
            dtGridDespesa.Columns[2].Width = 100;
            dtGridDespesa.Columns[3].Width = 100;
            dtGridDespesa.Columns[4].Width = 100;
            dtGridDespesa.Columns[5].Width = 309;

            dtGridDespesa.Columns[0].Visible = false;


          }

        private void ConsultaDespesa_Load(object sender, EventArgs e)
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
            }

            SqlDataAdapter pes = new SqlDataAdapter("select ID, Veiculo, Placa, format(Valor, 'c', 'pt-br') as Valor, Data, Observacao from tblDespesa", sql);
            SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
            DataTable despesa = new DataTable();
            pes.Fill(despesa);
            dtGridDespesa.DataSource = despesa;
            configDataGrid();
            sql.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (cbModelo.Text != "")
            {
                try
                {
                    sql.Open();
                    con_despesa = new SqlCommand("select ID, Veiculo,Placa, format(Valor, 'c', 'pt-br') as Valor, Data, Observacao from tblDespesa where (Veiculo=@Veiculo) and (Data between'" + dtInicio.Value.ToString("yyyy/MM/dd") + "' and '" + dtFim.Value.ToString("yyyy/MM/dd") + "')", sql);
                    con_despesa.Parameters.Add("@Veiculo", SqlDbType.NVarChar).Value = cbModelo.SelectedItem;
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = con_despesa;
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dtGridDespesa.DataSource = tabela;
                    configDataGrid();
                    sql.Close();
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
                MessageBox.Show("Informe o Modelo do Veículo", "Auto Escola Líder - Consulta", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtGridDespesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dtGridDespesa.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtModelo.Text = dtGridDespesa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPlaca.Text = dtGridDespesa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtObservacao.Text = dtGridDespesa.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtValor.Text = dtGridDespesa.Rows[e.RowIndex].Cells[3].Value.ToString();
            date.Value = Convert.ToDateTime(dtGridDespesa.Rows[e.RowIndex].Cells[4].Value);
        }

        private void btAtt_Click(object sender, EventArgs e)
        {
            SqlCommand att_despesa = new SqlCommand("Update tblDespesa set Valor=@Valor, Data=@Data, Observacao=@Observacao, Veiculo=@Veiculo, Placa=@Placa where ID='" + id + "'", sql);
            att_despesa.Parameters.Add("@Veiculo", SqlDbType.NVarChar).Value = txtModelo.Text;
            att_despesa.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = txtPlaca.Text;
            att_despesa.Parameters.Add("@Data", SqlDbType.Date).Value = date.Value;
            att_despesa.Parameters.Add("@Valor", SqlDbType.Money).Value = txtValor.Text;
            att_despesa.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = txtObservacao.Text;
            if (txtModelo.Text != "" && txtValor.Text != "" && txtObservacao.Text != "")
            {
                try
                {
                    sql.Open();
                    att_despesa.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!", "Auto Escola Líder - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtModelo.Text = "";
                    txtValor.Text = "";
                    txtObservacao.Text = "";
                    date.Value = DateTime.Today;
                    txtPlaca.Text = "";

                    SqlDataAdapter pes = new SqlDataAdapter("select ID, Veiculo, Placa, format(Valor, 'c', 'pt-br') as Valor, Data, Observacao from tblDespesa order by ID desc", sql);
                    sql.Close();
                    SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
                    DataTable despesa = new DataTable();
                    pes.Fill(despesa);
                    dtGridDespesa.DataSource = despesa;
                    configDataGrid();
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
                MessageBox.Show("Selecione um Cadastro", "Auto Escola Líder - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand excluir = new SqlCommand("Delete from tblDespesa where Observacao=@Observacao and Veiculo=@Veiculo and Data=@Data and Valor=@Valor and Placa=@Placa", sql);
            excluir.Parameters.Add("@Veiculo", SqlDbType.NVarChar).Value = txtModelo.Text;
            excluir.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = txtPlaca.Text;
            excluir.Parameters.Add("@Data", SqlDbType.Date).Value = date.Value;
            excluir.Parameters.Add("@Valor", SqlDbType.Money).Value = txtValor.Text;
            excluir.Parameters.Add("@Observacao", SqlDbType.NVarChar).Value = txtObservacao.Text;

            if (txtModelo.Text != "" && txtValor.Text != "" && txtObservacao.Text != "")
            {
                try
                {
                    sql.Open();
                    excluir.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido com sucesso!", "Auto Escola Líder - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelo.Text = "";
                    txtValor.Text = "";
                    txtObservacao.Text = "";
                    date.Value = DateTime.Today;
                    txtPlaca.Text = "";

                    SqlDataAdapter pes = new SqlDataAdapter("select ID, Veiculo, Placa, format(Valor, 'c', 'pt-br') as Valor, Data, Observacao from tblDespesa order by Data desc", sql);
                    SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
                    DataTable despesa = new DataTable();
                    pes.Fill(despesa);
                    dtGridDespesa.DataSource = despesa;
                    configDataGrid();
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
                MessageBox.Show("Selecione um Cadastro", "Auto Escola Líder - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlDataAdapter pes = new SqlDataAdapter("select ID, Veiculo, Placa, format(Valor, 'c', 'pt-br') as Valor, Data, Observacao from tblDespesa order by ID desc", sql);
            sql.Close();
            SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
            DataTable despesa = new DataTable();
            pes.Fill(despesa);
            dtGridDespesa.DataSource = despesa;
            configDataGrid();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dtGridDespesa.Width, this.dtGridDespesa.Height);
            dtGridDespesa.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dtGridDespesa.Width, this.dtGridDespesa.Height));

            
            e.Graphics.DrawImage(objBmp, 50, 0);
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
