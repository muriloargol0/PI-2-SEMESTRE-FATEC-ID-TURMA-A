using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PitangaBrasil
{
    public partial class tlResultado : Form
    {
        public tlResultado()
        {
            InitializeComponent();

            //Atualiza labels de Caixa e Imagem
            lbCaixa.Text = "Dinheiro em caixa: R$ " + Global.gbCaixa.ToString() + ".00";
            lbPontos.Text = "Pontos de imagem: " + Global.gbImagem.ToString() + " pontos";

        }

        private void BtFeedback_Click(object sender, EventArgs e)
        {
            //Verifica se nenhum nickname foi digitado
            if(tbNickname.Text == "")
            {
                MessageBox.Show("Favor inserir um nickname.", "Aviso");
            }

            //Verifica se o nickname inserido foi muito extenso
            else if(tbNickname.Text.Length >= 46)
            {
                MessageBox.Show("Nickname deve conter no máximo 45 caracteres.");
            }
            else
            {
                //Armazena nickname na variável global
                Global.gbNickname = tbNickname.Text;

                //Realiza comunicação com o banco de dados e armazena nickname, caixa e pontuação de imagem
                try
                {
                    MySqlConnection objcon = new MySqlConnection("server=mysql-10255-0.cloudclusters.net;" +
                                                                 "port=10255;" +
                                                                 "UId=root1;" +
                                                                 "database=db_ranking;" +
                                                                 "password=!QAZxsw2;");
                    objcon.Open();
                    MySqlCommand objcmd = new MySqlCommand("insert into tb_lista(id, nickname, caixa, imagem) " +
                        "value(null, ?, ?, ?)", objcon);
                    objcmd.Parameters.Add("@nickname", MySqlDbType.VarChar, 60).Value = Global.gbNickname;
                    objcmd.Parameters.Add("@caixa", MySqlDbType.Int32).Value = Global.gbCaixa;
                    objcmd.Parameters.Add("@imagem", MySqlDbType.Int32).Value = Global.gbImagem;
                    objcmd.ExecuteNonQuery();
                    objcon.Close();
                }

                //Retorna alerta caso ocorra erro de comunicação com o banco de dados
                catch(Exception err)
                {
                    MessageBox.Show("Falha de comunicação com o Banco de Dados, seu jogo não poderá ser salvo.");
                }

                //Avança para a tela Feedback
                tlFeedback Tela_Feedback = new tlFeedback();
                Tela_Feedback.ShowDialog();
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
