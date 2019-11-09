
using System.ComponentModel.DataAnnotations;
namespace LuzHogar.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="Nombre")]
        public string Nombre{get; set;}

        [Required]
        [EmailAddress]
        [Display(Name="Correo electrónico")]
        public string Correo { get; set; }

        [Required]
        [Display(Name="Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}