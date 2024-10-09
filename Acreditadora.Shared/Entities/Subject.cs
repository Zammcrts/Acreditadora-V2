using System.ComponentModel.DataAnnotations;

namespace Acreditadora.Shared.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Materia")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede ser más de {1} caracteres")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Descripción")]
        public string Description { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Créditos")]
        public int Credits { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Horas")]
        public int Hours { get; set; }

    }
}
