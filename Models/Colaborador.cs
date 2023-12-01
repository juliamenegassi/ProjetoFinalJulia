using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Column("ColaboradorId")]
        [Display(Name = "Id do Colaborador")]
        public int ColaboradorId { get; set; }

        [Column("ColaboradorNome")]
        [Display(Name = "Nome")]
        public string ColaboradorNome { get; set; } = string.Empty;

        [Column("ColaboradorCpf")]
        [Display(Name = "CPF")]
        public string ColaboradorCpf { get; set; } = string.Empty;

        [Column("ColaboradorSexo")]
        [Display(Name = "Sexo")]
        public string ColaboradorSexo { get; set; } = string.Empty;

        [Column("ColaboradorTelefone")]
        [Display(Name = "Telefone")]
        public string ColaboradorTelefone { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }

        [ForeignKey("TipoColaboradorId")]
        public int TipoColaboradorId { get; set; }
        public TipoColaborador? TipoColaborador { get; set; }
    }
}
