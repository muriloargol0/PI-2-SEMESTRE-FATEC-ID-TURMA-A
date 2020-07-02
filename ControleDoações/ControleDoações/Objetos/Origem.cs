using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDoações.Objetos
{
    class Origem
    {
        private int idOrigem = -1;
        private string nome = "";
        private string telefone= "";
        private string endereco = "";
        private string email = "";
        private string cpf = "";
        private string cnpj = "";
        private string descricao = "";

        public int IdOrigem { get => idOrigem; set => idOrigem = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
