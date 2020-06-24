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
    public partial class ConsultaPagamento : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=E904;Initial Catalog=Escola;Integrated Security=True");
        SqlCommand con_cliente;
        SqlCommand con_pag;

        public ConsultaPagamento()
        {
            InitializeComponent();
        }

        public void configDataGrid()
        {
            dtGridPagamento.Columns[0].HeaderText = "Cliente";
            dtGridPagamento.Columns[1].HeaderText = "CPF";
            dtGridPagamento.Columns[2].HeaderText = "Valor da Parcela";
            dtGridPagamento.Columns[3].HeaderText = "1º Vencimento";
            dtGridPagamento.Columns[4].HeaderText = "1º Pagamento";
            dtGridPagamento.Columns[5].HeaderText = "2º Vencimento";
            dtGridPagamento.Columns[6].HeaderText = "2º Pagamento";
            dtGridPagamento.Columns[7].HeaderText = "3º Vencimento";
            dtGridPagamento.Columns[8].HeaderText = "3º Pagamento";

            dtGridPagamento.Columns[0].Width = 200;
            dtGridPagamento.Columns[1].Width = 125;
            dtGridPagamento.Columns[2].Width = 110;
            dtGridPagamento.Columns[3].Width = 115;
            dtGridPagamento.Columns[4].Width = 100;
            dtGridPagamento.Columns[5].Width = 115;
            dtGridPagamento.Columns[6].Width = 100;
            dtGridPagamento.Columns[7].Width = 115;
            dtGridPagamento.Columns[8].Width = 100;

        }

        private void ConsultaPagamento_Load(object sender, EventArgs e)
        {
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
            }

            SqlDataAdapter pes = new SqlDataAdapter("select Nome, CPF,format(ValorParcela, 'c', 'pt-br') as ValorParcela, vencimento1, pag1, vencimento2, pag2, vencimento3, pag3 from tblCliente", sql);
            SqlCommandBuilder tabela = new SqlCommandBuilder(pes);
            DataTable agenda = new DataTable();
            pes.Fill(agenda);
            dtGridPagamento.DataSource = agenda;
            configDataGrid();

            sql.Close();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            if (cbCliente.Text != "")
            {
                try
                {
                    sql.Open();
                    con_pag = new SqlCommand("select Nome, CPF,format(ValorParcela, 'c', 'pt-br') as ValorParcela, vencimento1, pag1, vencimento2, pag2, vencimento3, pag3 from tblCliente where Nome=@Nome", sql);
                    con_pag.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = cbCliente.SelectedItem;
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = con_pag;
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dtGridPagamento.DataSource = tabela;
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
                MessageBox.Show("Informe o Nome do Cliente", "Auto Escola Líder - Consulta", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = true;
            DGVPrinter printer = new DGVPrinter();
            printer.PrintDataGridView(dtGridPagamento);
        }
    }
}
