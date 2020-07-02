using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ControleDoações
{
    public class Conexao
    {
      
            string con = "DATABASE=db_movimentacao_caixa; SERVER=localhost; UID=root; PWD=admin";
            protected MySqlConnection conexao = null;
            public MySqlCommand comando = null;

        //Conectar no banco de dados
        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(con);
                conexao.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar na Base de dados: ", ex.Message);
            }
            finally
            {
            }
        }

            //Fechar conexao com o banco

        public void desconectar()
        {
            try
            {
                conexao = new MySqlConnection(con);
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desconectar da Base de dados: ", ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        
    }
}
