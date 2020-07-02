using ControleDoações.DAO;
using ControleDoações.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDoações
{
    public partial class Entrada : Form
    {
        int id = -1;
        
        public Entrada()
        {
            InitializeComponent();

            Objetos.Entrada entrada = new Objetos.Entrada();
            DAO.OrigemDAO oDAO = new DAO.OrigemDAO();
            DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();

            origemDp.ValueMember = "idOrigem";
            origemDp.DisplayMember = "Nome";
            origemDp.DataSource = oDAO.ConsultarOrigem();
            respDp.DataSource = uDAO.NomesColaboradores();
            respDp.DisplayMember = "Nome";
            respDp.SelectedItem = entrada.FkNomeColaboradorResponsavel;

            updateTable();
            switchTabela();
        }

        private void voltarEntradaBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimentações goMov = new Movimentações();
            goMov.ShowDialog();
            this.Close();
        }

        private void descripTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                enviarEntrada();
        }

        private void depositTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                enviarEntrada();
        }

        private void newBt_Click(object sender, EventArgs e)
        {
            switchNovo();
            clear();
        }

        private void alterarBt_Click(object sender, EventArgs e)
        {
            DAO.OrigemDAO oDAO = new DAO.OrigemDAO();
            DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();

            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            int idCelula = Int16.Parse(row.Cells[0].Value.ToString());

            string valor = row.Cells[2].Value.ToString();
            int origem = Int16.Parse(row.Cells[3].Value.ToString());
            string descr = row.Cells[5].Value.ToString();
            int resp = Int16.Parse(row.Cells[6].Value.ToString());
            string nota = row.Cells[7].Value.ToString();

            clear();
            
            id = idCelula;
            depositTb.Text = valor;
            origemDp.SelectedText = oDAO.NomeOrigem(origem);
            descripTb.Text = descr;
            respDp.SelectedText = uDAO.NomeColaborador(resp);
            notaTb.Text = nota;

            switchAlterar();
        }

        private void sendEntradaBt_Click(object sender, EventArgs e)
        {
            enviarEntrada();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            Objetos.Entrada entrada = new Objetos.Entrada();
            DAO.EntradaDAO eDAO = new DAO.EntradaDAO();

            entrada.IdMovimentacao = id;

            entrada.Valor = Convert.ToDouble(depositTb.Text);
            entrada.FkIdOrigem = Int16.Parse(origemDp.Text);
            entrada.Descricao = descripTb.Text;
            entrada.FkNomeColaboradorResponsavel = respDp.Text;
            entrada.NotaFiscal = notaTb.Text;

            eDAO.AlterarEntrada(entrada);

            updateTable();
            switchNovo();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            switchTabela();
        }
        
        private void deleteBt_Click(object sender, EventArgs e)
        {
            DAO.EntradaDAO eDAO = new DAO.EntradaDAO();

            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            int valorCelula = Int16.Parse(row.Cells[0].Value.ToString());

            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir essa saída?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                eDAO.ExcluirEntrada(valorCelula);
                updateTable();
            }
        }

        private void enviarEntrada()
        {
            if (depositTb.Text == "")
            {
                MessageBox.Show("Insira um valor!");
                depositTb.Focus();
            }
            else if (origemDp.Text == "")
            {
                MessageBox.Show("Insira uma origem!");
                origemDp.Focus();
            }
            else if (descripTb.Text == "")
            {
                MessageBox.Show("Insira o formato da entrada!");
                descripTb.Focus();
            }
            else
            {
                Objetos.Entrada entrada = new Objetos.Entrada();
                DAO.EntradaDAO eDAO = new DAO.EntradaDAO();

                entrada.Valor = Convert.ToDouble(depositTb.Text);
                entrada.FkNomeOrigem = origemDp.Text;
                entrada.Descricao = descripTb.Text;
                entrada.FkNomeColaboradorResponsavel = respDp.Text;
                entrada.NotaFiscal = notaTb.Text;

                clear();
                switchTabela();

                eDAO.IncluirEntrada(entrada);
                updateTable();
            }
        }

        private void switchNovo()
        {
            dataGridView1.Visible = false;
            newBt.Visible = false;
            alterarBt.Visible = false;
            deleteBt.Visible = false;

            newLb.Visible = true;
            depositLb.Visible = true;
            depositTb.Visible = true;
            origemLb.Visible = true;
            origemDp.Visible = true;
            respLb.Visible = true;
            respDp.Visible = true;
            notaLb.Visible = true;
            notaTb.Visible = true;
            descripLb.Visible = true;
            descripTb.Visible = true;
            sendEntradaBt.Visible = true;
            cancelBt.Visible = true;
        }

        private void switchAlterar()
        {
            switchNovo();

            newLb.Visible = false;
            sendEntradaBt.Visible = false;

            alterarLb.Visible = true;
            saveBt.Visible = true;
        }

        private void switchTabela()
        {
            alterarLb.Visible = false;
            newLb.Visible = false;
            depositLb.Visible = false;
            depositTb.Visible = false;
            origemLb.Visible = false;
            origemDp.Visible = false;
            respLb.Visible = false;
            respDp.Visible = false;
            notaLb.Visible = false;
            notaTb.Visible = false;
            descripLb.Visible = false;
            descripTb.Visible = false;
            sendEntradaBt.Visible = false;
            saveBt.Visible = false;
            cancelBt.Visible = false;

            dataGridView1.Visible = true;
            alterarBt.Visible = true;
            newBt.Visible = true;
            deleteBt.Visible = true;
        }

        private void clear()
        {
            depositTb.Text = "";
            origemDp.SelectedItem = "";
            descripTb.Text = "";
            respDp.SelectedItem = "";
            notaTb.Text = "";
        }

        private void updateTable()
        {
            DAO.EntradaDAO eDAO = new DAO.EntradaDAO();
            DAO.CaixaDAO cDAO = new DAO.CaixaDAO();

            dataGridView1.DataSource = eDAO.ConsultarEntrada();
            dataGridView1.Sort(this.dataGridView1.Columns["DataHoraRegistro"], ListSortDirection.Descending);
            dinheiroEntradaLb.Text = "R$" + String.Format("{0:0.00}", cDAO.ConsultarSaldo());
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowDrop = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns["valor"].DefaultCellStyle.Format = "c";
            DataGridViewColumn colID = dataGridView1.Columns[0];
            colID.Width = 30;
            DataGridViewColumn colValor = dataGridView1.Columns[2];
            colValor.Width = 80;
            DataGridViewColumn colDescr = dataGridView1.Columns[5];
            colDescr.Width = 60;
            DataGridViewColumn colResp = dataGridView1.Columns[6];
            colResp.Width = 40;
            DataGridViewColumn colNota = dataGridView1.Columns[7];
            colNota.Width = 90;
            DataGridViewColumn colUser = dataGridView1.Columns[8];
            colUser.Width = 85;
            DataGridViewColumn colUserAlt = dataGridView1.Columns[10];
            colUserAlt.Width = 90;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView1.Columns["TipoMovimentacao"].Visible = false;
            dataGridView1.Columns["TipoDespesa"].Visible = false;
            dataGridView1.Columns["FK_IdOrigem"].Visible = false;
            dataGridView1.Columns["IdMovimentacao"].HeaderText = "ID";
            dataGridView1.Columns["Descricao"].HeaderText = "Forma";
            dataGridView1.Columns["NotaFiscal"].HeaderText = "Nota Fiscal";
            dataGridView1.Columns["FK_UsuarioRegistro"].HeaderText = "Criador por";
            dataGridView1.Columns["DataHoraRegistro"].HeaderText = "Data e Hora";
            dataGridView1.Columns["FK_UsuarioUltimaAlteracao"].HeaderText = "Alterado por";
            dataGridView1.Columns["DataHoraUltimaAlteracao"].HeaderText = "Alterado em";
            dataGridView1.Columns["FK_IdColaboradorResponsavel"].HeaderText = "Resp";
        }
    }
}
