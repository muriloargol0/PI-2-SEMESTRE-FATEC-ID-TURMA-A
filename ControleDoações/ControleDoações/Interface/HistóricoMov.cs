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
    public partial class HistóricoMov : Form
    {
        public HistóricoMov()
        {
            InitializeComponent();

            DAO.EntradaDAO eDAO = new DAO.EntradaDAO();

            tabelaMov.DataSource = eDAO.ConsultarMovimentacoes();
            tabelaMov.Sort(this.tabelaMov.Columns["DataHoraRegistro"], ListSortDirection.Descending);
        }

        private void voltarHistDataBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas goCons = new Consultas();
            goCons.ShowDialog();
            this.Close();
        }

        private void tabelaMov_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            tabelaMov.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            tabelaMov.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tabelaMov.AllowUserToResizeColumns = false;
            tabelaMov.AllowUserToDeleteRows = false;
            tabelaMov.AllowUserToOrderColumns = false;
            tabelaMov.AllowUserToResizeRows = false;
            tabelaMov.AllowUserToAddRows = false;
            tabelaMov.AllowDrop = false;
            tabelaMov.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaMov.Columns["valor"].DefaultCellStyle.Format = "c";
            DataGridViewColumn colID = tabelaMov.Columns[0];
            colID.Width = 30;
            DataGridViewColumn colMov = tabelaMov.Columns[1];
            colMov.Width = 65;
            DataGridViewColumn colValor = tabelaMov.Columns[2];
            colValor.Width = 75;
            DataGridViewColumn colDescr = tabelaMov.Columns[5];
            colDescr.Width = 60;
            DataGridViewColumn colResp = tabelaMov.Columns[6];
            colResp.Width = 40;
            DataGridViewColumn colNota = tabelaMov.Columns[7];
            colNota.Width = 85;
            DataGridViewColumn colUser = tabelaMov.Columns[8];
            colUser.Width = 85;
            DataGridViewColumn colUserAlt = tabelaMov.Columns[10];
            colUserAlt.Width = 90;
        }

        private void tabelaMov_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tabelaMov.Columns["TipoDespesa"].Visible = false;
            tabelaMov.Columns["FK_IdOrigem"].Visible = false;
            tabelaMov.Columns["TipoMovimentacao"].HeaderText = "Moviment";
            tabelaMov.Columns["IdMovimentacao"].HeaderText = "ID";
            tabelaMov.Columns["Descricao"].HeaderText = "Forma";
            tabelaMov.Columns["NotaFiscal"].HeaderText = "Nota Fiscal";
            tabelaMov.Columns["FK_UsuarioRegistro"].HeaderText = "Criador por";
            tabelaMov.Columns["DataHoraRegistro"].HeaderText = "Data e Hora";
            tabelaMov.Columns["FK_UsuarioUltimaAlteracao"].HeaderText = "Alterado por";
            tabelaMov.Columns["DataHoraUltimaAlteracao"].HeaderText = "Alterado em";
            tabelaMov.Columns["FK_IdColaboradorResponsavel"].HeaderText = "Resp";
        }
    }
}
