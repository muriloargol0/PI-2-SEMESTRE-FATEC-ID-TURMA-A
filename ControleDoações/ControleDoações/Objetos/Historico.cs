using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDoações.Objetos
{
    class Historico
    {
        private int idHistorico = -1;
        private int idMovimentacao = -1;
        private string tipoMovimentacao = "";
        private string fkIdOrigem = "";
        private string tipoDespesa = ""; //Fixa ou variavel
        private double valor = -1;
        private string descricao = "";
        private int fkIdColaboradorResponsavel = -1;
        private string notaFiscal = "";
        private string fkUsuarioRegistro = "";
        private string fkUsuarioUltimaAlteracao;
        private string fkUsuarioRemocao;
        private DateTime dataHoraRegistro;
        private DateTime dataHoraUltimaAlteracao;
        private DateTime dataHoraRemocao;

        public int IdHistorico { get => idHistorico; set => idHistorico = value; }
        public int IdMovimentacao { get => idMovimentacao; set => idMovimentacao = value; }
        public string TipoMovimentacao { get => tipoMovimentacao; set => tipoMovimentacao = value; }
        public string FkIdOrigem { get => fkIdOrigem; set => fkIdOrigem = value; }
        public string TipoDespesa { get => tipoDespesa; set => tipoDespesa = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int FkIdColaboradorResponsavel { get => fkIdColaboradorResponsavel; set => fkIdColaboradorResponsavel = value; }
        public string NotaFiscal { get => notaFiscal; set => notaFiscal = value; }
        public string FkUsuarioRegistro { get => fkUsuarioRegistro; set => fkUsuarioRegistro = value; }
        public string FkUsuarioUltimaAlteracao { get => fkUsuarioUltimaAlteracao; set => fkUsuarioUltimaAlteracao = value; }
        public string FkUsuarioRemocao { get => fkUsuarioRemocao; set => fkUsuarioRemocao = value; }
        public DateTime DataHoraRegistro { get => dataHoraRegistro; set => dataHoraRegistro = value; }
        public DateTime DataHoraUltimaAlteracao { get => dataHoraUltimaAlteracao; set => dataHoraUltimaAlteracao = value; }
        public DateTime DataHoraRemocao { get => dataHoraRemocao; set => dataHoraRemocao = value; }
    }
}
