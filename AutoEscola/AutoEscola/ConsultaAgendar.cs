using DGVPrinterHelper;
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
    public partial class ConsultaAgendar : Form
    {

        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlConnection sqlverificar = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_agenda;
        SqlCommand con_funcionario;
        SqlCommand con_cliente;
        SqlCommand con_veiculo;
        int id;


        public ConsultaAgendar()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultaAgendar_Load(object sender, EventArgs e)
        {
            data_hora.Format = DateTimePickerFormat.Custom;
            data_hora.CustomFormat = "dddd,dd/MM/yyyy    HH:mm";
            data_hora.Value = DateTime.Today;
            dtFim.Value = DateTime.Today;
            dtInicio.Value = DateTime.Today;

            sql.Open();
            cbCliente.Items.Clear();
            con_cliente = sql.CreateCommand();
            con_cliente.CommandType = CommandType.Text;
            con_cliente.CommandText = "SELECT Nome FROM tblCliente";
            con_cliente.ExecuteNonQuery();
            DataTable cliente = new DataTable();
            SqlDataAdapter sql3 = new SqlDataAdapter(con_cliente);
            sql3.Fill(cliente);
            foreach (DataRow dr in cliente.Rows)
            {
                cbCliente.Items.Add(dr["Nome"].ToString());
                txtCliente.Items.Add(dr["Nome"].ToString());
            }

            cbFuncionario.Items.Clear();
            con_funcionario = sql.CreateCommand();
            con_funcionario.CommandType = CommandType.Text;
            con_funcionario.CommandText = "SELECT Nome FROM tblFuncionario";
            con_funcionario.ExecuteNonQuery();
            DataTable nome = new DataTable();
            SqlDataAdapter sql2 = new SqlDataAdapter(con_funcionario);
            sql2.Fill(nome);
            foreach (DataRow dr in nome.Rows)
            {
                cbFuncionario.Items.Add(dr["Nome"].ToString());
                txtFuncionario.Items.Add(dr["Nome"].ToString());
            }

            txtVeiculo.Items.Clear();
            con_veiculo = sql.CreateCommand();
            con_veiculo.CommandType = CommandType.Text;
            con_veiculo.CommandText = "SELECT Modelo FROM tblVeiculo";
            con_veiculo.ExecuteNonQuery();
            DataTable modelo = new DataTable();
            SqlDataAdapter sql1 = new SqlDataAdapter(con_veiculo);
            sql1.Fill(modelo);
            foreach (DataRow dr in modelo.Rows)
            {
                txtVeiculo.Items.Add(dr["Modelo"].ToString());
            }


            SqlDataAdapter pes = new SqlDataAdapter("select * from tblAgenda order by id desc", sql);
            SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
            DataTable agenda = new DataTable();
            pes.Fill(agenda);
            dtGridAgenda.DataSource = agenda;
            configDataGrid();

            sql.Close();
        }
        public void configDataGrid()
        {
            dtGridAgenda.Columns[0].HeaderText = "ID";
            dtGridAgenda.Columns[1].HeaderText = "Cliente";
            dtGridAgenda.Columns[2].HeaderText = "Funcionário";
            dtGridAgenda.Columns[3].HeaderText = "Veículo";
            dtGridAgenda.Columns[4].HeaderText = "Placa";
            dtGridAgenda.Columns[5].HeaderText = "Observação";
            dtGridAgenda.Columns[6].HeaderText = "Data/Hora";

            dtGridAgenda.Columns[0].Width = 0;
            dtGridAgenda.Columns[1].Width = 300;
            dtGridAgenda.Columns[2].Width = 300;
            dtGridAgenda.Columns[3].Width = 115;
            dtGridAgenda.Columns[4].Width = 114;
            dtGridAgenda.Columns[5].Width = 200;
            dtGridAgenda.Columns[6].Width = 200;

            dtGridAgenda.Columns[0].Visible = false;
        }

        private void dtGridAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dtGridAgenda.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCliente.Text = dtGridAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFuncionario.Text = dtGridAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtVeiculo.Text = dtGridAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPlaca.Text = dtGridAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtObservação.Text = dtGridAgenda.Rows[e.RowIndex].Cells[5].Value.ToString();
            data_hora.Value = Convert.ToDateTime(dtGridAgenda.Rows[e.RowIndex].Cells[6].Value);
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if ((cbCliente.Text != "" && cbFuncionario.Text == ""))
            {
                try
                {
                    sql.Open();
                    con_agenda = new SqlCommand("set dateformat ymd select * from tblAgenda where (Cliente=@Cliente) and (DataHora between'" + dtInicio.Value.ToString("yyyy/MM/dd") + "' and '" + dtFim.Value.ToString("yyyy/MM/dd") + "')", sql);
                    con_agenda.Parameters.Add("@Cliente", SqlDbType.NVarChar).Value = cbCliente.SelectedItem;
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = con_agenda;
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dtGridAgenda.DataSource = tabela;
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
            else if ((cbCliente.Text == "" && cbFuncionario.Text != ""))
            {
                try
                {
                    sql.Open();
                    con_agenda = new SqlCommand("set dateformat ymd select * from tblAgenda where (Funcionario=@Funcionario) and (DataHora between'" + dtInicio.Value.ToString("yyyy/MM/dd") + "' and '" + dtFim.Value.ToString("yyyy/MM/dd") + "')", sql);
                    con_agenda.Parameters.Add("@Funcionario", SqlDbType.NVarChar).Value = cbFuncionario.SelectedItem;
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = con_agenda;
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dtGridAgenda.DataSource = tabela;
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
                MessageBox.Show("Informe o Cliente ou o Funcionário", "Auto Escola Líder - Consulta", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlDataAdapter pes = new SqlDataAdapter("select * from tblAgenda order by ID desc", sql);
            SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
            DataTable agenda = new DataTable();
            pes.Fill(agenda);
            dtGridAgenda.DataSource = agenda;
            configDataGrid();

            sql.Close();
        }

        private void btAtt_Click(object sender, EventArgs e)
        {
            SqlCommand att_agenda = new SqlCommand("Update tblAgenda set Cliente=@Cliente, Funcionario=@Funcionario, Veiculo=@Veiculo, Placa=@Placa, Observação=@Observação, DataHora=@DataHora where ID='" + id + "'", sql);
            att_agenda.Parameters.Add("@Cliente", SqlDbType.NVarChar).Value = txtCliente.Text;
            att_agenda.Parameters.Add("@Funcionario", SqlDbType.NVarChar).Value = txtFuncionario.Text;
            att_agenda.Parameters.Add("@Veiculo", SqlDbType.NVarChar).Value = txtVeiculo.Text;
            att_agenda.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = txtPlaca.Text;
            att_agenda.Parameters.Add("@Observação", SqlDbType.NVarChar).Value = txtObservação.Text;
            att_agenda.Parameters.Add("@DataHora", SqlDbType.DateTime).Value = data_hora.Value;

            SqlCommand buscar = new SqlCommand("select Funcionario, FORMAT (getdate(), 'dd/MM/yyyy, HH:mm ') as DataHora from tblAgenda where Funcionario=@Funcionario and DataHora=@DataHora", sqlverificar);
            buscar.Parameters.Add("@Funcionario", SqlDbType.NVarChar).Value = txtFuncionario.Text;
            buscar.Parameters.Add("@DataHora", SqlDbType.DateTime).Value = data_hora.Value;
            if (txtCliente.Text != "" && txtFuncionario.Text != "" && txtObservação.Text != "" && txtVeiculo.Text != "" && txtPlaca.Text != "")
            {
                try
                {
                    sqlverificar.Open();
                    SqlDataReader ler = buscar.ExecuteReader();
                    if (ler.HasRows == true)
                    {

                        MessageBox.Show("Funcionário indisponivel!", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                    else
                    {
                        sql.Open();
                        att_agenda.ExecuteNonQuery();
                        MessageBox.Show("Atualizado com sucesso!", "Auto Escola Líder - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCliente.Text = "";
                        txtFuncionario.Text = "";
                        txtObservação.Text = "";
                        data_hora.Value = DateTime.Today;
                        txtPlaca.Text = "";
                        txtVeiculo.Text = "";

                        SqlDataAdapter pes = new SqlDataAdapter("select * from tblAgenda order by ID desc", sql);
                        SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
                        DataTable despesa = new DataTable();
                        pes.Fill(despesa);
                        dtGridAgenda.DataSource = despesa;
                        configDataGrid();
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
                MessageBox.Show("Selecione um Cadastro", "Auto Escola Líder - Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlCommand excluir = new SqlCommand("Delete from tblAgenda where ID='" + id + "'", sql);
            excluir.Parameters.Add("@Cliente", SqlDbType.NVarChar).Value = txtCliente.Text;
            excluir.Parameters.Add("@Funcionario", SqlDbType.NVarChar).Value = txtFuncionario.Text;
            excluir.Parameters.Add("@Veiculo", SqlDbType.NVarChar).Value = txtVeiculo.Text;
            excluir.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = txtPlaca.Text;
            excluir.Parameters.Add("@Observação", SqlDbType.NVarChar).Value = txtObservação.Text;
            excluir.Parameters.Add("@DataHora", SqlDbType.DateTime).Value = data_hora.Value;

            if (txtCliente.Text != "" && txtFuncionario.Text != "" && txtObservação.Text != "" && txtVeiculo.Text != "" && txtPlaca.Text != "")
            {
                try
                {
                    sql.Open();
                    excluir.ExecuteNonQuery();
                    MessageBox.Show("Cadastro excluido com sucesso!", "Auto Escola Líder - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCliente.Text = "";
                    txtFuncionario.Text = "";
                    txtObservação.Text = "";
                    data_hora.Value = DateTime.Today;
                    txtPlaca.Text = "";
                    txtVeiculo.Text = "";

                    SqlDataAdapter pes = new SqlDataAdapter("select * from tblAgenda order by ID desc", sql);
                    SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
                    DataTable despesa = new DataTable();
                    pes.Fill(despesa);
                    dtGridAgenda.DataSource = despesa;
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

        private void btPrint_Click(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = true;
            DGVPrinter printer = new DGVPrinter();
            printer.PrintDataGridView(dtGridAgenda);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}