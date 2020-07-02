using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDoações.Objetos
{
    class Entrada
    {
        private int idMovimentacao = -1;
        private string tipoMovimentacao = "Entrada";
        private double valor = 0;
        private int fkIdOrigem = -1;
        private string fkNomeOrigem = "";
        private string descricao = "";
        private string fkNomeColaboradorResponsavel = "";
        private int fkIdColaboradorResponsavel = -1;
        private string notaFiscal = "";
        private string fkUsuarioRegistro = "";
        private string fkUsuarioUltimaAlteracao;
        private DateTime dataHoraRegistro;
        private DateTime dataHoraUltimaAlteracao;

        public int IdMovimentacao { get => idMovimentacao; set => idMovimentacao = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string FkNomeColaboradorResponsavel { get => fkNomeColaboradorResponsavel; set => fkNomeColaboradorResponsavel = value; }
        public string NotaFiscal { get => notaFiscal; set => notaFiscal = value; }
        public string FkUsuarioRegistro { get => fkUsuarioRegistro; set => fkUsuarioRegistro = value; }
        public string FkUsuarioUltimaAlteracao { get => fkUsuarioUltimaAlteracao; set => fkUsuarioUltimaAlteracao = value; }
        public DateTime DataHoraRegistro { get => dataHoraRegistro; set => dataHoraRegistro = value; }
        public DateTime DataHoraUltimaAlteracao { get => dataHoraUltimaAlteracao; set => dataHoraUltimaAlteracao = value; }
        public string TipoMovimentacao { get => tipoMovimentacao; set => tipoMovimentacao = value; }
        public int FkIdOrigem { get => fkIdOrigem; set => fkIdOrigem = value; }
        public int FkIdColaboradorResponsavel { get => fkIdColaboradorResponsavel; set => fkIdColaboradorResponsavel = value; }
        public string FkNomeOrigem { get => fkNomeOrigem; set => fkNomeOrigem = value; }
    }

}
