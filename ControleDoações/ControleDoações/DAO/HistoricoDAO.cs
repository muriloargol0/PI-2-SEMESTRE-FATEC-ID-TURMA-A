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
    class HistoricoDAO : Conexao
    {

        // Funcao para salvar uma saida no historico antes de ser removida (uso interno)
        public void SalvarSaidaRemovida(Objetos.Saida saida)

        {
            try
            {
                conectar();

                comando = new MySqlCommand("INSERT INTO historico_movimentacao_caixa (IdMovimentacao,TipoMovimentacao,TipoDespesa,Valor,Descricao,FK_IdColaboradorResponsavel,NotaFiscal,FK_UsuarioRegistro,DataHoraRegistro,FK_UsuarioAlteracao,DataHoraAlteracao,FK_UsuarioRemocao,DataHoraRemocao)" +
                                           " VALUES (@IdMovimentacao,@TipoMovimentacao,@TipoDespesa,@Valor,@Descricao,@FK_IdColaboradorResponsavel,@NotaFiscal,@FK_UsuarioRegistro,@DataHoraRegistro,@FK_UsuarioAlteracao,@DataHoraAlteracao,@FK_UsuarioRemocao,@DataHoraRemocao)", conexao);

                comando.Parameters.AddWithValue("@IdMovimentacao", saida.IdMovimentacao);
                comando.Parameters.AddWithValue("@TipoMovimentacao", saida.TipoMovimentacao);
                comando.Parameters.AddWithValue("@TipoDespesa", saida.TipoDespesa);
                comando.Parameters.AddWithValue("@Valor", saida.Valor);
                comando.Parameters.AddWithValue("@Descricao", saida.Descricao);
                comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", saida.FkIdColaboradorResponsavel);
                comando.Parameters.AddWithValue("@NotaFiscal", saida.NotaFiscal);
                comando.Parameters.AddWithValue("@FK_UsuarioRegistro", saida.FkUsuarioRegistro);
                comando.Parameters.AddWithValue("@DataHoraRegistro", saida.DataHoraRegistro);
                comando.Parameters.AddWithValue("@FK_UsuarioAlteracao", saida.FkUsuarioUltimaAlteracao);
                comando.Parameters.AddWithValue("@DataHoraAlteracao", saida.DataHoraUltimaAlteracao);
                comando.Parameters.AddWithValue("@FK_UsuarioRemocao", Objetos.Colaborador.usuarioLogado);
                comando.Parameters.AddWithValue("@DataHoraRemocao", DateTime.Now);

                comando.ExecuteNonQuery();
                MessageBox.Show("Historico salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hDAO44 - Ocorreu um erro ao tentar incluir a saida à ser removida no historico: ");
            }
            finally
            {

            }

        }

        // Funcao para salvar uma saida no historico antes de ser alterada (uso interno)
        public void SalvarSaidaAlterada(Objetos.Saida saida)

        {

            try
            {

                conectar();

                comando = new MySqlCommand("INSERT INTO historico_movimentacao_caixa (IdMovimentacao,TipoMovimentacao,TipoDespesa,Valor,Descricao,FK_IdColaboradorResponsavel,NotaFiscal,FK_UsuarioRegistro,DataHoraRegistro,FK_UsuarioAlteracao,DataHoraAlteracao)" +
                                           " VALUES (@IdMovimentacao,@TipoMovimentacao,@TipoDespesa,@Valor,@Descricao,@FK_IdColaboradorResponsavel,@NotaFiscal,@FK_UsuarioRegistro,@DataHoraRegistro,@FK_UsuarioAlteracao,@DataHoraAlteracao)", conexao);

                comando.Parameters.AddWithValue("@IdMovimentacao", saida.IdMovimentacao);
                comando.Parameters.AddWithValue("@TipoMovimentacao", saida.TipoMovimentacao);
                comando.Parameters.AddWithValue("@TipoDespesa", saida.TipoDespesa);
                comando.Parameters.AddWithValue("@Valor", saida.Valor);
                comando.Parameters.AddWithValue("@Descricao", saida.Descricao);
                comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", saida.FkIdColaboradorResponsavel);
                comando.Parameters.AddWithValue("@NotaFiscal", saida.NotaFiscal);
                comando.Parameters.AddWithValue("@FK_UsuarioRegistro", saida.FkUsuarioRegistro);
                comando.Parameters.AddWithValue("@DataHoraRegistro", saida.DataHoraRegistro);
                comando.Parameters.AddWithValue("@FK_UsuarioAlteracao", Objetos.Colaborador.usuarioLogado);
                comando.Parameters.AddWithValue("@DataHoraAlteracao", DateTime.Now);

                comando.ExecuteNonQuery();
                MessageBox.Show("Historico salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hDAO81 - Ocorreu um erro ao tentar incluir a saida à ser alterada no historico: ");
            }
            finally
            {

            }

        }

        // Funcao para salvar uma entrada no historico antes de ser removida (uso interno)
        public void SalvarEntradaRemovida(Objetos.Entrada entrada)

        {

            try
            {

                conectar();

                comando = new MySqlCommand("INSERT INTO historico_movimentacao_caixa (IdMovimentacao,TipoMovimentacao,FK_IdOrigem,Valor,Descricao,FK_IdColaboradorResponsavel,NotaFiscal,FK_UsuarioRegistro,DataHoraRegistro,FK_UsuarioAlteracao,DataHoraAlteracao,FK_UsuarioRemocao,DataHoraRemocao)" +
                                           " VALUES (@IdMovimentacao,@TipoMovimentacao,@FK_IdOrigem,@Valor,@Descricao,@FK_IdColaboradorResponsavel,@NotaFiscal,@FK_UsuarioRegistro,@DataHoraRegistro,@FK_UsuarioAlteracao,@DataHoraAlteracao,@FK_UsuarioRemocao,@DataHoraRemocao)", conexao);

                comando.Parameters.AddWithValue("@IdMovimentacao", entrada.IdMovimentacao);
                comando.Parameters.AddWithValue("@TipoMovimentacao", entrada.TipoMovimentacao);
                comando.Parameters.AddWithValue("@FK_IdOrigem", entrada.FkIdOrigem);
                comando.Parameters.AddWithValue("@Valor", entrada.Valor);
                comando.Parameters.AddWithValue("@Descricao", entrada.Descricao);
                comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", entrada.FkIdColaboradorResponsavel);
                comando.Parameters.AddWithValue("@NotaFiscal", entrada.NotaFiscal);
                comando.Parameters.AddWithValue("@FK_UsuarioRegistro", entrada.FkUsuarioRegistro);
                comando.Parameters.AddWithValue("@DataHoraRegistro", entrada.DataHoraRegistro);
                comando.Parameters.AddWithValue("@FK_UsuarioAlteracao", entrada.FkUsuarioUltimaAlteracao);
                comando.Parameters.AddWithValue("@DataHoraAlteracao", entrada.DataHoraUltimaAlteracao);
                comando.Parameters.AddWithValue("@FK_UsuarioRemocao", Objetos.Colaborador.usuarioLogado);
                comando.Parameters.AddWithValue("@DataHoraRemocao", DateTime.Now);



                comando.ExecuteNonQuery();
                MessageBox.Show("Historico salvo com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hDAO120 - Ocorreu um erro ao tentar incluir a entrada à ser removida no historico: ");
            }
            finally
            {
                
            }

        }

        // Funcao para salvar uma entrada no historico antes de ser alterada (uso interno)
        public void SalvarEntradaAlterada(Objetos.Entrada entrada)

        {

            try
            {

                conectar();

                comando = new MySqlCommand("INSERT INTO historico_movimentacao_caixa (IdMovimentacao,TipoMovimentacao,Valor,FK_IdOrigem,Descricao,FK_IdColaboradorResponsavel,NotaFiscal,FK_UsuarioRegistro,DataHoraRegistro,FK_UsuarioAlteracao,DataHoraAlteracao)" +
                                           " VALUES (@IdMovimentacao,@TipoMovimentacao,@Valor,@FK_IdOrigem,@Descricao,@FK_IdColaboradorResponsavel,@NotaFiscal,@FK_UsuarioRegistro,@DataHoraRegistro,@FK_UsuarioAlteracao,@DataHoraAlteracao)", conexao);

                comando.Parameters.AddWithValue("@IdMovimentacao", entrada.IdMovimentacao);
                comando.Parameters.AddWithValue("@TipoMovimentacao", entrada.TipoMovimentacao);
                comando.Parameters.AddWithValue("@FK_IdOrigem", entrada.FkIdOrigem);
                comando.Parameters.AddWithValue("@Valor", entrada.Valor);
                comando.Parameters.AddWithValue("@Descricao", entrada.Descricao);
                comando.Parameters.AddWithValue("@FK_IdColaboradorResponsavel", entrada.FkIdColaboradorResponsavel);
                comando.Parameters.AddWithValue("@NotaFiscal", entrada.NotaFiscal);
                comando.Parameters.AddWithValue("@FK_UsuarioRegistro", entrada.FkUsuarioRegistro);
                comando.Parameters.AddWithValue("@DataHoraRegistro", entrada.DataHoraRegistro);
                comando.Parameters.AddWithValue("@FK_UsuarioAlteracao", Objetos.Colaborador.usuarioLogado);
                comando.Parameters.AddWithValue("@DataHoraAlteracao", DateTime.Now);


                comando.ExecuteNonQuery();
                MessageBox.Show("Historico salvo com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hDAO156 - Ocorreu um erro ao tentar incluir a entrada à ser removida no historico: ");
            }
            finally
            {

            }

        }

        //FALTA IMPLEMENTAR
        // public void ExportarELimparHistorico(){
        //}

        //ATE O MOMENTO NAO PRECISA IMPLEMENTAR, CASO PRECISE, FALTA CORRIGIR
        //// Funcao para excluir uma origem do banco de dados: Recebe o numero do id da origem em forma de string e apaga o registro do banco de dados.
        //public void ExcluirRegistroHistorico(string idUsuario)
        //{
        //    try
        //    {

        //        conectar();

        //        comando = new MySqlCommand("DELETE FROM Usuario WHERE idOrigens = @idUsuario", conexao);

        //        comando.Parameters.AddWithValue("@idUsuario", idUsuario);

        //        comando.ExecuteNonQuery();

        //        MessageBox.Show("Origem excluida com sucesso!");

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro ao tentar excluir a origem do banco de dados: ", ex.Message);
        //    }
        //    finally
        //    {
        //        desconectar();
        //    }

        //}







    }
}
