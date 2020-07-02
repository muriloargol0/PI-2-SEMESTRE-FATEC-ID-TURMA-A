using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace ControleDoações.DAO
{
    class CaixaDAO: Conexao
    {

        // funcao para consultar o valor em caixa, retorna um Double.
        public Double ConsultarSaldo()
        {
            try
            {
                conectar();

                comando = new MySqlCommand("SELECT SUM(Valor) AS Valor FROM movimentacao_caixa;", conexao);

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                reader.Read();

                return reader.GetDouble("Valor");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "cDAO131 - Ocorreu um erro ao tentar calcular o valor em caixa: ");
                return -1;
            }
            finally
            {
                desconectar();
            }
        }
    }
}
