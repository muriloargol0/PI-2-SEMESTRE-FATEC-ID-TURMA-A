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
    class EntradaDAO : Conexao
    {

        // Funcao para incluir uma nova entrada de recursos no banco de dados: recebe um objeto com os atributos existentes na tabela de entradas e o grava no banco de dados.
        public void IncluirEntrada(Objetos.Entrada entrada)

        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Incluir" |
               Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
               Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    DAO.OrigemDAO odao = new DAO.OrigemDAO();

                    conectar();

                    comando = new MySqlCommand("INSERT INTO movimentacao_caixa (TipoMovimentacao,Valor,FK_IdOrigem,Descricao,FK_IdColaboradorResponsavel,NotaFiscal,DataHoraRegistro,FK_UsuarioRegistro) VALUES " +
                        "(@TipoMovimentacao,@Valor,@FK_IdOrigem,@Descricao,@FK_IdColaboradorResponsavel,@NotaFiscal,@DataHoraRegistro,@FK_UsuarioRegistro)", conexao);

                    comando.Parameters.AddWithValue("@TipoMovimentacao", "Entrada");
                    comando.Parameters.AddWithValue("@Valor", entrada.Valor);
                    comando.Parameters.AddWithValue("@FK_IdOrigem", odao.IdOrigem(entrada.FkNomeOrigem));
                    comando.Parameters.AddWithValue("@Descricao", entrada.Descricao);
                    if (entrada.FkNomeColaboradorResponsavel != "")
                    {
                        DAO.UsuarioDAO udao = new DAO.UsuarioDAO();

                        comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", udao.IdColaborador(entrada.FkNomeColaboradorResponsavel));
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", DBNull.Value);
                    }
                    comando.Parameters.AddWithValue("@NotaFiscal", entrada.NotaFiscal);
                    comando.Parameters.AddWithValue("@DataHoraRegistro", DateTime.Now);
                    comando.Parameters.AddWithValue("@FK_UsuarioRegistro", Objetos.Colaborador.usuarioLogado);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Entrada de recursos registrada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO48 - Ocorreu um erro ao tentar registrar a nova entrada de recursos no banco de dados: ");
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para incluir dados no sistema.", "Acesso Negado:");
            }
        }

        // Funcao para excluir uma entrada do banco de dados: Recebe o numero do id da entrada em forma de integer e apaga o registro do banco de dados.
        public void ExcluirEntrada(int idMovimentacao)
        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    //Guardar Entrada antes de ser removida
                    Objetos.Entrada entrada = new Objetos.Entrada();
                    entrada = ConsultarEntradaObj(idMovimentacao);

                    //Remover Entrada
                    conectar();

                    comando = new MySqlCommand("DELETE FROM movimentacao_caixa WHERE IdMovimentacao = @IdMovimentacao", conexao);

                    comando.Parameters.AddWithValue("@IdMovimentacao", idMovimentacao);

                    //Salvar entrada removida no historico
                    DAO.HistoricoDAO hDAO = new DAO.HistoricoDAO();
                    hDAO.SalvarEntradaRemovida(entrada);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Entrada excluida com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO96 - Ocorreu um erro ao tentar excluir a entrada do banco de dados: ");
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para remover dados do sistema.","Acesso Negado:");
            }
        }

        /*
          Funcao para alterar uma entrada que ja esta gravada no banco de dados -> recebe um objeto do tipo "entrada" com os atributos existentes na tabela, localiza o id à ser alterado e grava todos 
          os campos exceto o idEntrada que é auto incrementado automaticamente pelo mysql.
        */
        public void AlterarEntrada(Objetos.Entrada entrada)

        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
               Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    DAO.OrigemDAO odao = new DAO.OrigemDAO();
                    //Guardar Entrada antes de ser alterada
                    Objetos.Entrada entrada1 = new Objetos.Entrada();

                    entrada1 = ConsultarEntradaObj(entrada.IdMovimentacao);

                    conectar();

                    comando = new MySqlCommand("UPDATE movimentacao_caixa SET Valor =  @Valor, Descricao = @Descricao , FK_IdOrigem = @FK_IdOrigem, FK_IdColaboradorResponsavel = @FK_IdColaboradorResponsavel," +
                                               " NotaFiscal = @NotaFiscal, DataHoraUltimaAlteracao = @DataHoraUltimaAlteracao, FK_UsuarioUltimaAlteracao = @FK_UsuarioUltimaAlteracao " +
                                               "WHERE IdMovimentacao = @IdMovimentacao", conexao);

                    comando.Parameters.AddWithValue("@Valor", entrada.Valor);
                    comando.Parameters.AddWithValue("@Descricao", entrada.Descricao);
                    comando.Parameters.AddWithValue("@FK_IdOrigem", odao.IdOrigem(entrada.FkNomeOrigem));
                    if (entrada.FkNomeColaboradorResponsavel != "")
                    {
                        DAO.UsuarioDAO udao = new DAO.UsuarioDAO();

                        comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", udao.IdColaborador(entrada.FkNomeColaboradorResponsavel));
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", DBNull.Value);
                    }
                    comando.Parameters.AddWithValue("@NotaFiscal", entrada.NotaFiscal);
                    comando.Parameters.AddWithValue("@DataHoraUltimaAlteracao", DateTime.Now);
                    comando.Parameters.AddWithValue("@FK_UsuarioUltimaAlteracao", Objetos.Colaborador.usuarioLogado);
                    comando.Parameters.AddWithValue("@IdMovimentacao", entrada.IdMovimentacao);

                    //Salvar entrada alterada no historico
                    DAO.HistoricoDAO hDAO = new DAO.HistoricoDAO();
                    hDAO.SalvarEntradaAlterada(entrada1);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Entrada alterada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO155 - Ocorreu um erro ao tentar alterar a movimentacao_caixa no banco de dados: ");
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para alterar dados do sistema.", "Acesso Negado:");
            }
        }

        // Serve apenas para uso interno nessa classe, para consultar os valores atuais de alguma entrada que sera removida e subtrair este valor do caixa posteriormente
        public Double ConsultarValorEntrada(int idMovimentacao)
        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Visualizar" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Incluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    conectar();

                    comando = new MySqlCommand("SELECT Valor FROM movimentacao_caixa WHERE IdMovimentacao = @IdMovimentacao;", conexao);

                    comando.Parameters.AddWithValue("@IdMovimentacao", idMovimentacao);

                    MySqlDataReader reader;
                    reader = comando.ExecuteReader();

                    reader.Read();

                    return reader.GetDouble("Valor");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO186 - Ocorreu um erro ao tentar recuperar o valor na base de dados para poder corrigir o caixa antes de excluir: ");
                    return -1;
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para visualizar dados do sistema.", "Acesso Negado:");
                return -1;
            }
        }

        // funcao para consultar todos os registros da tabela Entradas do banco de dados. Retorna uma DataTable.
        public DataTable ConsultarEntrada()

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

                    comando = new MySqlCommand("SELECT * FROM movimentacao_caixa WHERE TipoMovimentacao = 'Entrada'", conexao);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO221 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        public DataTable ConsultarMovimentacoes()

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

                    comando = new MySqlCommand("SELECT * FROM movimentacao_caixa ", conexao);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO221 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        //Funcao para consultar registros especificos -> colunaProcurada = a coluna em que o vai ser procurado, exemplo: nome ou descricao | valorProcurado = o valor que sera procurado, exemplo: Restaurante.
        public DataTable ConsultarEntrada(string colunaProcurada, int valorProcurado)

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

                    comando = new MySqlCommand("SELECT @coluna FROM movimentacao_caixa WHERE @coluna = @valorProcurado ", conexao);

                    comando.Parameters.AddWithValue("@coluna", colunaProcurada);
                    comando.Parameters.AddWithValue("@valorProcurado", valorProcurado);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO265 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        public DataTable ConsultarEntrada(string colunaProcurada, string valorProcurado)

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

                    comando = new MySqlCommand("SELECT @coluna FROM movimentacao_caixa WHERE @coluna = @valorProcurado ", conexao);

                    comando.Parameters.AddWithValue("@coluna", colunaProcurada);
                    comando.Parameters.AddWithValue("@valorProcurado", valorProcurado);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO308 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        public DataTable ConsultarEntrada(string colunaProcurada, double valorProcurado)

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

                    comando = new MySqlCommand("SELECT @coluna FROM movimentacao_caixa WHERE @coluna = @valorProcurado ", conexao);

                    comando.Parameters.AddWithValue("@coluna", colunaProcurada);
                    comando.Parameters.AddWithValue("@valorProcurado", valorProcurado);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO351 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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
        public DataTable ConsultarEntrada(string colunaProcurada, DateTime valorProcurado)

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

                    comando = new MySqlCommand("SELECT @coluna FROM movimentacao_caixa WHERE @coluna = @valorProcurado ", conexao);

                    comando.Parameters.AddWithValue("@coluna", colunaProcurada);
                    comando.Parameters.AddWithValue("@valorProcurado", valorProcurado);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO393 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        //criada para uso interno (salvar no historico de itens excluidos)
        public Objetos.Entrada ConsultarEntradaObj(int IdMovimentacao)

        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Visualizar" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Incluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    conectar();

                    Objetos.Entrada entrada = new Objetos.Entrada();

                    comando = new MySqlCommand("SELECT * FROM movimentacao_caixa WHERE IdMovimentacao = @IdMovimentacao ", conexao);

                    comando.Parameters.AddWithValue("@IdMovimentacao", IdMovimentacao);

                    MySqlDataReader reader;
                    reader = comando.ExecuteReader();

                    reader.Read();
                    
                    entrada.IdMovimentacao = reader.GetInt16("IdMovimentacao");

                    try
                    {
                        entrada.IdMovimentacao = reader.GetInt16("IdMovimentacao");
                    }
                    catch (Exception)
                    {
                        entrada.IdMovimentacao = -1;
                    }

                    try
                    {
                        entrada.TipoMovimentacao = reader.GetString("TipoMovimentacao");
                    }
                    catch (Exception)
                    {
                        entrada.TipoMovimentacao = "";
                    }
                    try
                    {
                        entrada.Valor = reader.GetDouble("Valor");
                    }
                    catch (Exception)
                    {
                        entrada.Valor = 0;
                    }

                    try
                    {
                        entrada.FkIdOrigem = reader.GetInt16("FK_IdOrigem");
                    }
                    catch (Exception)
                    {
                        entrada.FkIdOrigem = -1;
                    }
                    
                    try
                    {
                        entrada.Descricao = reader.GetString("Descricao");
                    }
                    catch (Exception)
                    {
                        entrada.Descricao = "";
                    }

                    try
                    {
                        entrada.FkUsuarioRegistro = reader.GetString("FK_UsuarioRegistro");
                    }
                    catch(Exception)
                    {
                        entrada.FkUsuarioRegistro = "";
                    }

                    try
                    {
                        entrada.FkIdColaboradorResponsavel = reader.GetInt16("FK_IdColaboradorResponsavel");
                    }
                    catch (Exception)
                    {
                        entrada.FkIdColaboradorResponsavel = -1;
                    }

                    try
                    {
                        DAO.UsuarioDAO udao = new DAO.UsuarioDAO();
                        entrada.FkNomeColaboradorResponsavel = udao.NomeColaborador(reader.GetInt16("FK_IdColaboradorResponsavel"));
                    }
                    catch (Exception)
                    {
                        entrada.FkNomeColaboradorResponsavel = "";
                    }

                    try
                    {
                        entrada.FkUsuarioUltimaAlteracao = reader.GetString("FK_UsuarioUltimaAlteracao");
                    }
                    catch (Exception)
                    {
                        entrada.FkUsuarioUltimaAlteracao = "";
                    }

                    try
                    {
                        entrada.DataHoraUltimaAlteracao = reader.GetDateTime("DataHoraUltimaAlteracao");
                    }
                    catch (Exception)
                    {
                        entrada.DataHoraUltimaAlteracao = DateTime.Parse("01-01-01 00:00:00");
                    }

                    try
                    {
                        entrada.DataHoraRegistro = reader.GetDateTime("DataHoraRegistro");
                    }
                    catch (Exception)
                    {
                        entrada.DataHoraRegistro = DateTime.Parse("01-01-01 00:00:00");
                    }

                    return entrada;
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO447 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        /*
        Funcao para consultar todos os registros ordenados pelas colunas da tabela -> |
        ordenadoPor = a coluna que sera utilizada para ordenar os dados recebidos, exemplo: idOrigens, nome ou descricao. | o parametro booleano Ascendente vem como true por padrao,
        caso queira o resultado em ordem decrescente adicione false no ultimo parametro.
        */
        public DataTable ConsultarEntrada(string OrdenadoPor, Boolean Ascendente = true)

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

                    comando = new MySqlCommand("SELECT * FROM movimentacao_caixa ORDER BY @ordenadoPor @AscDesc", conexao);

                    comando.Parameters.AddWithValue("@ordenadoPor", OrdenadoPor);
                    if (Ascendente)
                    {
                        comando.Parameters.AddWithValue("@AscDesc", "ASC");
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@AscDesc", "DESC");
                    }

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO500 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        /*
        Funcao para consultar registros especificos e ordenados -> colunaProcurada = a coluna em que o vai ser procurado, exemplo: nome ou descricao | valorProcurado = o valor que sera procurado, exemplo: Restaurante.
        ordenadoPor = a coluna que sera utilizada para ordenar os dados recebidos, exemplo: idOrigens, nome ou descricao. | o parametro booleano Ascendente vem como true por padrao,
        caso queira o resultado em ordem decrescente adicione false no ultimo parametro.
        */

        public DataTable ConsultarEntrada(string colunaProcurada, string valorProcurado, string ordenadoPor, Boolean Ascendente = true)

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

                    comando = new MySqlCommand("SELECT @coluna FROM movimentacao_caixa WHERE @coluna = @valorProcurado ORDER BY @ordenadoPor @AscDesc", conexao);

                    comando.Parameters.AddWithValue("@coluna", colunaProcurada);
                    comando.Parameters.AddWithValue("@valorProcurado", valorProcurado);
                    comando.Parameters.AddWithValue("@ordenadoPor", ordenadoPor);

                    if (Ascendente)
                    {
                        comando.Parameters.AddWithValue("@AscDesc", "ASC");
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@AscDesc", "DESC");
                    }

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eDAO554 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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
    }
}
