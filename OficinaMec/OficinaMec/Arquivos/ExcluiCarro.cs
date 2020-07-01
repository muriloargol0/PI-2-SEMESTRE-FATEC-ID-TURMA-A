using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMec.Arquivos
{
    class ExcluiCarro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";

        public ExcluiCarro(String PLACA_CAR)
        {

            if (PLACA_CAR == "")
            {
                this.mensagem = "Insira uma placa";
            }
            else
            {
                string sql = $"select PLACA_CAR from Carro where PLACA_CAR={PLACA_CAR}";
                try
                {
                    SqlCommand cmd1 = new SqlCommand(sql, conexao.conectar());
                    SqlDataReader leitor = cmd1.ExecuteReader();


                    if (leitor.Read())
                    {
                        String ExibeDesc = leitor[0].ToString();

                        cmd.CommandText = "delete from Carro where PLACA_CAR = @PLACA_CAR ";
                        cmd.Parameters.AddWithValue("@PLACA_CAR", PLACA_CAR);

                        try
                        {
                            cmd.Connection = conexao.conectar();
                            cmd.ExecuteNonQuery();

                            this.mensagem = ("Carro excluído com sucesso!");
                            conexao.desconectar();

                        }
                        catch (SqlException ex)
                        {
                            this.mensagem = ("Carro não existe!! ");
                        }


                    }
                    else
                    {
                        this.mensagem = ("Carro não existe!! ");

                    }
                }
                catch (SqlException e)
                {
                    this.mensagem = ("Carro não existe!! ");
                    Console.WriteLine(e);
                }
            }

        }
    }
}
