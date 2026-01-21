using System.ComponentModel.DataAnnotations;

namespace RubiaDivina.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        [Display(Name = "Categoría")]
        public string Nombre { get; set; }

    }
}
