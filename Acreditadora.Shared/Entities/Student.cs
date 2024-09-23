using System.ComponentModel.DataAnnotations;

namespace Acreditadora.Shared.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]  
        [Display(Name = "Matricula")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Enrollment { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]  
        [Display(Name = "Teléfono")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]  
        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]  
        [Display(Name = "Primer Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]  
        [Display(Name = "Segundo Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string SurName { get; set; } = null!;

        [Required(ErrorMessage = "El campo {0} es obligatorio")]  
        [Display(Name = "Apellidos")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string LastName { get; set; } = null!;

        public bool Active { get; set; }

    }
}
