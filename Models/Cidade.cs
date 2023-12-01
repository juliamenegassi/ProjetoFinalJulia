using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("CidadeId")]
        [Display(Name = "Id da Cidade")]
        public int CidadeId { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome da Cidade")]
        public string NomeCidade { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
    }
}
