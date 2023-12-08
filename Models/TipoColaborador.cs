using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Id do Tipo Colaborador")]
        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Tipo do Colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}
