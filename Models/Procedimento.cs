using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Id do Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observação")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("TipoProcedimentoId")]
        public int TipoProcedimentoId { get; set; }

        [Display(Name = "Tipo Procedimento")]
        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}
