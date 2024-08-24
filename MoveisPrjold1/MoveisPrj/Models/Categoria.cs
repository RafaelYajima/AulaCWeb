using System.ComponentModel.DataAnnotations;

namespace MoveisPrj.Models
{
    public class Categoria
    {
        [Key]
        public string CategoriaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        public List<Movel> Moveis { get; set; }

    }
}
