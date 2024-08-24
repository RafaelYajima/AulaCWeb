using System.ComponentModel.DataAnnotations;

namespace MoveisPrj.Models
{
    public class Movel
    {
        [Key]
        public int MovelId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nome { get; set;}
        [Required]
        [MinLength(10)]
        [MaxLength(200)]
        public string Descricao { get; set;}
        [Required]
        [MaxLength(30)]
        public string Cor {get; set;}
        public double Valor {get; set;}
        public bool Ativo { get; set;}
        public string ImagemUrl { get; set;}

        [Display(Name ="Categoria")]
        public virtual Categoria Categoria { get; set;}

    }
}
