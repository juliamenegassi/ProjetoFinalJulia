using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("procedimento")]
    public class Procedimento
    {
        [Column("ProcedimentoId")]
        [Display(Name = "Id do Procedimento")]
        public int ProcedimentoId { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("TipoProcedimentoId")]
        public int TipoProcedimentoId { get; set; }
        public TipoProcedimento? TipoProcedimento { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        public int LocalRealizacaoId { get; set; }
        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data da Realização")]
        public DateTime DataRealizacao { get; set; }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação da Realização")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;
    }
}
