using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPI
{
    public class Projeto
    {
        public Projeto()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.DatadeNascimento = DateTime.Now;
            this.Sexo = "";
            this.Endereco = "";
            this.Numero = 0;
            this.Bairro = "";
            this.Cidade = "";
            this.Estado = "";
            this.CEP = "";
            this.TelFixo = "";
            this.RestricaoAlimentar = false;
            this.RestricaoAlimObs = "";
            this.RestricaoRemedio = false;
            this.RestricaoRemedioObs = "";
            this.NomeMae = "";
            this.CPFmae = "";
            this.TelCelMae = "";
            this.Emailmae = "";
            this.NomePai = "";
            this.CPFpai = "";
            this.TelCelPai = "";
            this.Emailpai = "";
            this.Responsavel = "";
            this.NomeResp = "";
            this.CPFResp = "";
            this.TelCelResp = "";
            this.Emailresp= "";
        }
        public Projeto(int Codigo, string Nome, DateTime DatadeNascimento, string Sexo, string Endereco, int Numero,
            string Bairro, string Cidade, string Estado, string CEP, string TelFixo, bool RestricaoAlimentar,
            string RestricaoAlimObs, bool RestricaoRemedio, string RestricaoRemedioObs, string NomeMae, string CPFmae,
            string TelCelMae, string Emailmae, string NomePai, string CPFpai, string TelCelPai, string Emailpai,
            string Responsavel, string NomeResp, string CPFResp, string TelCelResp, string Emailresp)
        {
            this.Codigo = Id;
            this.Nome = nome;
            this.DatadeNascimento = datanascimento;
            this.Sexo = genero;
            this.Endereco = endereco;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = uf;
            this.CEP = cep;
            this.TelFixo = telfixo;
            this.RestricaoAlimentar = restricaoalimentar;
            this.RestricaoAlimObs = restricaoalimObs;
            this.RestricaoRemedio = restricaoremedio;
            this.RestricaoRemedioObs = restricaoremedioObs;
            this.NomeMae = nomemae;
            this.CPFmae = cpfmae;
            this.TelCelMae = telcelmae;
            this.Emailmae = emailmae;
            this.NomePai = nomepai;
            this.CPFpai = cpfpai;
            this.TelCelPai = telcelpai;
            this.Emailpai = emailpai;
            this.Responsavel = responsavel;
            this.NomeResp = nomeresp;
            this.CPFResp = cpfresp;
            this.TelCelResp = telcelresp;
            this.Emailresp = emailresp;
        }


        private int Id;
        public int Codigo
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }

        private string nome;
        public String Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        private DateTime datanascimento;
        public DateTime DatadeNascimento
        {
            get
            {
                return this.datanascimento;
            }
            set
            {
                this.datanascimento = value;
            }
        }

        private string genero;
        public String Sexo
        {
            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }

        private string endereco;
        public String Endereco
        {
            get
            {
                return this.endereco;
            }
            set
            {
                this.endereco = value;
            }
        }

        private int numero;
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        private string bairro;
        public String Bairro
        {
            get
            {
                return this.bairro;
            }
            set
            {
                this.bairro = value;
            }
        }

        private string cidade;
        public String Cidade
        {
            get
            {
                return this.cidade;
            }
            set
            {
                this.cidade = value;
            }
        }

        private string uf;
        public String Estado
        {
            get
            {
                return this.uf;
            }
            set
            {
                this.uf = value;
            }
        }

        private string cep;
        public String CEP
        {
            get
            {
                return this.cep;
            }
            set
            {
                this.cep = value;
            }
        }

        private string telfixo;
        public String TelFixo
        {
            get
            {
                return this.telfixo;
            }
            set
            {
                this.telfixo = value;
            }
        }

        private bool restricaoalimentar;
        public bool RestricaoAlimentar
        {
            get
            {
                return this.restricaoalimentar;
            }
            set
            {
                this.restricaoalimentar = value;
            }
        }

        private string restricaoalimObs;
        public String RestricaoAlimObs
        {
            get
            {
                return this.restricaoalimObs;
            }
            set
            {
                this.restricaoalimObs = value;
            }
        }

        private bool restricaoremedio;
        public bool RestricaoRemedio
        {
            get
            {
                return this.restricaoremedio;
            }
            set
            {
                this.restricaoremedio = value;
            }
        }

        private string restricaoremedioObs;
        public String RestricaoRemedioObs
        {
            get
            {
                return this.restricaoremedioObs;
            }
            set
            {
                this.restricaoremedioObs = value;
            }
        }

        private string nomemae;
        public String NomeMae
        {
            get
            {
                return this.nomemae;
            }
            set
            {
                this.nomemae = value;
            }
        }

        private string cpfmae;
        public String CPFmae
        {
            get
            {
                return this.cpfmae;
            }
            set
            {
                this.cpfmae = value;
            }
        }

        private string telcelmae;
        public String TelCelMae
        {
            get
            {
                return this.telcelmae;
            }
            set
            {
                this.telcelmae = value;
            }
        }

        private string emailmae;
        public String Emailmae
        {
            get
            {
                return this.emailmae;
            }
            set
            {
                this.emailmae = value;
            }
        }

        private string nomepai;
        public String NomePai
        {
            get
            {
                return this.nomepai;
            }
            set
            {
                this.nomepai = value;
            }
        }

        private string cpfpai;
        public String CPFpai
        {
            get
            {
                return this.cpfpai;
            }
            set
            {
                this.cpfpai = value;
            }
        }

        private string telcelpai;
        public String TelCelPai
        {
            get
            {
                return this.telcelpai;
            }
            set
            {
                this.telcelpai = value;
            }
        }

        private string emailpai;
        public String Emailpai
        {
            get
            {
                return this.emailpai;
            }
            set
            {
                this.emailpai = value;
            }
        }

        private string responsavel;
        public String Responsavel
        {
            get
            {
                return this.responsavel;
            }
            set
            {
                this.responsavel = value;
            }
        }

        private string nomeresp;
        public String NomeResp
        {
            get
            {
                return this.nomeresp;
            }
            set
            {
                this.nomeresp = value;
            }
        }

        private string cpfresp;
        public String CPFResp
        {
            get
            {
                return this.cpfresp;
            }
            set
            {
                this.cpfresp = value;
            }
        }

        private string telcelresp;
        public String TelCelResp
        {
            get
            {
                return this.telcelresp;
            }
            set
            {
                this.telcelresp = value;
            }
        }

        private string emailresp;
        public String Emailresp
        {
            get
            {
                return this.emailresp;
            }
            set
            {
                this.emailresp = value;
            }
        }
    }
}

