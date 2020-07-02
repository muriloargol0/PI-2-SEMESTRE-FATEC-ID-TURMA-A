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
    public partial class Saída : Form
    {
        int id = -1;
        
        public Saída()
        {
            InitializeComponent();

            Objetos.Saida saida = new Objetos.Saida();
            DAO.SaidaDAO sDAO = new DAO.SaidaDAO();
            DAO.CaixaDAO cDAO = new DAO.CaixaDAO();
            DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();

            tipoDp.SelectedItem = "Fixa";
            respDp.DataSource = uDAO.NomesColaboradores();
            respDp.DisplayMember = "Nome";
            respDp.SelectedItem = saida.FkNomeColaboradorResponsavel;

            dataGridView1.DataSource = sDAO.ConsultarSaida();
            dataGridView1.Sort(this.dataGridView1.Columns["DataHoraRegistro"], ListSortDirection.Descending);
            dinheiroSaidaLb.Text = "R$" + String.Format("{0:0.00}", cDAO.ConsultarSaldo());
            switchTabela();
        }

        private void voltarSaidaBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimentações goMov = new Movimentações();
            goMov.ShowDialog();
            this.Close();
        }

        private void sendSaidaBt_Click(object sender, EventArgs e)
        {
            enviarSaida();
        }

        private void saqueTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                enviarSaida();
        }

        private void descripTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                enviarSaida();
        }

        private void newBt_Click(object sender, EventArgs e)
        {
            switchNovo();
            clear();
        }

        private void alterarBt_Click(object sender, EventArgs e)
        {
            DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();

            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            int idCelula = Int16.Parse(row.Cells[0].Value.ToString());
            string valor = row.Cells[2].Value.ToString();
            string tipo = row.Cells[4].Value.ToString();
            string descr = row.Cells[5].Value.ToString();
            int resp = Int16.Parse(row.Cells[6].Value.ToString());
            string nota = row.Cells[7].Value.ToString();

            clear();
            id = idCelula;
            saqueTb.Text = Convert.ToString(Convert.ToDouble(valor) * -1);
            tipoDp.SelectedItem = tipo;
            respDp.SelectedText = uDAO.NomeColaborador(resp);
            notaTb.Text = nota;
            descripTb.Text = descr;
            switchAlterar();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            Objetos.Saida saida = new Objetos.Saida();
            DAO.SaidaDAO sDAO = new DAO.SaidaDAO();
            DAO.CaixaDAO cDAO = new DAO.CaixaDAO();

            saida.IdMovimentacao = id;

            saida.Valor = Convert.ToDouble(saqueTb.Text);
            saida.TipoDespesa = tipoDp.Text;
            saida.FkNomeColaboradorResponsavel = respDp.Text;
            saida.NotaFiscal = notaTb.Text;
            saida.Descricao = descripTb.Text;

            sDAO.AlterarSaida(saida);

            dataGridView1.DataSource = sDAO.ConsultarSaida();
            dataGridView1.Sort(this.dataGridView1.Columns["DataHoraRegistro"], ListSortDirection.Descending);
            dinheiroSaidaLb.Text = "R$" + String.Format("{0:0.00}", cDAO.ConsultarSaldo());
            switchTabela();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            switchTabela();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DAO.CaixaDAO cDAO = new DAO.CaixaDAO();
            DAO.SaidaDAO sDAO = new DAO.SaidaDAO();

            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            int valorCelula = Int16.Parse(row.Cells[0].Value.ToString());
            //string verif = InputDialogBox.Show("Tem certeza que deseja fazer isso?\n(Digite 'SIM' para confirmar)");


            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir essa saída?", "Confirmação", MessageBoxButtons.YesNo);
            
            if (confirmResult == DialogResult.Yes)
            {
                sDAO.ExcluirSaida(valorCelula);
                dataGridView1.DataSource = sDAO.ConsultarSaida();
                dataGridView1.Sort(this.dataGridView1.Columns["DataHoraRegistro"], ListSortDirection.Descending);
                dinheiroSaidaLb.Text = "R$" + String.Format("{0:0.00}", cDAO.ConsultarSaldo());
            }
        }

        private void enviarSaida()
        {
            if (saqueTb.Text == "")
            {
                MessageBox.Show("Insira um valor!");
                saqueTb.Focus();
            }
            else if (tipoDp.Text == "")
            {
                MessageBox.Show("Escolha o tipo da despesa!");
                tipoDp.Focus();
            }
            else if (respDp.Text == "")
            {
                MessageBox.Show("Escolha o colaborador responsável!");
                respDp.Focus();
            }
            else
            {
                Objetos.Saida saida = new Objetos.Saida();
                DAO.SaidaDAO sDAO = new DAO.SaidaDAO();
                DAO.CaixaDAO cDAO = new DAO.CaixaDAO();

                saida.Valor = Convert.ToDouble(saqueTb.Text);
                saida.TipoDespesa = tipoDp.Text;
                saida.FkNomeColaboradorResponsavel = respDp.Text;
                saida.NotaFiscal = notaTb.Text;
                saida.Descricao = descripTb.Text;

                clear();
                switchTabela();

                sDAO.IncluirSaida(saida);
                dataGridView1.DataSource = sDAO.ConsultarSaida();
                dataGridView1.Sort(this.dataGridView1.Columns["DataHoraRegistro"], ListSortDirection.Descending);
                dinheiroSaidaLb.Text = "R$" + String.Format("{0:0.00}", cDAO.ConsultarSaldo());
            }
        }

        private void switchNovo()
        {
            dataGridView1.Visible = false;
            newBt.Visible = false;
            alterarBt.Visible = false;
            deleteBt.Visible = false;

            newLb.Visible = true;
            saqueLb.Visible = true;
            saqueTb.Visible = true;
            tipoLb.Visible = true;
            tipoDp.Visible = true;
            respLb.Visible = true;
            respDp.Visible = true;
            notaLb.Visible = true;
            notaTb.Visible = true;
            descripLb.Visible = true;
            descripTb.Visible = true;
            sendSaidaBt.Visible = true;
            cancelBt.Visible = true;
        }

        private void switchAlterar()
        {
            switchNovo();

            newLb.Visible = false;
            sendSaidaBt.Visible = false;

            alterarLb.Visible = true;
            saveBt.Visible = true;
        }

        private void switchTabela()
        {
            alterarLb.Visible = false;
            newLb.Visible = false;
            saqueLb.Visible = false;
            saqueTb.Visible = false;
            tipoLb.Visible = false;
            tipoDp.Visible = false;
            respLb.Visible = false;
            respDp.Visible = false;
            notaLb.Visible = false;
            notaTb.Visible = false;
            descripLb.Visible = false;
            descripTb.Visible = false;
            sendSaidaBt.Visible = false;
            saveBt.Visible = false;
            cancelBt.Visible = false;

            dataGridView1.Visible = true;
            alterarBt.Visible = true;
            newBt.Visible = true;
            deleteBt.Visible = true;
        }

        private void clear()
        {
            Objetos.Saida saida = new Objetos.Saida(); 
            
            saqueTb.Text = "";
            tipoDp.SelectedItem = "Fixa";
            respDp.SelectedItem = "admin";
            notaTb.Text = "";
            descripTb.Text = "";
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
            colValor.Width = 79;
            DataGridViewColumn colTipo = dataGridView1.Columns[4];
            colTipo.Width = 49;
            DataGridViewColumn colDescr = dataGridView1.Columns[5];
            colDescr.Width = 80;
            DataGridViewColumn colResp = dataGridView1.Columns[6];
            colResp.Width = 40;
            DataGridViewColumn colNota = dataGridView1.Columns[7];
            colNota.Width = 69;
            DataGridViewColumn colUser = dataGridView1.Columns[8];
            colUser.Width = 64;
            DataGridViewColumn colUserAlt = dataGridView1.Columns[10];
            colUserAlt.Width = 64;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns["TipoMovimentacao"].Visible = false;
            dataGridView1.Columns["FK_IdOrigem"].Visible = false;
            dataGridView1.Columns["FK_IdColaboradorResponsavel"].HeaderText = "Resp";
            dataGridView1.Columns["IdMovimentacao"].HeaderText = "ID";
            dataGridView1.Columns["TipoDespesa"].HeaderText = "Tipo";
            dataGridView1.Columns["Descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["NotaFiscal"].HeaderText = "Nota Fiscal";
            dataGridView1.Columns["FK_UsuarioRegistro"].HeaderText = "Criador por";
            dataGridView1.Columns["DataHoraRegistro"].HeaderText = "Data e Hora";
            dataGridView1.Columns["FK_UsuarioUltimaAlteracao"].HeaderText = "Alterado por";
            dataGridView1.Columns["DataHoraUltimaAlteracao"].HeaderText = "Alterado em";
        }
    }
}
