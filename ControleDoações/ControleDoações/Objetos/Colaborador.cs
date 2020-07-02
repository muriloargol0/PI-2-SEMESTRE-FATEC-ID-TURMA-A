using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ControleDoações.Objetos
{
    class Colaborador
    {

        private int idColaborador = -1;
        private string nome = "-";
        private DateTime dataNascimento = DateTime.Parse("01/01/01").Date;
        private string rg = "";
        private string cpf = "";
        private string usuario = ""; // Se este campo estiver vazio o colaborador nao é usuario do sistema
        private string tipoAcesso = ""; //Valores possiveis: Não,Visualizar,Incluir,Alterar-Excluir,Admin;
        private string hashSenha = "";
        static public string usuarioLogado = "";
        static public string tipoAcessoUsuarioLogado = "Não"; //Valores possiveis: Não,Visualizar,Incluir,Alterar-Excluir,Admin;

        
        //Ao instanciar uma senha este código converte a senha automaticamente em Hash, evitando expor a senha do usuario na tabela do BD ou mesmo em tempo de execução.
        public string HashSenha
        {
            get
            {
                return this.hashSenha;
            }

            set
            {
                StringBuilder senha = new StringBuilder();

                MD5 md5 = MD5.Create();
                byte[] entrada = Encoding.ASCII.GetBytes(value);
                byte[] hash = md5.ComputeHash(entrada);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    senha.Append(hash[i].ToString("X2"));
                }

                this.hashSenha = senha.ToString();
            }
        }

        public int IdColaborador { get => idColaborador; set => idColaborador = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value;}
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string TipoAcesso { get => tipoAcesso; set => tipoAcesso = value; }
    }
}
