using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace ControleDoações.DAO
{
    class UsuarioDAO : Conexao
    {


        // Funcao para incluir uma nova origem no banco de dados: recebe um objeto com os atributos existentes na tabela de origem e o grava no banco de dados.
        public void CadastrarColaborador(Objetos.Colaborador colaborador)

        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {

                    conectar();

                    comando = new MySqlCommand("INSERT INTO colaborador (Nome,DataNascimento,RG,CPF,Usuario,Acesso,HashSenha) VALUES (@Nome,@DataNascimento,@RG,@CPF,@Usuario,@Acesso,@HashSenha)", conexao);

                    comando.Parameters.AddWithValue("@Nome", colaborador.Nome);
                    comando.Parameters.AddWithValue("@DataNascimento", colaborador.DataNascimento);
                    comando.Parameters.AddWithValue("@RG", colaborador.Rg);
                    comando.Parameters.AddWithValue("@CPF", colaborador.Cpf);
                    comando.Parameters.AddWithValue("@Usuario", colaborador.Usuario);
                    comando.Parameters.AddWithValue("@Acesso", colaborador.TipoAcesso);
                    comando.Parameters.AddWithValue("@HashSenha", colaborador.HashSenha);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Colaborador cadastrado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "uDAO38 - Ocorreu um erro ao tentar incluir o novo colaborador no banco de dados: ");
                }
                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para cadastrar colaboradores no sistema.", "Acesso Negado:");
            }

        }

        public void RemoverColaborador(int colaborador)

        {

            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {

                    conectar();

                    comando = new MySqlCommand("DELETE FROM colaborador WHERE IdColaborador = @IdColaborador", conexao);

                    comando.Parameters.AddWithValue("@IdColaborador", colaborador);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Colaborador excluido com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "uDAO66 - Ocorreu um erro ao tentar excluir o colaborador do banco de dados: ");
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para remover colaboradores cadastrados no sistema.", "Acesso Negado:");
            }
        }

        public void AlterarSenha()

        {

            if (Objetos.Colaborador.usuarioLogado != "")
            {
                try
                {

                    conectar();

                    comando = new MySqlCommand("SELECT * FROM colaborador WHERE Usuario = @Usuario", conexao);

                    comando.Parameters.AddWithValue("@Usuario", Objetos.Colaborador.usuarioLogado);

                    MySqlDataReader reader;
                    reader = comando.ExecuteReader();

                    reader.Read();

                    string hashCadastrado = reader.GetString("HashSenha");
                    string usuario = reader.GetString("Usuario");


                    Objetos.Colaborador colab = new Objetos.Colaborador();


                    colab.HashSenha = InputDialogBox.Show("Digite a senha atual:");

                    if (colab.HashSenha == hashCadastrado)
                    {
                        do
                        {
                            colab.HashSenha = InputDialogBox.Show("Digite a nova senha:");
                            string tentativa1 = colab.HashSenha;
                            colab.HashSenha = InputDialogBox.Show("Digite a nova senha novamente:");
                            if (tentativa1 == colab.HashSenha)
                            {
                                conectar();

                                comando = new MySqlCommand("UPDATE colaborador SET HashSenha = @HashSenha WHERE Usuario = @Usuario", conexao);


                                comando.Parameters.AddWithValue("@HashSenha", tentativa1);
                                comando.Parameters.AddWithValue("@Usuario", Objetos.Colaborador.usuarioLogado);

                                comando.ExecuteNonQuery();

                                MessageBox.Show("Senha alterada com sucesso!");
                                break;
                            }

                        }
                        while (MessageBox.Show("As duas senhas digitadas não conferem, tentar novamente?", "Erro",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes);

                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta, tente novamente!");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "uDA150 - Ocorreu um erro ao tentar alterar a senha no banco de dados: ");
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Não há usuario logado!");
            }
        }


        // Funcao para excluir uma origem do banco de dados: Recebe o numero do id da origem em forma de string e apaga o registro do banco de dados.
        public Boolean LogarUsuario(Objetos.Colaborador colaborador)
        {
            try
            {

                conectar();

                comando = new MySqlCommand("SELECT * FROM colaborador WHERE Usuario = @Usuario", conexao);

                comando.Parameters.AddWithValue("@Usuario", colaborador.Usuario);

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                reader.Read();

                if (reader.HasRows)
                {
                    string hashCadastrado = reader.GetString("HashSenha");
                    string usuarioLogar = reader.GetString("Usuario");




                    if (String.Equals(hashCadastrado, colaborador.HashSenha))
                    {
                        Objetos.Colaborador.usuarioLogado = usuarioLogar;
                        Objetos.Colaborador.tipoAcessoUsuarioLogado = ConsultarTipoAcesso(usuarioLogar);
                       MessageBox.Show("Usuario logado com sucesso!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Senha Incorreta!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Nome de usuario nao existe!");
                    return false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "uDAO184 - Ocorreu um erro ao tentar logar o usuario: ");
                return false;
            }
            finally
            {
                desconectar();
            }

        }

        // Funcao para excluir uma origem do banco de dados: Recebe o numero do id da origem em forma de string e apaga o registro do banco de dados.
        public void DeslogarUsuario()
        {

            Objetos.Colaborador.usuarioLogado = "-";
            Objetos.Colaborador.tipoAcessoUsuarioLogado = "Não";
            MessageBox.Show("Usuario deslogado com sucesso!");

        }

        public string ConsultarTipoAcesso(string usuario)
        {
                try
                {
                    conectar();

                    comando = new MySqlCommand("SELECT Acesso FROM colaborador WHERE Usuario = @Usuario", conexao);

                    comando.Parameters.AddWithValue("@Usuario", Objetos.Colaborador.usuarioLogado);

                    MySqlDataReader reader;
                    reader = comando.ExecuteReader();

                    reader.Read();

                    return reader.GetString("Acesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "uDAO265 - Ocorreu um erro ao tentar consultar o tipo de acesso do usuario: ");
                    return "";
                }
        }

        public DataTable NomesColaboradores()
        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Visualizar" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Incluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    conectar();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    comando = new MySqlCommand("SELECT Nome FROM colaborador", conexao);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "sDAO394 - Ocorreu um erro ao tentar preencher o comboBox: colaborador responsavel: ");
                    return null;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para visualizar dados do sistema.", "Acesso Negado:");
                return null;
            }

        }

        public int IdColaborador(string nome)
        {
            try
            {
                conectar();

                comando = new MySqlCommand("SELECT IdColaborador FROM colaborador WHERE Nome = @Nome", conexao);

                comando.Parameters.AddWithValue("@Nome", nome);

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                reader.Read();

                return reader.GetInt16("IdColaborador");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "sDAO394 - Ocorreu um erro ao tentar consultar o ID do colaborador selecionado: ");
                return -1;
            }
            finally
            {
                desconectar();
            }
        }

        public string NomeColaborador(int idColaborador)
        {
            try
            {
                conectar();

                comando = new MySqlCommand("SELECT Nome FROM colaborador WHERE IdColaborador = @IdColaborador", conexao);

                comando.Parameters.AddWithValue("@IdColaborador", idColaborador);

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                reader.Read();

                return reader.GetString("Nome");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "sDAO394 - Ocorreu um erro ao tentar consultar o Nome do colaborador selecionado: ");
                return "";
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable ConsultarColaboradores()

        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    conectar();

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    comando = new MySqlCommand("SELECT * FROM colaborador ", conexao);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO221 - Ocorreu um erro ao tentar consultar a tabela 'colaborador' no banco de dados: ");
                    return null;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para visualizar dados de colaboradores.", "Acesso Negado:");
                return null;
            }
        }
    }
}

