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
    public partial class tlRanking : Form
    {

        public tlRanking()
        {
            InitializeComponent();

            //Realiza comunicação com o banco de dados e extrai listas nickname, caixa e pontuação de imagem
            MySql.Data.MySqlClient.MySqlConnection objcon = new MySqlConnection("server=mysql-10255-0.cloudclusters.net;" +
                                                                 "port=10255;" +
                                                                 "UId=root1;" +
                                                                 "database=db_ranking;" +
                                                                 "password=!QAZxsw2;");
            objcon.Open();
            try
            {

                MySqlCommand objcmd = new MySqlCommand("select nickname, caixa, imagem from tb_lista order by imagem desc;", objcon);
                
                MySqlDataReader lcRanking = objcmd.ExecuteReader();
                
                int i = 1;  //Variável contador para função while       -Local

                //Adiciona itens do banco de dados ao ListView
                while (lcRanking.Read())
                {
                    ListViewItem Lista = new ListViewItem(i + "º " + lcRanking.GetString(0));
                    Lista.SubItems.Add("R$ " + lcRanking.GetInt32(1) + ".00");
                    Lista.SubItems.Add(lcRanking.GetInt32(2) + " Pontos");
                    listNickname.Items.Add(Lista);
                    i++;
                }
                lcRanking.NextResult();
                lcRanking.Close();
                objcmd.ExecuteNonQuery();
                objcon.Close();
                
            }

            //Retorna alerta caso ocorra erro de comunicação com o banco de dados
            catch (Exception e)
            {
                MessageBox.Show("Falha de comunicação com o Banco de Dados, favor tentar abrir a tela novamente.");
            }
            

        }   

        private void BtMenuInicial_Click(object sender, EventArgs e)
        {
            //Retorna para a tela Menu Inicial
            tlMenuInicial Tela_MenuInicial = new tlMenuInicial();
            Tela_MenuInicial.ShowDialog();
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