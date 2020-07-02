using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class CadAlunos : Form
    {
        public string operacao = "";
        public CadAlunos()
        {
            InitializeComponent();
        }

        private void tbCadAlunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbCadAlunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdEstSaberDataSet);

        }

        private void CadAlunos_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.tbCadAlunosTableAdapter.Fill(this.bdEstSaberDataSet.tbCadAlunos);
            this.LimpaCampos();
           
        }

        
        public void AlteraBotoes(int op)
        {
            pDados.Enabled = false;
            btInserir.Enabled = false;
            btLocalizar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;

            if(op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btExcluir.Enabled = true;
                btAlterar.Enabled = true;
                btCancelar.Enabled = true;
            }

        }
        public void LimpaCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtdatanascimento.Text = "";
            txtgenero.Text = "";
            enderecoTextBox.Clear();
            numeroTextBox.Clear();
            bairroTextBox.Clear();
            cidadeTextBox.Clear();
            ufComboBox.Text = "";
            cepMaskedTextBox.Clear();
            telfixoMaskedTextBox.Clear();
            restricaoalimentarCheckBox.Checked = false;
            restricaoalimObsTextBox.Clear();
            restricaoremedioCheckBox.Checked = false;
            restricaoremedioObsTextBox.Clear();
            nomemaeTextBox.Clear();
            cpfmaeMaskedTextBox.Clear();
            telcelmaeMaskedTextBox.Clear();
            emailmaeTextBox.Clear();
            nomepaiTextBox.Clear();
            cpfpaiMaskedTextBox.Clear();
            telcelpaiMaskedTextBox.Clear();
            emailpaiTextBox.Clear();
            responsavelComboBox.Text = "";
            nomerespTextBox.Clear();
            cpfrespMaskedTextBox.Clear();
            telcelrespMaskedTextBox.Clear();
            emailrespTextBox.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
            
        }

      
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Projeto aluno = new Projeto();
                if (txtNome.Text == "" || txtdatanascimento.Text == "" || txtgenero.Text == "" ||
                enderecoTextBox.Text == "" || bairroTextBox.Text == "" || cidadeTextBox.Text == "" || ufComboBox.Text == "" ||
                cepMaskedTextBox.Text == "" || nomemaeTextBox.Text == "" || cpfmaeMaskedTextBox.Text == "" ||
                telcelmaeMaskedTextBox.Text == "" || emailmaeTextBox.Text == "" || nomepaiTextBox.Text == "" ||
                cpfpaiMaskedTextBox.Text == "" || telcelpaiMaskedTextBox.Text == "" || emailpaiTextBox.Text == "" ||
                responsavelComboBox.Text == "" || nomerespTextBox.Text == "" || cpfrespMaskedTextBox.Text == "" ||
                telcelrespMaskedTextBox.Text == "" || emailrespTextBox.Text == "")
                {
                    MessageBox.Show("É obrigatório preencher os campos com *.");
                    return;
                }
                else
                {
                    aluno.Nome = txtNome.Text;
                    aluno.DatadeNascimento = Convert.ToDateTime(txtdatanascimento.Text);
                    aluno.Sexo = txtgenero.Text;
                    aluno.Endereco = enderecoTextBox.Text;
                    aluno.Numero = Convert.ToInt16(numeroTextBox.Text);
                    aluno.Bairro = bairroTextBox.Text;
                    aluno.Cidade = cidadeTextBox.Text;
                    aluno.Estado = ufComboBox.Text;
                    aluno.CEP = cepMaskedTextBox.Text;
                    aluno.TelFixo = telfixoMaskedTextBox.Text;
                    //aluno.RestricaoAlimentar = Convert.ToBoolean(restricaoalimentarCheckBox.Text);
                    aluno.RestricaoAlimObs = restricaoalimObsTextBox.Text;
                    //aluno.RestricaoRemedio = Convert.ToBoolean(restricaoremedioCheckBox.Text);
                    aluno.RestricaoRemedioObs = restricaoremedioObsTextBox.Text;
                    aluno.NomeMae = nomemaeTextBox.Text;
                    aluno.CPFmae = cpfmaeMaskedTextBox.Text;
                    aluno.TelCelMae = telcelmaeMaskedTextBox.Text;
                    aluno.Emailmae = emailmaeTextBox.Text;
                    aluno.NomePai = nomepaiTextBox.Text;
                    aluno.CPFpai = cpfpaiMaskedTextBox.Text;
                    aluno.TelCelPai = telcelpaiMaskedTextBox.Text;
                    aluno.Emailpai = emailpaiTextBox.Text;
                    aluno.Responsavel = responsavelComboBox.Text;
                    aluno.NomeResp = nomerespTextBox.Text;
                    aluno.CPFResp = cpfrespMaskedTextBox.Text;
                    aluno.TelCelResp = telcelrespMaskedTextBox.Text;
                    aluno.Emailresp = emailrespTextBox.Text;

                    String strConexao = @"Data Source=MARANGONI-PC\MSSQLSERVERDEV;Initial Catalog=bdEstSaber;Integrated Security=True";
                    Conexao conexao = new Conexao(strConexao);
                    DALProjeto dal = new DALProjeto(conexao);
                    if (this.operacao == "inserir")
                    {
                        dal.Incluir(aluno);
                        MessageBox.Show("Aluno Inserido com sucesso!\nO código gerado foi: " + aluno.Codigo.ToString());

                    }
                    else
                    {
                        aluno.Codigo = Convert.ToInt16(txtId.Text);
                        dal.Alterar(aluno);
                        MessageBox.Show("Aluno Alterado com sucesso!");
                    }
                    this.AlteraBotoes(1);
                    this.LimpaCampos();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void restricaoremedioCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (restricaoremedioCheckBox.Checked == true)
            {
                restricaoremedioObsTextBox.Enabled = true;
            }
            else
            {
                restricaoremedioObsTextBox.Enabled = false;
            }
        }

        private void restricaoalimentarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (restricaoalimentarCheckBox.Checked == true)
            {
                restricaoalimObsTextBox.Enabled = true;
            }
            else
            {
                restricaoalimObsTextBox.Enabled = false;
            }
        }

        private void responsavelComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (responsavelComboBox.Text == "Mãe")
            {
                nomerespTextBox.Clear();
                cpfrespMaskedTextBox.Clear();
                telcelrespMaskedTextBox.Clear();
                emailrespTextBox.Clear();
                nomerespTextBox.Text = nomemaeTextBox.Text;
                cpfrespMaskedTextBox.Text = cpfmaeMaskedTextBox.Text;
                telcelrespMaskedTextBox.Text = telcelmaeMaskedTextBox.Text;
                emailrespTextBox.Text = emailmaeTextBox.Text;
                nomerespTextBox.Enabled = false;
                cpfrespMaskedTextBox.Enabled = false;
                telcelrespMaskedTextBox.Enabled = false;
                emailrespTextBox.Enabled = false;
            }
            else if (responsavelComboBox.Text == "Pai")
            {
                nomerespTextBox.Clear();
                cpfrespMaskedTextBox.Clear();
                telcelrespMaskedTextBox.Clear();
                emailrespTextBox.Clear();
                nomerespTextBox.Text = nomepaiTextBox.Text;
                cpfrespMaskedTextBox.Text = cpfpaiMaskedTextBox.Text;
                telcelrespMaskedTextBox.Text = telcelpaiMaskedTextBox.Text;
                emailrespTextBox.Text = emailpaiTextBox.Text;
                nomerespTextBox.Enabled = false;
                cpfrespMaskedTextBox.Enabled = false;
                telcelrespMaskedTextBox.Enabled = false;
                emailrespTextBox.Enabled = false;
            }
            else
            {
                nomerespTextBox.Clear();
                cpfrespMaskedTextBox.Clear();
                telcelrespMaskedTextBox.Clear();
                emailrespTextBox.Clear();
                nomerespTextBox.Focus();
                nomerespTextBox.Enabled = true;
                cpfrespMaskedTextBox.Enabled = true;
                telcelrespMaskedTextBox.Enabled = true;
                emailrespTextBox.Enabled = true;
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            ConsAlunos loc = new ConsAlunos();
            loc.ShowDialog();
            if(loc.codigo != 0)
            {
                String strConexao = @"Data Source=MARANGONI-PC\MSSQLSERVERDEV;Initial Catalog=bdEstSaber;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALProjeto dal = new DALProjeto(conexao);
                Projeto projeto = dal.carregaContato(loc.codigo);
                txtId.Text = projeto.Codigo.ToString();
                txtNome.Text = projeto.Nome;
                txtdatanascimento.Text = projeto.DatadeNascimento.ToString();
                txtgenero.Text = projeto.Sexo.ToString();
                enderecoTextBox.Text = projeto.Endereco;
                numeroTextBox.Text = projeto.Numero.ToString();
                bairroTextBox.Text = projeto.Bairro;
                cidadeTextBox.Text = projeto.Cidade;
                ufComboBox.Text = projeto.Estado;
                cepMaskedTextBox.Text = projeto.CEP;
                telfixoMaskedTextBox.Text = projeto.TelFixo;
                restricaoalimentarCheckBox.Checked = projeto.RestricaoAlimentar;
                restricaoalimObsTextBox.Text = projeto.RestricaoAlimObs;
                restricaoremedioCheckBox.Checked = projeto.RestricaoRemedio;
                restricaoremedioObsTextBox.Text = projeto.RestricaoRemedioObs;
                nomemaeTextBox.Text = projeto.NomeMae;
                cpfmaeMaskedTextBox.Text = projeto.CPFmae;
                telcelmaeMaskedTextBox.Text = projeto.TelCelMae;
                emailmaeTextBox.Text = projeto.Emailmae;
                nomepaiTextBox.Text = projeto.NomePai;
                cpfpaiMaskedTextBox.Text = projeto.CPFpai;
                telcelpaiMaskedTextBox.Text = projeto.TelCelPai;
                emailpaiTextBox.Text = projeto.Emailpai;
                responsavelComboBox.Text = projeto.Responsavel;
                nomerespTextBox.Text = projeto.NomeResp;
                cpfrespMaskedTextBox.Text = projeto.CPFResp;
                telcelrespMaskedTextBox.Text = projeto.TelCelResp;
                emailrespTextBox.Text = projeto.Emailresp;
                this.AlteraBotoes(3);
            }
            loc.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja Excluir o registro", "Aviso", MessageBoxButtons.YesNo);
            if(d.ToString() == "Yes")
            {
                String strConexao = @"Data Source=MARANGONI-PC\MSSQLSERVERDEV;Initial Catalog=bdEstSaber;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALProjeto dal = new DALProjeto(conexao);
                dal.Excluir(Convert.ToInt16(txtId.Text));
                this.AlteraBotoes(1);
                this.LimpaCampos();
            }
        }
    }
}