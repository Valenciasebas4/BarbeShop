using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BarbeShop.DAL.Entities
{
    public class Service : Entity
    {
        [Display(Name = "Servicio")] //ASÍ ES COMO SE VA A MOSTRAR POR UI
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //LONGITUD MÁXIMA (NVARCHAR(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Name { get; set; }

        [Display(Name = "Descripción")] //ASÍ ES COMO SE VA A MOSTRAR POR UI
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //LONGITUD MÁXIMA (NVARCHAR(50))
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT NULL
        public string Description { get; set; }
    }
}
