using System.ComponentModel.DataAnnotations;

namespace LuzHogar.Models
{
    public class Stock
    {
        public int Id { get; set; }
        
        [Required]
        public int Cantidad { get; set; }
        
        [Required]
        public int MuebleId { get; set}
    }
}