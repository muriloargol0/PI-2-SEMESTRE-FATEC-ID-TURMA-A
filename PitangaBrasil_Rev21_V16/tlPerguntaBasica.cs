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

    public partial class tlPerguntaBasica : Form
    {
        int lcSelecao = 0x00, //Variável para armazenar qual alternativa foi selecionada        - Local
            lcIndex = 0x00; //Variável para sortear qual Pergunta Básica será realizada         - Local

        public tlPerguntaBasica()
        {
            InitializeComponent();

            //Sorteia Pergunta Básica a ser realizada
            Random rnd = new Random();
            lcIndex = rnd.Next(0, Global.gbPerguntaBasica.Count);

            //Altera labels para os textos da Pergunta Básica sorteada
            lbPergunta.Text = Global.gbPerguntaBasica[lcIndex];
            lbAlternativaA.Text = ("A) " + Global.gbAlternativaA[lcIndex]);
            lbAlternativaB.Text = ("B) " + Global.gbAlternativaB[lcIndex]);
            lbAlternativaC.Text = ("C) " + Global.gbAlternativaC[lcIndex]);

            //Atualiza labels de Caixa e Imagem
            lbCaixa.Text = "Dinheiro em caixa: R$ " + Global.gbCaixa.ToString() + ".00";
            lbPontos.Text = "Pontos de imagem: " + Global.gbImagem.ToString() + " pontos";

            //Zera variável que armazena qual alternativa foi selecionada
            lcSelecao = 0x00;
        }

        //=======================================================================================================================================

        //Atualiza formatação de texto conforme seleção da alternativa
        private void lbAlternativaA_Click(object sender, EventArgs e)
        {
            lcSelecao = 1;
            lbAlternativaA.Font = new Font(lbAlternativaA.Font, FontStyle.Bold);
            lbAlternativaB.Font = new Font(lbAlternativaB.Font, FontStyle.Regular);
            lbAlternativaC.Font = new Font(lbAlternativaC.Font, FontStyle.Regular);
        }

        private void lbAlternativaB_Click(object sender, EventArgs e)
        {
            lcSelecao = 2;
            lbAlternativaB.Font = new Font(lbAlternativaB.Font, FontStyle.Bold);
            lbAlternativaA.Font = new Font(lbAlternativaA.Font, FontStyle.Regular);
            lbAlternativaC.Font = new Font(lbAlternativaC.Font, FontStyle.Regular);
        }

        private void lbAlternativaC_Click(object sender, EventArgs e)
        {
            lcSelecao = 3;
            lbAlternativaC.Font = new Font(lbAlternativaC.Font, FontStyle.Bold);
            lbAlternativaA.Font = new Font(lbAlternativaA.Font, FontStyle.Regular);
            lbAlternativaB.Font = new Font(lbAlternativaB.Font, FontStyle.Regular);
        }
        //=======================================================================================================================================

        private void BtSelecionar_Click(object sender, EventArgs e)
        {
            //Verifica se alguma alternativa foi selecionada
            if (lcSelecao == 0)
            {
                MessageBox.Show("Selecione uma das alternativas.","Aviso");     //Pop-up pedindo para selecionar alternativa
            }

            else
            {
                //Verifica se resposta está certa ou errada
                if (lcSelecao == Global.gbResposta[lcIndex])
                {
                    Global.gbCaixa += 500;                                      //Soma R$500,00 ao caixa
                    MessageBox.Show("Resposta certa!","Feedback");              //Pop-up de resposta certa
                }
                else
                {
                    MessageBox.Show("Resposta errada!", "Feedback");            //Pop-up de resposta errada
                }

                //Remove pergunta realizada do vetor de Perguntas Básicas
                Global.gbPerguntaBasica.RemoveAt(lcIndex);

                //Remove alternativa da pergunta realizada do vetor de Alternativas "A"
                Global.gbAlternativaA.RemoveAt(lcIndex);

                //Remove alternativa da pergunta realizada do vetor de Alternativas "B"
                Global.gbAlternativaB.RemoveAt(lcIndex);

                //Remove alternativa da pergunta realizada do vetor de Alternativas "C"
                Global.gbAlternativaC.RemoveAt(lcIndex);

                //Remove posição de resposta da pergunta realizada do vetor Respostas
                Global.gbResposta.RemoveAt(lcIndex);

                //Adiciona ao contador de Pergunta Básica
                Global.gbContadorBasica++;

                if(Global.gbContadorBasica == 3)
                {
                    //Avança para a tela Matérias
                    Global.gbContadorBasica = 0;
                    tlMaterias Tela_Materias = new tlMaterias();
                    Tela_Materias.ShowDialog();
                    Close();
                }
                else
                {
                    //Retorna para a tela Pergunta Básica
                    tlPerguntaBasica Tela_PerguntaBasica = new tlPerguntaBasica();
                    Tela_PerguntaBasica.ShowDialog();
                    Close();
                }

                
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
