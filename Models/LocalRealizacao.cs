using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Id do Local de Realização")]
        public int Id { get; set; }

        [Column("LocalRealizacaoNome")]
        [Display(Name = "Nome do Local")]
        public string LocalRealizacaoNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
