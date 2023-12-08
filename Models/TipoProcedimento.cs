using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("TipoPocedimento")]
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "Id do Tipo do Procedimento")]
        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Tipo do Procedimento")]
        public string TipoProcedimentoNome { get; set; } = string.Empty;
    }
}
