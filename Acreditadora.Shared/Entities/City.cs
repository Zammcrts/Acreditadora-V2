using System.ComponentModel.DataAnnotations;

namespace Acreditadora.Shared.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Matricula")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Name { get; set; } = null!;

        public Country Country { get; set; } = null!;


    }
}
