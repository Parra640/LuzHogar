using System.Collections.Generic;

namespace LuzHogar.Models
{
    public class PerfilViewModel
    {
        
        [Required]
        [EmailAddress]
        [Display(Name="Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [Display(Name="Nombre de Usuario")]
        public string Username { get; set; }

        [Required]
        public string Dirección { get; set; }

        [Required]
        public string Referencia{get; set;}

        [Required]
        public int Telefono{get; set;}

        [Required]
        public int Dni{get; set; }

        public List<Contrato> Contratos { get; set; }

    }
}