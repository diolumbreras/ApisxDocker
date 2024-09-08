using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datadock
{
    public class Cursos
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Nombre { get; set; } = null!;
        [DataType(DataType.MultilineText)]
        [Display(Name = "Curso")]
        [MaxLength(2000, ErrorMessage = "El campo {0} debe tener máximo {1} caractér")]
        public string Descripcion { get; set; } = null!;

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Precio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal Precio { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Programa del curso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Programa { get; set; } = null!;

        [Display(Name = "Imagen")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Imagen { get; set; } = null!;
    }
}
