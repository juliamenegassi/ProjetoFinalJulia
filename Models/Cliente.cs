using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalJulia.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Id do Cliente")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteCpf")]
        [Display(Name = "CPF")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteSexo")]
        [Display(Name = "Sexo")]
        public string ClienteSexo { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("ClienteNumero")]
        [Display(Name = "Número")]
        public string ClienteNumero{ get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        public int CidadeId { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
