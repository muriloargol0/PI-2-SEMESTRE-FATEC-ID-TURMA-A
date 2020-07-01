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
    public partial class tlPlay : Form
    {
        public tlPlay()
        {
            InitializeComponent();
        }

        private void BtPlay_Click(object sender, EventArgs e)
        {
            //Avança para a tela Pergunta Básica
            tlPerguntaBasica Tela_PerguntaBasica = new tlPerguntaBasica();
            Tela_PerguntaBasica.ShowDialog();
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
