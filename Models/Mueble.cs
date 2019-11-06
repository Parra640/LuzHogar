using System.ComponentModel.DataAnnotations;

namespace LuzHogar.Models
{
    public class Mueble
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Color { get; set; }
        [Required]
        public string Descripcion { get; set; }
        
    }
}