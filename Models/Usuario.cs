using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace LuzHogar.Models
{
    public class Usuario : IdentityUser
    {

        [Required]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido Paterno")]
        public string ApePaterno { get; set; }

        [Required]
        [Display(Name = "Apellido Materno")]
        public string ApeMaterno { get; set; }

        [Required]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required]
        public string Referencia { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required]
        public string Dni { get; set; }

        [Required]
        [Display(Name = "Correo Electrónico")]
        public string Correo { get; set; }
    }
}