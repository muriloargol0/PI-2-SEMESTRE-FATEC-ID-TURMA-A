using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDoações.Objetos
{
    class Saida
    {

        private int idMovimentacao = -1;
        private string tipoMovimentacao = "Saída";
        private double valor = 0;
        private string tipoDespesa = ""; //Fixo ou variavel
        private string descricao = "";
        private string fkNomeColaboradorResponsavel = "";
        private int fkIdColaboradorResponsavel = -1;
        private string notaFiscal = "";
        private string fkUsuarioRegistro = "";
        private string fkUsuarioUltimaAlteracao;
        private DateTime dataHoraRegistro;
        private DateTime dataHoraUltimaAlteracao;



        public int IdMovimentacao { get => idMovimentacao; set => idMovimentacao = value; }
        public string TipoMovimentacao { get => tipoMovimentacao; set => tipoMovimentacao = value; }
        public double Valor { get => valor; set => valor = value; }
        public string TipoDespesa { get => tipoDespesa; set => tipoDespesa = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string FkNomeColaboradorResponsavel { get => fkNomeColaboradorResponsavel; set => fkNomeColaboradorResponsavel = value; }
        public string NotaFiscal { get => notaFiscal; set => notaFiscal = value; }
        public string FkUsuarioRegistro { get => fkUsuarioRegistro; set => fkUsuarioRegistro = value; }
        public string FkUsuarioUltimaAlteracao { get => fkUsuarioUltimaAlteracao; set => fkUsuarioUltimaAlteracao = value; }
        public DateTime DataHoraRegistro { get => dataHoraRegistro; set => dataHoraRegistro = value; }
        public DateTime DataHoraUltimaAlteracao { get => dataHoraUltimaAlteracao; set => dataHoraUltimaAlteracao = value; }
        public int FkIdColaboradorResponsavel { get => fkIdColaboradorResponsavel; set => fkIdColaboradorResponsavel = value; }
    }
}
