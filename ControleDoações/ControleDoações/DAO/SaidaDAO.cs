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
    class SaidaDAO : Conexao
    {

        // Funcao para incluir uma nova saida de recursos no banco de dados: recebe um objeto com os atributos existentes na tabela de saidas e o grava no banco de dados.
        public void IncluirSaida(Objetos.Saida saida)

        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Incluir" |
               Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
               Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    conectar();

                    comando = new MySqlCommand("INSERT INTO movimentacao_caixa (TipoMovimentacao,Valor,TipoDespesa,Descricao,FK_IdColaboradorResponsavel,NotaFiscal,DataHoraRegistro,FK_UsuarioRegistro) " +
                                               "VALUES (@TipoMovimentacao,@Valor,@TipoDespesa,@Descricao,@FK_IdColaboradorResponsavel,@NotaFiscal,@DataHoraRegistro,@FK_UsuarioRegistro)", conexao);

                    comando.Parameters.AddWithValue("@TipoMovimentacao", "Saida");
                    comando.Parameters.AddWithValue("@Valor", saida.Valor*-1);
                    comando.Parameters.AddWithValue("@TipoDespesa", saida.TipoDespesa);
                    comando.Parameters.AddWithValue("@Descricao", saida.Descricao);
                    if (saida.FkNomeColaboradorResponsavel != "")
                    {
                        DAO.UsuarioDAO udao = new DAO.UsuarioDAO();

                        comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", udao.IdColaborador(saida.FkNomeColaboradorResponsavel));
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", DBNull.Value);
                    }
                    comando.Parameters.AddWithValue("@NotaFiscal", saida.NotaFiscal);
                    comando.Parameters.AddWithValue("@DataHoraRegistro", DateTime.Now);
                    comando.Parameters.AddWithValue("@FK_UsuarioRegistro", Objetos.Colaborador.usuarioLogado);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Saida de recursos registrada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "sDAO48 - Ocorreu um erro ao tentar registrar a nova saida de recursos no banco de dados: ");
                }
                finally
                {
            }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para incluir dados no sistema.", "Acesso Negado:");
            }
        }

        // Funcao para excluir uma saida do banco de dados: Recebe o numero do id da saida em forma de integer e apaga o registro do banco de dados.
        public void ExcluirSaida(int idMovimentacao)
        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    //Guardar Saida antes de ser removida
                    Objetos.Saida saida = new Objetos.Saida();
                    saida = ConsultarSaidaObj(idMovimentacao);

                    //Remover Saida
                    conectar();

                    comando = new MySqlCommand("DELETE FROM movimentacao_caixa WHERE IdMovimentacao = @IdMovimentacao", conexao);

                    comando.Parameters.AddWithValue("@IdMovimentacao", idMovimentacao);

                    //Salvar saida removida no historico
                    DAO.HistoricoDAO hDAO = new DAO.HistoricoDAO();
                    hDAO.SalvarSaidaRemovida(saida);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Saida excluida com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "sDAO96 - Ocorreu um erro ao tentar excluir a saida do banco de dados: ");
                }
                finally
                {
                    desconectar();
                }
            }
            else
            {
                MessageBox.Show("Usuario logado nao possui privilegios para remover dados do sistema.", "Acesso Negado:");
            }
        }

        /*
          Funcao para alterar uma saida que ja esta gravada no banco de dados -> recebe um objeto do tipo "saida" com os atributos existentes na tabela, localiza o id à ser alterado e grava todos 
          os campos exceto o idMovimentacao que é auto incrementado automaticamente pelo mysql.
        */
        public void AlterarSaida(Objetos.Saida s)

        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
               Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    //Guardar Saida antes de ser alterada
                    Objetos.Saida saida = new Objetos.Saida();

                    saida = ConsultarSaidaObj(s.IdMovimentacao);

                    conectar();

                    comando = new MySqlCommand("UPDATE movimentacao_caixa SET Valor =  @Valor, TipoDespesa = @TipoDespesa,Descricao = @Descricao, FK_IdColaboradorResponsavel = @FK_IdColaboradorResponsavel," +
                                               " NotaFiscal = @NotaFiscal, DataHoraUltimaAlteracao = @DataHoraUltimaAlteracao, FK_UsuarioUltimaAlteracao = @FK_UsuarioUltimaAlteracao " +
                                               "WHERE IdMovimentacao = @IdMovimentacao", conexao);

                    comando.Parameters.AddWithValue("@Valor", s.Valor*-1);
                    comando.Parameters.AddWithValue("@TipoDespesa", s.TipoDespesa);
                    comando.Parameters.AddWithValue("@Descricao", s.Descricao);
                    if (saida.FkNomeColaboradorResponsavel != "")
                    {
                        DAO.UsuarioDAO udao = new DAO.UsuarioDAO();

                        comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", udao.IdColaborador(saida.FkNomeColaboradorResponsavel));
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", DBNull.Value);
                    }
                    comando.Parameters.AddWithValue("@NotaFiscal", s.NotaFiscal);
                    comando.Parameters.AddWithValue("@DataHoraUltimaAlteracao", DateTime.Now);
                    comando.Parameters.AddWithValue("@FK_UsuarioUltimaAlteracao", Objetos.Colaborador.usuarioLogado);
                    comando.Parameters.AddWithValue("@IdMovimentacao", s.IdMovimentacao);

                    //Salvar saida alterada no historico
                    DAO.HistoricoDAO hDAO = new DAO.HistoricoDAO();
                    hDAO.SalvarSaidaAlterada(saida);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Saida alterada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "sDAO155 - Ocorreu um erro ao tentar alterar a movimentacao_caixa no banco de dados: ");
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

        // Serve apenas para uso interno nessa classe, para consultar os valores atuais de alguma saida que sera removida e subtrair este valor do caixa posteriormente
        public Double ConsultarValorSaida(int idMovimentacao)
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
                    MessageBox.Show(ex.Message, "sDAO186 - Ocorreu um erro ao tentar recuperar o valor na base de dados: ");
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

        // funcao para consultar todos os registros da tabela Saidas do banco de dados. Retorna uma DataTable.
        public DataTable ConsultarSaida()

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

                    comando = new MySqlCommand("SELECT * FROM movimentacao_caixa WHERE TipoMovimentacao = 'Saida'", conexao);

                    da.SelectCommand = comando;
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "sDAO221 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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
        public DataTable ConsultarSaida(string colunaProcurada, int valorProcurado)

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
                    MessageBox.Show(ex.Message, "sDAO265 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        public DataTable ConsultarSaida(string colunaProcurada, string valorProcurado)

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
                    MessageBox.Show(ex.Message, "sDAO308 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        public DataTable ConsultarSaida(string colunaProcurada, double valorProcurado)

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
                    MessageBox.Show(ex.Message, "sDAO351 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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
        public DataTable ConsultarSaida(string colunaProcurada, DateTime valorProcurado)

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
                    MessageBox.Show(ex.Message, "sDAO394 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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
        public Objetos.Saida ConsultarSaidaObj(int idMovimentacao)

        {
            if (Objetos.Colaborador.tipoAcessoUsuarioLogado == "Visualizar" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Incluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Alterar-Excluir" |
                Objetos.Colaborador.tipoAcessoUsuarioLogado == "Admin")
            {
                try
                {
                    conectar();

                    Objetos.Saida saida = new Objetos.Saida();

                    comando = new MySqlCommand("SELECT * FROM movimentacao_caixa WHERE IdMovimentacao = @IdMovimentacao ", conexao);

                    comando.Parameters.AddWithValue("@IdMovimentacao", idMovimentacao);

                    MySqlDataReader reader;
                    reader = comando.ExecuteReader();

                    reader.Read();

                    saida.IdMovimentacao = reader.GetInt16("IdMovimentacao");

                    try
                    {
                        saida.IdMovimentacao = reader.GetInt16("IdMovimentacao");
                    }
                    catch (Exception)
                    {
                        saida.IdMovimentacao = -1;
                    }

                    try
                    {
                        saida.TipoMovimentacao = reader.GetString("TipoMovimentacao");
                    }
                    catch (Exception)
                    {
                        saida.TipoMovimentacao = "";
                    }
                    try
                    {
                        saida.Valor = reader.GetDouble("Valor");
                    }
                    catch (Exception)
                    {
                        saida.Valor = 0;
                    }

                    try
                    {
                        saida.TipoDespesa = reader.GetString("TipoDespesa");
                    }
                    catch (Exception)
                    {
                        saida.TipoDespesa = "";
                    }

                    try
                    {
                        saida.Descricao = reader.GetString("Descricao");
                    }
                    catch (Exception)
                    {
                        saida.Descricao = "";
                    }

                    try
                    {
                        saida.FkUsuarioRegistro = reader.GetString("FK_UsuarioRegistro");
                    }
                    catch (Exception)
                    {
                        saida.FkUsuarioRegistro = "";
                    }

                    try
                    {
                        saida.FkUsuarioUltimaAlteracao = reader.GetString("FK_UsuarioUltimaAlteracao");
                    }
                    catch (Exception)
                    {
                        saida.FkUsuarioUltimaAlteracao = "";
                    }

                    try
                    {
                        saida.FkIdColaboradorResponsavel = reader.GetInt16("FK_IdColaboradorResponsavel");
                    }
                    catch (Exception)
                    {
                        saida.FkIdColaboradorResponsavel = -1;
                    }

                    try
                    {
                        DAO.UsuarioDAO udao = new DAO.UsuarioDAO();
                        saida.FkNomeColaboradorResponsavel = udao.NomeColaborador(reader.GetInt16("FK_IdColaboradorResponsavel"));
                    }
                    catch (Exception)
                    {
                        saida.FkNomeColaboradorResponsavel = "";
                    }

                    try
                    {
                        saida.DataHoraUltimaAlteracao = reader.GetDateTime("DataHoraUltimaAlteracao");
                    }
                    catch (Exception)
                    {
                        saida.DataHoraUltimaAlteracao = DateTime.Parse("01-01-01 00:00:00");
                    }

                    try
                    {
                        saida.DataHoraRegistro = reader.GetDateTime("DataHoraRegistro");
                    }
                    catch (Exception)
                    {
                        saida.DataHoraRegistro = DateTime.Parse("01-01-01 00:00:00");
                    }

                    return saida;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "sDAO447 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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
        public DataTable ConsultarSaida(string OrdenadoPor, Boolean Ascendente = true)

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
                    MessageBox.Show(ex.Message, "sDAO500 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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

        public DataTable ConsultarSaida(string colunaProcurada, string valorProcurado, string ordenadoPor, Boolean Ascendente = true)

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
                    MessageBox.Show(ex.Message, "sDAO554 - Ocorreu um erro ao tentar consultar a tabela \"movimentacao_caixa\" no banco de dados: ");
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
