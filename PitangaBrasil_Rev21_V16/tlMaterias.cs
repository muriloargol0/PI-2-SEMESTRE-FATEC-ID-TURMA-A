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
    public partial class tlMaterias : Form
    {
        public tlMaterias()
        {
            InitializeComponent();

            //=======================================================================================================================================

            //Verifica status do botão Exportação
            switch (Global.gbExportacao)
            {
                case 0: //Confirma cor original do botão
                    btExportacao.BackgroundImage = Properties.Resources.imgPurple;
                    break;
                case 2: //Muda cor do botão para cinza e o disabilita
                    {
                        btExportacao.BackgroundImage = Properties.Resources.imgGrey;
                        btExportacao.Enabled = false;
                        break;
                    }
            }

            //=======================================================================================================================================

            //Verifica status do botão Importação
            switch (Global.gbImportacao)
            {
                case 0: //Confirma cor original do botão
                    btImportacao.BackgroundImage = Properties.Resources.imgBlue;
                    break;
                case 2: //Muda cor do botão para cinza e o disabilita
                    {
                        btImportacao.BackgroundImage = Properties.Resources.imgGrey;
                        btImportacao.Enabled = false;
                        break;
                    }
            }

            //=======================================================================================================================================

            //Verifica status do botão Financeiro
            switch (Global.gbFinanceiro)
            {
                case 0: //Confirma cor original do botão
                    btFinanceiro.BackgroundImage = Properties.Resources.imgYellow;
                    break;
                case 2: //Muda cor do botão para cinza e o disabilita
                    {
                        btFinanceiro.BackgroundImage = Properties.Resources.imgGrey;
                        btFinanceiro.Enabled = false;
                        break;
                    }
            }

            //=======================================================================================================================================

            //Verifica status do botão Jurídico
            switch (Global.gbJuridico)
            {
                case 0: //Confirma cor original do botão
                    btJuridico.BackgroundImage = Properties.Resources.imgRed;
                    break;
                case 2: //Muda cor do botão para cinza e o disabilita
                    {
                        btJuridico.BackgroundImage = Properties.Resources.imgGrey;
                        btJuridico.Enabled = false;
                        break;
                    }
            }

            //=======================================================================================================================================

            //Verifica status do botão Marketing
            switch (Global.gbMarketing)
            {
                case 0: //Confirma cor original do botão
                    btMarketing.BackgroundImage = Properties.Resources.imgLightBlue;
                    break;
                case 2: //Muda cor do botão para cinza e o disabilita
                    {
                        btMarketing.BackgroundImage = Properties.Resources.imgGrey;
                        btMarketing.Enabled = false;
                        break;
                    }
            }

            //=======================================================================================================================================

            //Verifica status do botão Recursos Humanos
            switch (Global.gbRecursosHumanos)
            {
                case 0: //Confirma cor original do botão
                    btRecursosHumanos.BackgroundImage = Properties.Resources.imgOrange;
                    break;
                case 2: //Muda cor do botão para cinza e o disabilita
                    {
                        btRecursosHumanos.BackgroundImage = Properties.Resources.imgGrey;
                        btRecursosHumanos.Enabled = false;
                        break;
                    }
            }

            //=======================================================================================================================================

        }

        int cont = 0; //Variável para status do botão
        private void btExportacao_Click(object sender, EventArgs e)
        {
            //Confirma se outro botão foi pressionado e o reseta
            if (Global.gbImportacao == 1)
            {
                btImportacao.BackgroundImage = Properties.Resources.imgBlue;
                Global.gbImportacao = 0;
            }

            if (Global.gbFinanceiro == 1)
            {
                btFinanceiro.BackgroundImage = Properties.Resources.imgYellow;
                Global.gbFinanceiro = 0;
            }

            if (Global.gbJuridico == 1)
            {
                btJuridico.BackgroundImage = Properties.Resources.imgRed;
                Global.gbJuridico = 0;
            }

            if (Global.gbMarketing == 1)
            {
                btMarketing.BackgroundImage = Properties.Resources.imgLightBlue;
                Global.gbMarketing = 0;
            }

            if (Global.gbRecursosHumanos == 1)
            {
                btRecursosHumanos.BackgroundImage = Properties.Resources.imgOrange;
                Global.gbRecursosHumanos = 0;
            }

            //Confirma se o botão Exportação já estava pressionado, altera variável e avança para a tela Caso
            if (Global.gbExportacao == 1)
            {
                Global.gbExportacao = 2;
                Global.gbIndexTema = 12;
                tlCaso Tela_Caso = new tlCaso();
                Tela_Caso.ShowDialog();
                this.Close();
            }

            //Altera a variável e muda a cor do botão para verde
            else
            {
                Global.gbExportacao = 1;
                btExportacao.BackgroundImage = Properties.Resources.imgGreen;
            }
        }

        //=======================================================================================================================================

        private void btImportacao_Click(object sender, EventArgs e)
        {
            //Confirma se outro botão foi pressionado e o reseta
            if (Global.gbExportacao == 1)
            {
                btExportacao.BackgroundImage = Properties.Resources.imgPurple;
                Global.gbExportacao = 0;
            }

            if (Global.gbFinanceiro == 1)
            {
                btFinanceiro.BackgroundImage = Properties.Resources.imgYellow;
                Global.gbFinanceiro = 0;
            }

            if (Global.gbJuridico == 1)
            {
                btJuridico.BackgroundImage = Properties.Resources.imgRed;
                Global.gbJuridico = 0;
            }

            if (Global.gbMarketing == 1)
            {
                btMarketing.BackgroundImage = Properties.Resources.imgLightBlue;
                Global.gbMarketing = 0;
            }

            if (Global.gbRecursosHumanos == 1)
            {
                btRecursosHumanos.BackgroundImage = Properties.Resources.imgOrange;
                Global.gbRecursosHumanos = 0;
            }

            //Confirma se o botão Exportação já estava pressionado, altera variável e avança para a tela Caso
            if (Global.gbImportacao == 1)
            {
                Global.gbImportacao = 2;
                Global.gbIndexTema = 0;
                tlCaso Tela_Caso = new tlCaso();
                Tela_Caso.ShowDialog();
                this.Close();
            }

            //Altera a variável e muda a cor do botão para verde
            else
            {
                Global.gbImportacao = 1;
                btImportacao.BackgroundImage = Properties.Resources.imgGreen;
            }
        }

        //=======================================================================================================================================

        private void btFinanceiro_Click(object sender, EventArgs e)
        {
            //Confirma se outro botão foi pressionado e o reseta
            if (Global.gbExportacao == 1)
            {
                btExportacao.BackgroundImage = Properties.Resources.imgPurple;
                Global.gbExportacao = 0;
            }

            if (Global.gbImportacao == 1)
            {
                btImportacao.BackgroundImage = Properties.Resources.imgBlue;
                Global.gbImportacao = 0;
            }

            if (Global.gbJuridico == 1)
            {
                btJuridico.BackgroundImage = Properties.Resources.imgRed;
                Global.gbJuridico = 0;
            }

            if (Global.gbMarketing == 1)
            {
                btMarketing.BackgroundImage = Properties.Resources.imgLightBlue;
                Global.gbMarketing = 0;
            }

            if (Global.gbRecursosHumanos == 1)
            {
                btRecursosHumanos.BackgroundImage = Properties.Resources.imgOrange;
                Global.gbRecursosHumanos = 0;
            }

            //Confirma se o botão Exportação já estava pressionado, altera variável e avança para a tela Caso
            if (Global.gbFinanceiro == 1)
            {
                Global.gbFinanceiro = 2;
                Global.gbIndexTema = 6;
                tlCaso Tela_Caso = new tlCaso();
                Tela_Caso.ShowDialog();
                this.Close();
            }

            //Altera a variável e muda a cor do botão para verde
            else
            {
                Global.gbFinanceiro = 1;
                btFinanceiro.BackgroundImage = Properties.Resources.imgGreen;
            }
        }

        //=======================================================================================================================================

        private void btJuridico_Click(object sender, EventArgs e)
        {
            //Confirma se outro botão foi pressionado e o reseta
            if (Global.gbExportacao == 1)
            {
                btExportacao.BackgroundImage = Properties.Resources.imgPurple;
                Global.gbExportacao = 0;
            }

            if (Global.gbImportacao == 1)
            {
                btImportacao.BackgroundImage = Properties.Resources.imgBlue;
                Global.gbImportacao = 0;
            }

            if (Global.gbFinanceiro == 1)
            {
                btFinanceiro.BackgroundImage = Properties.Resources.imgYellow;
                Global.gbFinanceiro = 0;
            }

            if (Global.gbMarketing == 1)
            {
                btMarketing.BackgroundImage = Properties.Resources.imgLightBlue;
                Global.gbMarketing = 0;
            }

            if (Global.gbRecursosHumanos == 1)
            {
                btRecursosHumanos.BackgroundImage = Properties.Resources.imgOrange;
                Global.gbRecursosHumanos = 0;
            }

            //Confirma se o botão Exportação já estava pressionado, altera variável e avança para a tela Caso
            if (Global.gbJuridico == 1)
            {
                Global.gbJuridico = 2;
                Global.gbIndexTema = 9;
                tlCaso Tela_Caso = new tlCaso();
                Tela_Caso.ShowDialog();
                this.Close();
            }

            //Altera a variável e muda a cor do botão para verde
            else
            {
                Global.gbJuridico = 1;
                btJuridico.BackgroundImage = Properties.Resources.imgGreen;
            }
        }

        //=======================================================================================================================================

        private void btMarketing_Click(object sender, EventArgs e)
        {
            //Confirma se outro botão foi pressionado e o reseta
            if (Global.gbExportacao == 1)
            {
                btExportacao.BackgroundImage = Properties.Resources.imgPurple;
                Global.gbExportacao = 0;
            }

            if (Global.gbImportacao == 1)
            {
                btImportacao.BackgroundImage = Properties.Resources.imgBlue;
                Global.gbImportacao = 0;
            }

            if (Global.gbFinanceiro == 1)
            {
                btFinanceiro.BackgroundImage = Properties.Resources.imgYellow;
                Global.gbFinanceiro = 0;
            }

            if (Global.gbJuridico == 1)
            {
                btJuridico.BackgroundImage = Properties.Resources.imgRed;
                Global.gbJuridico = 0;
            }

            if (Global.gbRecursosHumanos == 1)
            {
                btRecursosHumanos.BackgroundImage = Properties.Resources.imgOrange;
                Global.gbRecursosHumanos = 0;
            }

            //Confirma se o botão Exportação já estava pressionado, altera variável e avança para a tela Caso
            if (Global.gbMarketing == 1)
            {
                Global.gbMarketing = 2;
                Global.gbIndexTema = 3;
                tlCaso Tela_Caso = new tlCaso();
                Tela_Caso.ShowDialog();
                this.Close();
            }

            //Altera a variável e muda a cor do botão para verde
            else
            {
                Global.gbMarketing = 1;
                btMarketing.BackgroundImage = Properties.Resources.imgGreen;
            }
        }

        //=======================================================================================================================================

        private void btRecursosHumanos_Click(object sender, EventArgs e)
        {
            //Confirma se outro botão foi pressionado e o reseta
            if (Global.gbExportacao == 1)
            {
                btExportacao.BackgroundImage = Properties.Resources.imgPurple;
                Global.gbExportacao = 0;
            }

            if (Global.gbImportacao == 1)
            {
                btImportacao.BackgroundImage = Properties.Resources.imgBlue;
                Global.gbImportacao = 0;
            }

            if (Global.gbFinanceiro == 1)
            {
                btFinanceiro.BackgroundImage = Properties.Resources.imgYellow;
                Global.gbFinanceiro = 0;
            }

            if (Global.gbJuridico == 1)
            {
                btJuridico.BackgroundImage = Properties.Resources.imgRed;
                Global.gbJuridico = 0;
            }

            if (Global.gbMarketing == 1)
            {
                btMarketing.BackgroundImage = Properties.Resources.imgLightBlue;
                Global.gbMarketing = 0;
            }

            //Confirma se o botão Exportação já estava pressionado, altera variável e avança para a tela Caso
            if (Global.gbRecursosHumanos == 1)
            {
                Global.gbRecursosHumanos = 2;
                Global.gbIndexTema = 15;
                tlCaso Tela_Caso = new tlCaso();
                Tela_Caso.ShowDialog();
                this.Close();
            }

            //Altera a variável e muda a cor do botão para verde
            else
            {
                Global.gbRecursosHumanos = 1;
                btRecursosHumanos.BackgroundImage = Properties.Resources.imgGreen;
            }
        }

        //=======================================================================================================================================

        private void BtFechar_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            var lcFechar = MessageBox.Show("Seu progresso será perdido. \n Tem certeza que deseja sair?", "Fechar Jogo", MessageBoxButtons.YesNo);
            if (lcFechar == DialogResult.Yes)
                Close();
        }
    }
}
