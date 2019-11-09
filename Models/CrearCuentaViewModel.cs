using System.ComponentModel.DataAnnotations;

namespace LuzHogar.Models
{
    public class CrearCuentaViewModel
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
        public string Password1 { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Confirmar Contraseña")]
        [Compare("Password1", ErrorMessage = "Las contraseñas no coinciden")]
        public string Password2 { get; set; }
    }
}