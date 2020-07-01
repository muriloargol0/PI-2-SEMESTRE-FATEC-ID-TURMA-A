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
    public partial class tlFeedback : Form
    {
        public tlFeedback()
        {
            InitializeComponent();

            //Verifica a pontuação e atualiza a variável com texto do feedback
            if (Global.gbImagem >= 70)
                lbFeedback.Text = "EXCELENTE! Parabéns! Você tornou a Pitanga Brasil uma empresa mais conhecida no mercado" +
                    " internacional, com muita credibilidade! Você é um grande conhecedor dos conteúdos relacionados ao Comércio" +
                    " Exterior, o que contribuiu para o sucesso da empresa! A Pitanga Brasil conseguiu expandir sua marca graças" +
                    " a você!";
            else if (Global.gbImagem >= 10)
                lbFeedback.Text = "SATISFATÓRIO! Você estava à ponto de obter um grande resultado e excelência na expansão da" +
                    " marca da Pitanga Brasil no mercado internacional, porém, alguns deslizes não tornaram isso possível!" +
                    " Se atente!";
            else if (Global.gbImagem >= -19)
                lbFeedback.Text = "NÃO SATISFATÓRIO! Você desconhece alguns pontos cruciais para o Comércio Exterior, o que" +
                    " prejudicou a expansão da marca da Pitanga Brasil no mercado internacional! Estude mais um pouco e tente" +
                    " novamente!";
            else
                lbFeedback.Text = "NADA SATISFATÓRIO! Que pena! Ao invés de ajudar a Pitanga Brasil você prejudicou a imagem" +
                    " da empresa no mercado internacional. Agora, será difícil recuperar toda a credibilidade necessária para" +
                    " que a empresa obtenha sucesso no exterior! Estude muito e tente novamente!";
        }

        private void BtRanking_Click(object sender, EventArgs e)
        {
            //Carrega o ranking completo e avança para a tela Ranking
            tlRanking Tela_Ranking = new tlRanking();
            Tela_Ranking.ShowDialog();
            Close();
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            var lcFechar = MessageBox.Show("Tem certeza que deseja sair?", "Fechar Jogo", MessageBoxButtons.YesNo);
            if (lcFechar == DialogResult.Yes)
                Close();
        }
    }
}
