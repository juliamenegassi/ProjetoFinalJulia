using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("ProcedimentoRealizado")]
    public class ProcedimentoRealizado
    {
        [Column("ProcedimentoRealizadoId")]
        [Display(Name = "Id do Procedimento Realizado")]
        public int ProcedimentoRealizadoId { get; set; }

        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        public int ProcedimentoId { get; set; }
        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        public int ColaboradorId { get; set; }
        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalId")]
        public int LocaRealizacaolId { get; set; }
        public LocalRealizacao? LocaRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data da Realização")]
        public DateTime DataRealizacao { get; set; }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação da Realização")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;
    }
}
