using Dominio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        [MaxLength(2000)]
        public string Descricao { get; set; }

        [Required]
        [Range(0, 999999999999.99)]
        public decimal Valor { get; set; }

        [ForeignKey("Loja")]
        public int LojaId { get; set; }

        public virtual Loja Loja { get; set; }
    }
}
