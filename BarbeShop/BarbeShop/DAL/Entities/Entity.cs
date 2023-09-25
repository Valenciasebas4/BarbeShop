using System.ComponentModel.DataAnnotations;

namespace BarbeShop.DAL.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "Fecha de Creacion")] 
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Fecha de Modificación")]
        public DateTime? ModifiedDate { get; set; }
    }
}
