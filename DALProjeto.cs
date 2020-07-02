using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoPI
{
    class DALProjeto
    {
        private Conexao objConexao;

        public DALProjeto(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Projeto aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into tbCadAlunos(nome, datanascimento, genero, endereco, numero, bairro, cidade," +
                "uf, cep, telfixo, restricaoalimentar, restricaoalimObs, restricaoremedio, restricaoremedioObs," +
                "nomemae, cpfmae, telcelmae, emailmae, nomepai, cpfpai, telcelpai, emailpai, responsavel, nomeresp," +
                "cpfresp, telcelresp, emailresp) values (@nome, @datanascimento, @genero, @endereco, @numero," +
                "@bairro, @cidade, @uf, @cep, @telfixo, @restricaoalimentar, @restricaoalimObs, @restricaoremedio," +
                "@restricaoremedioObs, @nomemae, @cpfmae, @telcelmae, @emailmae, @nomepai, @cpfpai, @telcelpai," +
                "@emailpai, @responsavel, @nomeresp, @cpfresp, @telcelresp, @emailresp); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@datanascimento", aluno.DatadeNascimento);
            cmd.Parameters.AddWithValue("@genero", aluno.Sexo);
            cmd.Parameters.AddWithValue("@endereco", aluno.Endereco);
            cmd.Parameters.AddWithValue("@numero", aluno.Numero);
            cmd.Parameters.AddWithValue("@bairro", aluno.Bairro);
            cmd.Parameters.AddWithValue("@cidade", aluno.Cidade);
            cmd.Parameters.AddWithValue("@uf", aluno.Estado);
            cmd.Parameters.AddWithValue("@cep", aluno.CEP);
            cmd.Parameters.AddWithValue("@telfixo", aluno.TelFixo);
            cmd.Parameters.AddWithValue("@restricaoalimentar", aluno.RestricaoAlimentar);
            cmd.Parameters.AddWithValue("@restricaoalimObs", aluno.RestricaoAlimObs);
            cmd.Parameters.AddWithValue("@restricaoremedio", aluno.RestricaoRemedio);
            cmd.Parameters.AddWithValue("@restricaoremedioObs", aluno.RestricaoRemedioObs);
            cmd.Parameters.AddWithValue("@nomemae", aluno.NomeMae);
            cmd.Parameters.AddWithValue("@cpfmae", aluno.CPFmae);
            cmd.Parameters.AddWithValue("@telcelmae", aluno.TelCelMae);
            cmd.Parameters.AddWithValue("@emailmae", aluno.Emailmae);
            cmd.Parameters.AddWithValue("@nomepai", aluno.NomePai);
            cmd.Parameters.AddWithValue("@cpfpai", aluno.CPFpai);
            cmd.Parameters.AddWithValue("@telcelpai", aluno.TelCelPai);
            cmd.Parameters.AddWithValue("@emailpai", aluno.Emailpai);
            cmd.Parameters.AddWithValue("@responsavel", aluno.Responsavel);
            cmd.Parameters.AddWithValue("@nomeresp", aluno.NomeResp);
            cmd.Parameters.AddWithValue("@cpfresp", aluno.CPFResp);
            cmd.Parameters.AddWithValue("@telcelresp", aluno.TelCelResp);
            cmd.Parameters.AddWithValue("@emailresp", aluno.Emailresp);

            objConexao.Conectar();
            aluno.Codigo = Convert.ToInt16(cmd.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Alterar(Projeto aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update tbCadAlunos set nome=@nome, datanascimento=@datanascimento, genero=@genero," +
                "endereco=@endereco, numero=@numero, bairro=@bairro, cidade=@cidade, uf=@uf, cep=@cep," +
                "telfixo=@telfixo, restricaoalimentar=@restricaoalimentar, restricaoalimObs=@restricaoalimObs, " +
                "restricaoremedio=@restricaoremedio, restricaoremedioObs=@ restricaoremedioObs," +
                "nomemae=@nomemae, cpfmae=@cpfmae, telcelmae=@telcelmae, emailmae=@emailmae, " +
                "nomepai=@nomepai, cpfpai=@cpfpai, telcelpai=@telcelpai, emailpai=@emailpai, " +
                "responsavel=@responsavel, nomeresp=@nomeresp, cpfresp=@cpfresp, telcelresp=@tecelresp, emailresp=@emailresp"+
                " where Id = @id";
            cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@datanascimento", aluno.DatadeNascimento);
            cmd.Parameters.AddWithValue("@genero", aluno.Sexo);
            cmd.Parameters.AddWithValue("@endereco", aluno.Endereco);
            cmd.Parameters.AddWithValue("@numero", aluno.Numero);
            cmd.Parameters.AddWithValue("@bairro", aluno.Bairro);
            cmd.Parameters.AddWithValue("@cidade", aluno.Cidade);
            cmd.Parameters.AddWithValue("@uf", aluno.Estado);
            cmd.Parameters.AddWithValue("@cep", aluno.CEP);
            cmd.Parameters.AddWithValue("@telfixo", aluno.TelFixo);
            cmd.Parameters.AddWithValue("@restricaoalimentar", aluno.RestricaoAlimentar);
            cmd.Parameters.AddWithValue("@restricaoalimObs", aluno.RestricaoAlimObs);
            cmd.Parameters.AddWithValue("@restricaoremedio", aluno.RestricaoRemedio);
            cmd.Parameters.AddWithValue("@restricaoremedioObs", aluno.RestricaoRemedioObs);
            cmd.Parameters.AddWithValue("@nomemae", aluno.NomeMae);
            cmd.Parameters.AddWithValue("@cpfmae", aluno.CPFmae);
            cmd.Parameters.AddWithValue("@telcelmae", aluno.TelCelMae);
            cmd.Parameters.AddWithValue("@emailmae", aluno.Emailmae);
            cmd.Parameters.AddWithValue("@nomepai", aluno.NomePai);
            cmd.Parameters.AddWithValue("@cpfpai", aluno.CPFpai);
            cmd.Parameters.AddWithValue("@telcelpai", aluno.TelCelPai);
            cmd.Parameters.AddWithValue("@emailpai", aluno.Emailpai);
            cmd.Parameters.AddWithValue("@responsavel", aluno.Responsavel);
            cmd.Parameters.AddWithValue("@nomeresp", aluno.NomeResp);
            cmd.Parameters.AddWithValue("@cpfresp", aluno.CPFResp);
            cmd.Parameters.AddWithValue("@telcelresp", aluno.TelCelResp);
            cmd.Parameters.AddWithValue("@emailresp", aluno.Emailresp);
            cmd.Parameters.AddWithValue("@id", aluno.Codigo);

            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public void Excluir(int cod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from tbCadAlunos " +
                "where Id = @id";
            cmd.Parameters.AddWithValue("@id", cod);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbCadAlunos where nome like '%" +
               valor + "%'", objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public Projeto carregaContato (int codigo)
        {
            Projeto modelo = new Projeto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "select * from tbCadAlunos where Id =" + codigo.ToString();
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt16(registro["Id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.DatadeNascimento = Convert.ToDateTime(registro["datanascimento"]);
                modelo.Sexo = Convert.ToString(registro["genero"]);
                modelo.Endereco = Convert.ToString(registro["endereco"]);
                modelo.Numero = Convert.ToInt16(registro["numero"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.Cidade = Convert.ToString(registro["cidade"]);
                modelo.Estado = Convert.ToString(registro["uf"]);
                modelo.CEP = Convert.ToString(registro["cep"]);
                modelo.TelFixo = Convert.ToString(registro["telfixo"]);
                modelo.RestricaoAlimentar = Convert.ToBoolean(registro["restricaoalimentar"]);
                modelo.RestricaoAlimObs = Convert.ToString(registro["restricaoalimObs"]);
                modelo.RestricaoRemedio = Convert.ToBoolean(registro["restricaoremedio"]);
                modelo.RestricaoRemedioObs = Convert.ToString(registro["restricaoremedioObs"]);
                modelo.NomeMae = Convert.ToString(registro["nomemae"]);
                modelo.CPFmae = Convert.ToString(registro["cpfmae"]);
                modelo.TelCelMae = Convert.ToString(registro["telcelmae"]);
                modelo.Emailmae = Convert.ToString(registro["emailmae"]);
                modelo.NomePai = Convert.ToString(registro["nomepai"]);
                modelo.CPFpai = Convert.ToString(registro["cpfpai"]);
                modelo.TelCelPai = Convert.ToString(registro["telcelpai"]);
                modelo.Emailpai = Convert.ToString(registro["emailpai"]);
                modelo.Responsavel = Convert.ToString(registro["responsavel"]);
                modelo.NomeResp = Convert.ToString(registro["nomeresp"]);
                modelo.CPFResp = Convert.ToString(registro["cpfresp"]);
                modelo.TelCelResp = Convert.ToString(registro["telcelresp"]);
                modelo.Emailresp = Convert.ToString(registro["emailresp"]);
            }
            return modelo;
        }
    }
}
