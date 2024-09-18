using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acreditadora.Shared.Entities
{
    public class University
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatorio")] //obligatorio pertenece al public string Name
        [Display(Name = "Universidad")]
        [MaxLength(100, ErrorMessage ="El campo {0} no puede tener mas de {1} caracteres")]
        public string Name { get; set; } = null!; //no acepta valores nulos
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //obligatorio pertenece al public string Name
        [Display(Name = "Sitio Web")]
        [MaxLength(200, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Url { get; set; } =null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //obligatorio pertenece al public string Name
        [Display(Name = "Telefono")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string PhoneNumber { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //obligatorio pertenece al public string Name
        [Display(Name = "Direccion")]
        [MaxLength(200, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Address { get; set; } = null!;
        public bool Active { get; set; }

    }
}
