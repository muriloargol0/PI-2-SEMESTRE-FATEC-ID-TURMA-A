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
    public partial class MenuConsulta : UserControl
    {
        public MenuConsulta()
        {
            InitializeComponent();
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            ConsultaCliente cliente = new ConsultaCliente();
            cliente.ShowDialog();
        }

        private void btVeiculo_Click(object sender, EventArgs e)
        {
            ConsultaVeiculo veiculo = new ConsultaVeiculo();
            veiculo.ShowDialog();
        }

        private void btFuncionário_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario funcionario = new ConsultaFuncionario();
            funcionario.ShowDialog();
        }

        private void btGastos_Click(object sender, EventArgs e)
        {
            ConsultaDespesa despesa = new ConsultaDespesa();
            despesa.ShowDialog();
        }

        private void btAgenda_Click(object sender, EventArgs e)
        {
            ConsultaAgendar agenda = new ConsultaAgendar();
            agenda.ShowDialog();
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            ConsultaPagamento pag = new ConsultaPagamento();
            pag.ShowDialog();
        }
    }
}
