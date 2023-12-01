using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("")]
    public class TipoColaborador
    {
        [Column("TipoColaboradorId")]
        [Display(Name = "Id do Tipo Colaborador")]
        public int TipoColaboradorId { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Tipo do Colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}
