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
    class OrigemDAO: Conexao
    {

       // Funcao para incluir uma nova origem no banco de dados: recebe um objeto com os atributos existentes na tabela de origem e o grava no banco de dados.
       public void IncluirOrigem(Objetos.Origem origem)

        {

            try
            {

                conectar();

                comando = new MySqlCommand("INSERT INTO origem (Nome,Telefone,Endereco,Email,CPF,CNPJ,Descricao) VALUES (@Nome,@Telefone,@Endereco,@Email,@CPF,@CNPJ,@Descricao)", conexao);

                comando.Parameters.AddWithValue("@Nome", origem.Nome);
                comando.Parameters.AddWithValue("@Telefone", origem.Telefone);
                comando.Parameters.AddWithValue("@Endereco", origem.Endereco);
                comando.Parameters.AddWithValue("@Email", origem.Email);
                comando.Parameters.AddWithValue("@CPF", origem.Cpf);
                comando.Parameters.AddWithValue("@CNPJ", origem.Cnpj);
                comando.Parameters.AddWithValue("@Descricao", origem.Descricao);
                


                comando.ExecuteNonQuery();
                MessageBox.Show("Origem salva com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "oDAO36 - Ocorreu um erro ao tentar incluir a nova origem no banco de dados: ");
            }
            finally
            {

            }

        }

        // Funcao para excluir uma origem do banco de dados: Recebe o numero do id da origem em forma de string e apaga o registro do banco de dados.
        public void ExcluirOrigem(int idOrigem)
        {
            try
            {
                conectar();

                comando = new MySqlCommand("DELETE FROM origem WHERE IdOrigem = @IdOrigem", conexao);

                comando.Parameters.AddWithValue("@IdOrigem", idOrigem);

                comando.ExecuteNonQuery();

                MessageBox.Show("Origem excluida com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "oDAO64 - Ocorreu um erro ao tentar excluir a origem do banco de dados: ");
            }
            finally
            {
                desconectar();
            }

        }

        /*
          Funcao para alterar uma origem que ja esta gravada no banco de dados -> recebe um objeto do tipo "origem" com os atributos existentes na tabela, localiza o id à ser alterado e grava todos 
          os campos exceto o idOrigem que é auto incrementado automaticamente pelo mysql.
        */
        public void AlterarOrigem(Objetos.Origem o)
        {
            try
            {
                conectar();

                comando = new MySqlCommand("UPDATE origem SET Nome = @Nome, Telefone = @Telefone, Endereco = @Endereco, Email = @Email, CPF = @CPF, CNPJ = @CNPJ, Descricao = @Descricao WHERE IdOrigem = @IdOrigem", conexao);

                comando.Parameters.AddWithValue("@Nome", o.Nome);
                comando.Parameters.AddWithValue("@Telefone", o.Telefone);
                comando.Parameters.AddWithValue("@Endereco", o.Endereco);
                comando.Parameters.AddWithValue("@Email", o.Email);
                comando.Parameters.AddWithValue("@CPF", o.Cpf);
                comando.Parameters.AddWithValue("@CNPJ", o.Cnpj);
                comando.Parameters.AddWithValue("@Descricao", o.Descricao);
                comando.Parameters.AddWithValue("@IdOrigem", o.IdOrigem);

                comando.ExecuteNonQuery();

                MessageBox.Show("Origem atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "oDAO100 - Ocorreu um erro ao tentar alterar a origem no banco de dados: ");
            }
            finally
            {
                desconectar();
            }


        }


        // funcao para consultar todos os registros da tabela Origens do banco de dados. Retorna uma DataTable.
        public DataTable ConsultarOrigem()

        {

            try
            {

                conectar();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(); 


                comando = new MySqlCommand("SELECT * FROM origem ", conexao);

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "oDAO136 - Ocorreu um erro ao tentar consultar a tabela origem no banco de dados: ");
                return null;

            }
            finally
            {
                desconectar();
            }



        }

        //Funcao para consultar registros especificos -> colunaProcurada = a coluna em que o vai ser procurado, exemplo: nome ou descricao | valorProcurado = o valor que sera procurado, exemplo: Restaurante.
        public DataTable ConsultarOrigem(string colunaProcurada,string valorProcurado)

        {

            try
            {

                conectar();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();


                comando = new MySqlCommand("SELECT @coluna FROM origem WHERE @coluna = @valorProcurado ", conexao);

                comando.Parameters.AddWithValue("@coluna", colunaProcurada);
                comando.Parameters.AddWithValue("@valorProcurado", valorProcurado);


                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "oDAO178 - Ocorreu um erro ao tentar consultar a tabela origem no banco de dados:");
                return null;

            }
            finally
            {
                desconectar();
            }



        }

        /*
        Funcao para consultar todos os registros ordenados por idOrigens, nome ou descricao -> |
        ordenadoPor = a coluna que sera utilizada para ordenar os dados recebidos, exemplo: idOrigens, nome ou descricao. | o parametro booleano Ascendente vem como true por padrao,
        caso queira o resultado em ordem decrescente adicione false no ultimo parametro.
        */
        public DataTable ConsultarOrigem(string OrdenadoPor, Boolean Ascendente)

        {

            try
            {

                conectar();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();


                comando = new MySqlCommand("SELECT * FROM origem ORDER BY @ordenadoPor", conexao);

                comando.Parameters.AddWithValue("@ordenadoPor", OrdenadoPor);


                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "oDAO223 - Ocorreu um erro ao tentar consultar a tabela origem no banco de dados: ");
                return null;

            }
            finally
            {
                desconectar();
            }



        }

        /*
        Funcao para consultar registros especificos e ordenados -> colunaProcurada = a coluna em que o vai ser procurado, exemplo: nome ou descricao | valorProcurado = o valor que sera procurado, exemplo: Restaurante.
        ordenadoPor = a coluna que sera utilizada para ordenar os dados recebidos, exemplo: idOrigens, nome ou descricao. | o parametro booleano Ascendente vem como true por padrao,
        caso queira o resultado em ordem decrescente adicione false no ultimo parametro.
        */

        public DataTable ConsultarOrigem(string colunaProcurada, string valorProcurado, string ordenadoPor,Boolean Ascendente = true)

        {

            try
            {

                conectar();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();


                comando = new MySqlCommand("SELECT @coluna FROM origem WHERE @coluna = @valorProcurado ORDER BY @ordenadoPor @AscendenteDescendente", conexao);

                comando.Parameters.AddWithValue("@coluna", colunaProcurada);
                comando.Parameters.AddWithValue("@valorProcurado", valorProcurado);
                comando.Parameters.AddWithValue("@ordenadoPor", ordenadoPor);

                if (Ascendente)
                {
                    comando.Parameters.AddWithValue("@AscendenteDescendente", "ASC");
                }
                else
                {
                    comando.Parameters.AddWithValue("@AscendenteDescendente", "DESC");
                }

                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "oDAO227 - Ocorreu um erro ao tentar consultar a tabela origem no banco de dados: ");
                return null;

            }
            finally
            {
                desconectar();
            }



        }

        public string NomeOrigem(int idOrigem)
        {
            try
            {
                conectar();

                comando = new MySqlCommand("SELECT Nome FROM origem WHERE IdOrigem = @IdOrigem", conexao);

                comando.Parameters.AddWithValue("@IdOrigem", idOrigem);

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                reader.Read();

                return reader.GetString("Nome");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "sDAO394 - Ocorreu um erro ao tentar consultar o Nome da origem selecionada: ");
                return "";
            }
            finally
            {
                desconectar();
            }
        }

        public int IdOrigem(string nome)
        {
            try
            {
                conectar();

                comando = new MySqlCommand("SELECT IdOrigem FROM origem WHERE Nome = @Nome", conexao);

                comando.Parameters.AddWithValue("@Nome", nome);

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                reader.Read();

                return reader.GetInt16("IdOrigem");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "sDAO394 - Ocorreu um erro ao tentar consultar o ID da origem selecionada: ");
                return -1;
            }
            finally
            {
                desconectar();
            }
        }


    }
}
