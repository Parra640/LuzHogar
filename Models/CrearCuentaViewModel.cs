using System.ComponentModel.DataAnnotations;

namespace LuzHogar.Models
{
    public class CrearCuentaViewModel
    {
        [Required]
        [Display(Name="Nombre")]
        public string Nombre{get; set;}

        [Required]
        [Display(Name="Apellido Paterno")]
        public string ApePaterno{get; set;}

        [Required]
        [Display(Name="Apellido Materno")]
        public string ApeMaterno{get; set;}

        [Required]
        [Display(Name="Dirección")]
        public string Direccion{get; set;}

        [Required]
        public string Referencia{get; set;}

        [Required]
        [Display(Name="Teléfono")]
        public int Telefono{get; set;}

        [Required]
        public int Dni{get; set; }

        [Required]
        [Display(Name="Correo Electrónico")]
        public string Correo{get; set;}    

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