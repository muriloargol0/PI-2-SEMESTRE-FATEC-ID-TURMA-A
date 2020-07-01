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
    public partial class tlRespostaCaso : Form
    {
        public tlRespostaCaso()
        {
            InitializeComponent();

            //Atualiza labels de Caixa e Imagem
            lbCaixa.Text = "Dinheiro em caixa: R$ " + Global.gbCaixa.ToString() + ".00";
            lbPontos.Text = "Pontos de imagem: " + Global.gbImagem.ToString() + " pontos";

            //Atualiza labels conforme alternativa selecionada
            lbFeedbackAlternativa.Text = Global.gbRespostaCaso + "\n" + "\n" + Global.gbConsequenciaCaso;
        }

        private void BtProximo_Click(object sender, EventArgs e)
        {
            //Verifica se todas as perguntas de caso foram respondidas para aquele tema
            if (Global.gbContadorCaso == 0x03)
            {
                //Verifica se todos os temas foram jogados
                if (Global.gbExportacao == 2 && Global.gbImportacao == 2 && Global.gbFinanceiro == 2 &&
                Global.gbJuridico == 2 && Global.gbMarketing == 2 && Global.gbRecursosHumanos == 2)
                {
                    //Avança para a tela de Resultado
                    tlResultado Tela_Resultado = new tlResultado();
                    Tela_Resultado.ShowDialog();
                    Close();
                }
                else
                {
                    //Zera a variável de contador de perguntas de caso
                    Global.gbContadorCaso = 0x00;

                    //Avança para a tela de Pergunta Básica
                    tlPerguntaBasica Tela_PerguntaBasica = new tlPerguntaBasica();
                    Tela_PerguntaBasica.ShowDialog();
                    Close();
                }
            }
            else
            {
                //Avança para a tela de Pergunta Caso
                tlPerguntaCaso Tela_PerguntaCaso = new tlPerguntaCaso();
                Tela_PerguntaCaso.ShowDialog();
                Close();
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
