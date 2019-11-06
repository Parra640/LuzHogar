using System.ComponentModel.DataAnnotations;

namespace LuzHogar.Models
{
    public class Mueble
    {

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string Foto { get; set; }
    }
}