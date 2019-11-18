using System.ComponentModel.DataAnnotations;

namespace LuzHogar.Models
{
    public class RegistrarPedidoViewModel
    {
        
        public string Nombre { get; set; }
        
        public string Color { get; set; }

        [Display(Name="Descripción")]
        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public int Cantidad { get; set; }

        public string Estado { get; set; }

        [Display(Name="Link de Foto Referencial")]
        public string Foto { get; set; }
    }
}