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
    public partial class tlIntrodução : Form
    {
        short lcIntroducao = 0; //Variável para verificar qual tela está sendo exibida (0 = Introdução, 1 = Regras)

        public tlIntrodução()
        {
            InitializeComponent();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            //Verifica o valor da variável
            if (lcIntroducao == 0)
            {
                //Retorna para a tela Meun Inicial
                tlMenuInicial Tela_MenuInicial = new tlMenuInicial();
                Tela_MenuInicial.ShowDialog();
                this.Close();
            }

            else
            {
                //Altera texto para Tela Introdução e muda variável para 0
                lbTitulo.Text = "Introdução da Empresa";
                lbTexto1.Text = "A Pitanga Brasil é uma empresa que comercializa chinelos de borracha e atua no Brasil desde 2008. Para expandir seus negócios, decidiu exportar seus produtos.";
                lbTexto2.Text = "Todas as questões a seguir serão baseados em situações reais de mercado e problemáticas de comércio exterior.";
                lcIntroducao = 0;
            }
        }

        private void BtProximo_Click(object sender, EventArgs e)
        {
            //Verifica o valor da variável (1 = Avança para Tela Pergunta Básica)
            if (lcIntroducao == 1)
            {
                //Avança para a tela Pergunta Básica
                tlPlay Tela_Play = new tlPlay();
                Tela_Play.ShowDialog();
                Close();
            }

            //Verifica o valor da variável (0 = Altera texto para Tela Regras e muda variável para 1)
            else
            {
                lbTitulo.Text = "Como Jogar e Regras Básicas";
                lbTexto1.Text = "Cada resposta acarretará em consequências, resultando na perca ou ganho de dinheiro em caixa e/ou imagem da marca no mercado.";
                lbTexto2.Text = "Lembrando que não há resposta correta! Apenas situações mais apropriadas para a tomada de decisão. Ao final do jogo, o jogador receberá um feedback sobre seu desempenho.";
                lcIntroducao = 1;
            }
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            var lcFechar = MessageBox.Show("Tem certeza que deseja sair?", "Fechar Jogo", MessageBoxButtons.YesNo);
            if (lcFechar == DialogResult.Yes)
                Close();
        }

        private void EasterEgg_DoubleClick(object sender, EventArgs e)
        {
            //Função EasterEgg utilizada para testar design das telas finais do jogo, pulando o ciclo de perguntas rapidamente
            tlResultado Tela_Resultado = new tlResultado();
            Tela_Resultado.ShowDialog();
            Close();
        }
    }
}
