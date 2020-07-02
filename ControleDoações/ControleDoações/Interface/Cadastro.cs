using ControleDoações.DAO;
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
    public partial class Cadastro : Form
    {
        int id = 0;

        public Cadastro()
        {
            InitializeComponent();

            DAO.OrigemDAO oDAO = new DAO.OrigemDAO();

            dataGridView1.DataSource = oDAO.ConsultarOrigem();
            switchTabela();
        }

        private void voltarCadBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu goMenu = new Menu();
            goMenu.ShowDialog();
            this.Close();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            enviarOrigem();
        }

        private void origemTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                enviarOrigem();
        }

        private void descripTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                enviarOrigem();
        }

        private void newBt_Click(object sender, EventArgs e)
        {
            switchNovo();
            clear();
        }

        private void alterarBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            id = Int16.Parse(row.Cells[0].Value.ToString());
            string nome = row.Cells[1].Value.ToString();
            string fone = row.Cells[2].Value.ToString();
            string end = row.Cells[3].Value.ToString();
            string mail = row.Cells[4].Value.ToString();
            string cpf = row.Cells[5].Value.ToString();
            string cnpj = row.Cells[6].Value.ToString();
            string descr = row.Cells[7].Value.ToString();

            origemTb.Text = nome;
            foneTb.Text = fone;
            endTb.Text = end;
            mailTb.Text = mail;
            cpfTb.Text = cpf;
            cnpjTb.Text = cnpj;
            descripTb.Text = descr;

            switchAlterar();
        }

        private void confirmBt_Click(object sender, EventArgs e)
        {
            Objetos.Origem origem = new Objetos.Origem();
            DAO.OrigemDAO oDAO = new DAO.OrigemDAO();

            origem.Nome = origemTb.Text;
            origem.Telefone = foneTb.Text;
            origem.Endereco = endTb.Text;
            origem.Email = mailTb.Text;
            origem.Cpf = cpfTb.Text;
            origem.Cnpj = cnpjTb.Text;
            origem.Descricao = descripTb.Text;
            origem.IdOrigem = id;

            oDAO.AlterarOrigem(origem);

            dataGridView1.DataSource = oDAO.ConsultarOrigem();

            switchTabela();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            switchTabela();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            int valorCelula = Int16.Parse(row.Cells[0].Value.ToString());

            DAO.OrigemDAO oDAO = new DAO.OrigemDAO();

            var confirmResult = MessageBox.Show("Tem certeza que deseja excluir essa saída?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                oDAO.ExcluirOrigem(valorCelula);
                dataGridView1.DataSource = oDAO.ConsultarOrigem();
            }
        }

        private void enviarOrigem()
        {
            if (origemTb.Text == "")
            {
                MessageBox.Show("Insira um nome!");
                origemTb.Focus();
            }
            else
            {
                Objetos.Origem origem = new Objetos.Origem();
                DAO.OrigemDAO oDAO = new DAO.OrigemDAO();

                origem.Nome = origemTb.Text;
                origem.Telefone = foneTb.Text;
                origem.Endereco = endTb.Text;
                origem.Email = mailTb.Text;
                origem.Cpf = cpfTb.Text;
                origem.Cnpj = cnpjTb.Text;
                origem.Descricao = descripTb.Text;

                clear();
                switchTabela();

                oDAO.IncluirOrigem(origem);

                dataGridView1.DataSource = oDAO.ConsultarOrigem();
            }
        }

        private void switchNovo()
        {
            dataGridView1.Visible = false;
            alterarBt.Visible = false;
            newBt.Visible = false;
            deleteBt.Visible = false;

            novaOrigemLb.Visible = true;
            origemLb.Visible = true;
            origemTb.Visible = true;
            cpfLb.Visible = true;
            cpfTb.Visible = true;
            cnpjLb.Visible = true;
            cnpjTb.Visible = true;
            endLb.Visible = true;
            endTb.Visible = true;
            foneLb.Visible = true;
            foneTb.Visible = true;
            mailLb.Visible = true;
            mailTb.Visible = true;
            descripLb.Visible = true;
            descripTb.Visible = true;
            saveBt.Visible = true;
            cancelBt.Visible = true;
        }

        private void switchAlterar()
        {
            switchNovo();
            
            novaOrigemLb.Visible = false;
            saveBt.Visible = false;

            alterarLb.Visible = true;
            confirmBt.Visible = true;
        }

        private void switchTabela()
        {
            novaOrigemLb.Visible = false;
            alterarLb.Visible = false;
            origemLb.Visible = false;
            origemTb.Visible = false;
            cpfLb.Visible = false;
            cpfTb.Visible = false;
            cnpjLb.Visible = false;
            cnpjTb.Visible = false;
            endLb.Visible = false;
            endTb.Visible = false;
            foneLb.Visible = false;
            foneTb.Visible = false;
            mailLb.Visible = false;
            mailTb.Visible = false;
            descripLb.Visible = false;
            descripTb.Visible = false;
            saveBt.Visible = false;
            confirmBt.Visible = false;
            cancelBt.Visible = false;

            dataGridView1.Visible = true;
            alterarBt.Visible = true;
            newBt.Visible = true;
            deleteBt.Visible = true;
        }

        private void clear()
        {
            origemTb.Text = "";
            foneTb.Text = "";
            endTb.Text = "";
            mailTb.Text = "";
            cpfTb.Text = "";
            cnpjTb.Text = "";
            descripTb.Text = "";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowDrop = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewColumn colID = dataGridView1.Columns[0];
            colID.Width = 30;
            DataGridViewColumn colNome = dataGridView1.Columns[1];
            colNome.Width = 110;
            DataGridViewColumn colFone = dataGridView1.Columns[2];
            colFone.Width = 80;
            DataGridViewColumn colCPF = dataGridView1.Columns[5];
            colCPF.Width = 80;
            DataGridViewColumn colDescr = dataGridView1.Columns[7];
            colDescr.Width = 75;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns["idOrigem"].HeaderText = "ID";
            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
        }
    }
}
