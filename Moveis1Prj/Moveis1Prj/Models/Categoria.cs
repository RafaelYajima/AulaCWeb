using System.ComponentModel.DataAnnotations;

namespace Moveis1Prj.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        public List<Movel> Moveis { get; set; }
    }
}
