using System.ComponentModel.DataAnnotations;

namespace LuzHogar.Models
{
    public class Cliente
    {
        [Required]
        public int Id{get; set;}

        [Required]
        public string Nombre{get; set;}

        [Required]
        public string Direccion{get; set;}

        [Required]
        public string Referencia{get; set;}

        [Required]
        public int Telefono{get; set;}

        [Required]
        public int Dni{get; set; }

        [Required]
        public string Email{get; set;}    
    }
}