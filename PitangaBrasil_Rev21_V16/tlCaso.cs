using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PitangaBrasil
{
    public partial class tlCaso : Form
    {
        public tlCaso()
        {
            InitializeComponent();

            //Verifica qual tema foi selecionado e altera as labels com o texto correspondente
            switch (Global.gbIndexTema)
            {
                case 0:
                    lbMateria.Text = "Importação";
                    lbCaso.Text = "A empresa Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa" +
                        " chamada Flip Flop Art, localizada na cidade de Bogotá na Colômbia. Essa empresa foi fundada há 2 anos," +
                        " diante de uma oportunidade de parceria com a Pitanga Brasil. Após a confirmação do pedido, a empresa" +
                        " recorreu ao mercado para buscar um fornecedor ecologicamente responsável, com uma cadeia de Supply" +
                        " Chain forte e uma precificação atrativa. Diante disso:";
                    break;
                case 3:
                    lbMateria.Text = "Marketing";
                    lbCaso.Text = "A Pitanga Brasil recebeu uma encomenda de 1.500 pares de chinelos de uma empresa chamada" +
                        " Flip-Flop Art, que está há 2 anos no mercado e está localizada na cidade de Bogotá, na Colômbia." +
                        " Visando a expansão de sua marca no mercado colombiano, a Pitanga Brasil possui uma oportunidade de" +
                        " parceria.";
                    break;
                case 6:
                    lbMateria.Text = "Financeiro";
                    lbCaso.Text = "A empresa Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa" +
                        " chamada Flip Flop Art, localizada na cidade de Bogotá, na Colômbia. Essa empresa foi fundada a 2 anos," +
                        " diante de uma oportunidade de parceria com a Pitanga Brasil que busca expansão das vendas.";
                    break;
                case 9:
                    lbMateria.Text = "Jurídico";
                    lbCaso.Text = "A Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa chamada" +
                        " Flip Flop Art, localizada na cidade de Bogotá, na Colômbia. Essa empresa foi fundada a 2 anos, diante" +
                        " de uma oportunidade de parceria com a Pitanga Brasil que busca expansão das vendas neste mercado." +
                        " Atenção: A Pitanga Brasil presa pela segurança no transporte de seus produtos.";
                    break;
                case 12:
                    lbMateria.Text = "Exportação";
                    lbCaso.Text = "A empresa Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa" +
                        " chamada Flip Flop Art, localizada na cidade de Bogotá, na Colômbia. Essa empresa foi fundada a 2 anos," +
                        " diante de uma oportunidade de parceria com a Pitanga Brasil que busca expansão das vendas.";
                    break;
                case 15:
                    lbMateria.Text = "Recursos Humanos";
                    lbCaso.Text = "A empresa Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa" +
                        " chamada Flip Flop Art, localizada na cidade de Bogotá, na Colômbia. Essa empresa foi fundada a 2 anos," +
                        " diante de uma oportunidade de parceria com a Pitanga Brasil que busca expansão das vendas. Um dos" +
                        " fatores principais para a excelência nesta parceria é a mão de obra qualificada.";
                    break;

            }
        }

        private void BtProximo_Click(object sender, EventArgs e)
        {
            //Muda para a tela Pergunta Caso e carrega uma pergunta;
            tlPerguntaCaso Tela_PerguntaCaso = new tlPerguntaCaso();
            Tela_PerguntaCaso.ShowDialog();
            Close();
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            var lcFechar = MessageBox.Show("Seu progresso será perdido. \n Tem certeza que deseja sair?", "Fechar Jogo", MessageBoxButtons.YesNo);
            if (lcFechar == DialogResult.Yes)
                Close();
        }
    }
}
