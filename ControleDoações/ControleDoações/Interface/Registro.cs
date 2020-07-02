using ControleDoações.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDoações
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

            senhaTb.UseSystemPasswordChar = true;
            confTb.UseSystemPasswordChar = true;
            accessDp.SelectedItem = "Não";

            updateTable();
            switchTabela();
        }

        private void userTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                newUser();
        }

        private void accessDp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                newUser();
        }

        private void senhaTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                newUser();
        }

        private void confTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                newUser();
        }

        private void nomeTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                newUser();
        }

        private void rgTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                newUser();
        }

        private void cpfTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                newUser();
        }

        private void nascTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                newUser();
        }

        private void voltarRegisterBt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu goMenu = new Menu();
            goMenu.ShowDialog();
            this.Close();
        }

        private void saveBt_Click(object sender, EventArgs e)
        {
            newUser();
            updateTable();
        }

        private void newBt_Click(object sender, EventArgs e)
        {
            switchNovo();
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            switchTabela();
            clear();
        }

        private void passBt_Click(object sender, EventArgs e)
        {
            DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();
            uDAO.AlterarSenha();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            int valorCelula = Int16.Parse(row.Cells[0].Value.ToString());

            DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();
            string user = Objetos.Colaborador.usuarioLogado;

            string verif = InputDialogBox.Show("Tem certeza que deseja fazer isso?\nEssa ação é irreversível! (Digite 'SIM' para confirmar)");

            if (verif == "SIM")
            {
                uDAO.RemoverColaborador(valorCelula);
                dataGridView1.DataSource = uDAO.ConsultarColaboradores();
            }
            else
                MessageBox.Show("Operação cancelada.");

        }

        private void switchNovo()
        {
            newUserLb.Visible = true;
            userLb.Visible = true;
            userTb.Visible = true;
            accessLb.Visible = true;
            accessDp.Visible = true;
            senhaLb.Visible = true;
            senhaTb.Visible = true;
            confLb.Visible = true;
            confTb.Visible = true;
            nomeLb.Visible = true;
            nomeTb.Visible = true;
            rgLb.Visible = true;
            rgTb.Visible = true;
            cpfLb.Visible = true;
            cpfTb.Visible = true;
            nascLb.Visible = true;
            nascTb.Visible = true;
            saveBt.Visible = true;
            cancelBt.Visible = true;

            dataGridView1.Visible = false;
            newBt.Visible = false;
            passBt.Visible = false;
            deleteBt.Visible = false;

            userTb.Focus();
        }

        private void switchTabela()
        {
            newUserLb.Visible = false;
            userLb.Visible = false;
            userTb.Visible = false;
            accessLb.Visible = false;
            accessDp.Visible = false;
            senhaLb.Visible = false;
            senhaTb.Visible = false;
            confLb.Visible = false;
            confTb.Visible = false;
            nomeLb.Visible = false;
            nomeTb.Visible = false;
            rgLb.Visible = false;
            rgTb.Visible = false;
            cpfLb.Visible = false;
            cpfTb.Visible = false;
            nascLb.Visible = false;
            nascTb.Visible = false;
            saveBt.Visible = false;
            cancelBt.Visible = false;

            dataGridView1.Visible = true;
            newBt.Visible = true;
            passBt.Visible = true;
            deleteBt.Visible = true;
        }

        private void clear()
        {
            userTb.Text = "";
            accessDp.SelectedItem = "Não";
            senhaTb.Text = "";
            confTb.Text = "";
            nomeTb.Text = "";
            rgTb.Text = "";
            cpfTb.Text = "";
            nascTb.Text = "";
        }

        private void updateTable()
        {
            DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();
            
            dataGridView1.DataSource = uDAO.ConsultarColaboradores();
        }

        private void newUser()
        {
            if (nomeTb.Text == "")
            {
                MessageBox.Show("Insira o nome do colaborador!");
                nomeTb.Focus();
            }
            else if (accessDp.Text == "")
            {
                MessageBox.Show("Insira um tipo de acesso!");
                accessDp.Focus();
            }
            else if (nomeTb.Text == userTb.Text)
            {
                MessageBox.Show("O login do colaborador deve ser diferente de seu nome!");
                nomeTb.Focus();
            }
            else
            {
                var result = MessageBox.Show("Confirmar criação?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (senhaTb.Text != confTb.Text)
                        MessageBox.Show("Confirmação de senha incorreta!");
                    else
                    {
                        Objetos.Colaborador user = new Objetos.Colaborador();
                        DAO.UsuarioDAO uDAO = new DAO.UsuarioDAO();

                        user.Usuario = userTb.Text;
                        user.HashSenha = senhaTb.Text;
                        user.TipoAcesso = accessDp.Text;
                        user.Nome = nomeTb.Text;
                        user.Rg = rgTb.Text;
                        user.Cpf = cpfTb.Text;
                        if (nascTb.Text != "  /  /")
                            user.DataNascimento = DateTime.Parse(nascTb.Text).Date;

                        clear();

                        uDAO.CadastrarColaborador(user);
                        switchTabela();
                    }
                }
            }
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
            dataGridView1.Columns["DataNascimento"].DisplayIndex = 4;
            DataGridViewColumn colID = dataGridView1.Columns[0];
            colID.Width = 30;
            DataGridViewColumn colNome = dataGridView1.Columns[1];
            colNome.Width = 145;
            DataGridViewColumn colRG = dataGridView1.Columns[3];
            colRG.Width = 70;
            DataGridViewColumn colCPF = dataGridView1.Columns[4];
            colCPF.Width = 80;
            DataGridViewColumn colUser = dataGridView1.Columns[5];
            colUser.Width = 70;
            DataGridViewColumn colAccess = dataGridView1.Columns[6];
            colAccess.Width = 80;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Columns["idColaborador"].HeaderText = "ID";
            dataGridView1.Columns["DataNascimento"].HeaderText = "Data de Nasc.";
            dataGridView1.Columns["Usuario"].HeaderText = "Login";
            dataGridView1.Columns["HashSenha"].Visible = false;
        }
    }
}
