using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEscola
{
    public partial class MenuCadastro : UserControl
    {
        public MenuCadastro()
        {
            InitializeComponent();      
            
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cliente = new CadastroCliente();
            cliente.ShowDialog();

        }

        private void Funcionário_Click(object sender, EventArgs e)
        {
            CadastroFuncionario funcionario = new CadastroFuncionario();
            funcionario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroVeiculo veiculo = new CadastroVeiculo();
            veiculo.ShowDialog();
        }

        private void cadastroFuncionário1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroFuncionário1_Load_1(object sender, EventArgs e)
        {
        }

        private void MenuCadastro_Load(object sender, EventArgs e)
        {
        
        }

        private void cadastroCliente1_Load(object sender, EventArgs e)
        {

        }

        private void btDespesa_Click(object sender, EventArgs e)
        {
            CadastroDespesas despesa = new CadastroDespesas();
            despesa.ShowDialog();
        }

        private void btAgenda_Click(object sender, EventArgs e)
        {
            CadastroAgenda agenda = new CadastroAgenda();
            agenda.ShowDialog();
        }
    }
}
