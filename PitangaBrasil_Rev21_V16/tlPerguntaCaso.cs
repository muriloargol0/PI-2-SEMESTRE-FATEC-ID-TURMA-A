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
    public partial class tlPerguntaCaso : Form
    {
        int lcSelecao   = 0x00, //Variável para armazenar qual alternativa foi selecionada                      - Local
            lcContador  = 0x00; //Variável para verificar quantas perguntas foram realizadas sobre o tema       - Local

        public tlPerguntaCaso()
        {
            InitializeComponent();

            //Atualiza labels de Caixa e Imagem
            lbCaixa.Text = "Dinheiro em caixa: R$ " + Global.gbCaixa.ToString() + ".00";
            lbPontos.Text = "Pontos de imagem: " + Global.gbImagem.ToString() + " pontos";

            //Inicializa o contador conforme tema escolhido e altera as labels
            lcContador = Global.gbIndexTema + Global.gbContadorCaso;
            lbPergunta.Text = Global.gbPerguntaCaso[lcContador];
            lbAlternativaA.Text = Global.gbAlternativaCaso1[lcContador];
            lbAlternativaB.Text = Global.gbAlternativaCaso2[lcContador];
            lbAlternativaC.Text = Global.gbAlternativaCaso3[lcContador];
            lbAlternativaD.Text = Global.gbAlternativaCaso4[lcContador];
        }

        //=======================================================================================================================================

        //Atualiza formatação de texto conforme seleção da alternativa
        private void LbAlternativaA_Click(object sender, EventArgs e)
        {
            lcSelecao = 1;
            lbAlternativaA.Font = new Font(lbAlternativaA.Font, FontStyle.Bold);
            lbAlternativaB.Font = new Font(lbAlternativaB.Font, FontStyle.Regular);
            lbAlternativaC.Font = new Font(lbAlternativaC.Font, FontStyle.Regular);
            lbAlternativaD.Font = new Font(lbAlternativaC.Font, FontStyle.Regular);
        }

        private void LbAlternativaB_Click(object sender, EventArgs e)
        {
            lcSelecao = 2;
            lbAlternativaA.Font = new Font(lbAlternativaA.Font, FontStyle.Regular);
            lbAlternativaB.Font = new Font(lbAlternativaB.Font, FontStyle.Bold);
            lbAlternativaC.Font = new Font(lbAlternativaC.Font, FontStyle.Regular);
            lbAlternativaD.Font = new Font(lbAlternativaC.Font, FontStyle.Regular);
        }

        private void LbAlternativaC_Click(object sender, EventArgs e)
        {
            lcSelecao = 3;
            lbAlternativaA.Font = new Font(lbAlternativaA.Font, FontStyle.Regular);
            lbAlternativaB.Font = new Font(lbAlternativaB.Font, FontStyle.Regular);
            lbAlternativaC.Font = new Font(lbAlternativaC.Font, FontStyle.Bold);
            lbAlternativaD.Font = new Font(lbAlternativaC.Font, FontStyle.Regular);
        }

        private void LbAlternativaD_Click(object sender, EventArgs e)
        {
            lcSelecao = 4;
            lbAlternativaA.Font = new Font(lbAlternativaA.Font, FontStyle.Regular);
            lbAlternativaB.Font = new Font(lbAlternativaB.Font, FontStyle.Regular);
            lbAlternativaC.Font = new Font(lbAlternativaC.Font, FontStyle.Regular);
            lbAlternativaD.Font = new Font(lbAlternativaC.Font, FontStyle.Bold);
        }
        //=======================================================================================================================================

        private void BtSelecionar_Click(object sender, EventArgs e)
        {
            //Verifica se nenhuma alternativa foi selecionada
            if (lcSelecao == 0)
            {
                MessageBox.Show("Selecione uma das alternativas.", "Aviso"); //Pop-up pedindo para selecionar alternativa
            }

            else
            {
                //Atruibui as informações nas variáveis globais conforme alternativa selecionada
                switch (lcSelecao)
                {
                    case 1:
                        Global.gbRespostaCaso = Global.gbAlternativaCaso1[lcContador];
                        Global.gbConsequenciaCaso = Global.gbConsequencia1[lcContador];
                        Global.gbCaixa += Global.gbDinheiro1[lcContador];
                        Global.gbImagem += Global.gbImagem1[lcContador];
                        break;
                    case 2:
                        Global.gbRespostaCaso = Global.gbAlternativaCaso2[lcContador];
                        Global.gbConsequenciaCaso = Global.gbConsequencia2[lcContador];
                        Global.gbCaixa += Global.gbDinheiro2[lcContador];
                        Global.gbImagem += Global.gbImagem2[lcContador];
                        break;
                    case 3:
                        Global.gbRespostaCaso = Global.gbAlternativaCaso3[lcContador];
                        Global.gbConsequenciaCaso = Global.gbConsequencia3[lcContador];
                        Global.gbCaixa += Global.gbDinheiro3[lcContador];
                        Global.gbImagem += Global.gbImagem3[lcContador];
                        break;
                    case 4:
                        Global.gbRespostaCaso = Global.gbAlternativaCaso4[lcContador];
                        Global.gbConsequenciaCaso = Global.gbConsequencia4[lcContador];
                        Global.gbCaixa += Global.gbDinheiro4[lcContador];
                        Global.gbImagem += Global.gbImagem4[lcContador];
                        break;
                }
                
                //Aumenta o contador de perguntas respondidas
                Global.gbContadorCaso++;

                //Avança para a tela de Resposta Caso
                tlRespostaCaso Tela_RespostaCaso = new tlRespostaCaso();
                Tela_RespostaCaso.ShowDialog();
                Close();
            }
        }

        private void BtCaso_Click(object sender, EventArgs e)
        {
            //Abre um pop up com o texto do caso atual
            switch (Global.gbIndexTema)
            {
                case 0:
                    MessageBox.Show("A empresa Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa" +
                        " chamada Flip Flop Art, localizada na cidade de Bogotá na Colômbia. Essa empresa foi fundada há 2 anos," +
                        " diante de uma oportunidade de parceria com a Pitanga Brasil. Após a confirmação do pedido, a empresa" +
                        " recorreu ao mercado para buscar um fornecedor ecologicamente responsável, com uma cadeia de Supply" +
                        " Chain forte e uma precificação atrativa. Diante disso:", "Importação");
                    break;
                case 3:
                    MessageBox.Show("A Pitanga Brasil recebeu uma encomenda de 1.500 pares de chinelos de uma empresa chamada" +
                        " Flip-Flop Art, que está há 2 anos no mercado e está localizada na cidade de Bogotá, na Colômbia." +
                        " Visando a expansão de sua marca no mercado colombiano, a Pitanga Brasil possui uma oportunidade de" +
                        " parceria.", "Marketing");
                    break;
                case 6:
                    MessageBox.Show("A empresa Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa" +
                        " chamada Flip Flop Art, localizada na cidade de Bogotá, na Colômbia. Essa empresa foi fundada a 2 anos," +
                        " diante de uma oportunidade de parceria com a Pitanga Brasil que busca expansão das vendas.", "Financeiro");
                    break;
                case 9:
                    MessageBox.Show("A Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa chamada" +
                        " Flip Flop Art, localizada na cidade de Bogotá, na Colômbia. Essa empresa foi fundada a 2 anos, diante" +
                        " de uma oportunidade de parceria com a Pitanga Brasil que busca expansão das vendas neste mercado." +
                        " Atenção: A Pitanga Brasil presa pela segurança no transporte de seus produtos.", "Jurídico");
                    break;
                case 12:
                    MessageBox.Show("A empresa Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa" +
                        " chamada Flip Flop Art, localizada na cidade de Bogotá, na Colômbia. Essa empresa foi fundada a 2 anos," +
                        " diante de uma oportunidade de parceria com a Pitanga Brasil que busca expansão das vendas.","Exportação");
                    break;
                case 15:
                    MessageBox.Show("A empresa Pitanga Brasil recebeu uma encomenda de 1.000 pares de chinelos de uma empresa" +
                        " chamada Flip Flop Art, localizada na cidade de Bogotá, na Colômbia. Essa empresa foi fundada a 2 anos," +
                        " diante de uma oportunidade de parceria com a Pitanga Brasil que busca expansão das vendas. Um dos" +
                        " fatores principais para a excelência nesta parceria é a mão de obra qualificada.","Recursos Humanos");
                    break;
            }
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
