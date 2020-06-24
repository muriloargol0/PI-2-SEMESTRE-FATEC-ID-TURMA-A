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
    public partial class CadastroAgenda : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlConnection sqlverificar = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_veiculo;
        SqlCommand con_funcionario;
        SqlCommand con_cliente;

        public CadastroAgenda()
        {
            InitializeComponent();

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
            dtGridAgenda.Columns[1].Width = 0;
            dtGridAgenda.Columns[2].Width = 300;
            dtGridAgenda.Columns[3].Width = 115;
            dtGridAgenda.Columns[4].Width = 114;
            dtGridAgenda.Columns[5].Width = 0;
            dtGridAgenda.Columns[6].Width = 200;

            dtGridAgenda.Columns[0].Visible = false;
            dtGridAgenda.Columns[1].Visible = false;
            dtGridAgenda.Columns[5].Visible = false;

        }
        private void CadastroAgenda_Load(object sender, EventArgs e)
        {
            data_hora.Format = DateTimePickerFormat.Custom;
            data_hora.CustomFormat = "dddd,dd/MM/yyyy    HH:mm";
            data_hora.Value = DateTime.Today;


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
            }

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
            }

            SqlDataAdapter pes = new SqlDataAdapter("select * from tblAgenda", sql);
            SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
            DataTable agenda = new DataTable();
            pes.Fill(agenda);
            dtGridAgenda.DataSource = agenda;
            configDataGrid();

            sql.Close();

            sql.Close();

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btCadastro_Click(object sender, EventArgs e)
        {
            SqlCommand cad_agenda = new SqlCommand("Insert into tblAgenda (Cliente, Funcionario, Veiculo, Placa, Observação, DataHora) values(@Cliente, @Funcionario, @Veiculo, @Placa, @Observação, @DataHora)", sql);
            cad_agenda.Parameters.Add("@Cliente", SqlDbType.NVarChar).Value = cbCliente.SelectedItem;
            cad_agenda.Parameters.Add("@Funcionario", SqlDbType.NVarChar).Value = cbFuncionario.SelectedItem;
            cad_agenda.Parameters.Add("@Veiculo", SqlDbType.NVarChar).Value = cbModelo.SelectedItem;
            cad_agenda.Parameters.Add("@Placa", SqlDbType.NVarChar).Value = txtPlaca.Text;
            cad_agenda.Parameters.Add("@Observação", SqlDbType.NVarChar).Value = txtObservação.Text;
            cad_agenda.Parameters.Add("@DataHora", SqlDbType.DateTime).Value = data_hora.Text;


            SqlCommand buscar = new SqlCommand("select Funcionario, FORMAT (getdate(), 'dd/MM/yyyy, HH:mm ') as DataHora from tblAgenda where Funcionario=@Funcionario and DataHora=@DataHora", sqlverificar);
            buscar.Parameters.Add("@Funcionario", SqlDbType.NVarChar).Value = cbFuncionario.SelectedItem;
            buscar.Parameters.Add("@DataHora", SqlDbType.DateTime).Value = data_hora.Value;
            if (cbCliente.Text != "" && cbFuncionario.Text != "" && txtObservação.Text != "" && cbModelo.Text != "" && txtPlaca.Text != "")
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
                        cad_agenda.ExecuteNonQuery();
                        MessageBox.Show("Cadastro realizado com sucesso!", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    sqlverificar.Close();
                    sql.Close();
                }
                }
            else
            {
                MessageBox.Show("Insira todos os dados!", "Auto Escola Líder - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
    }

