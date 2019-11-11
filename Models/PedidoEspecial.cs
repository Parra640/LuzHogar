using System.ComponentModel.DataAnnotations;
namespace LuzHogar.Models
{
    public class PedidoEspecial
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
        
        public string Color { get; set; }

        [Display(Name="Descripción")]
        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public int Cantidad { get; set; }

        [Display(Name="Link de Foto Referencial")]
        public string Foto { get; set; }

        public Usuario Usuario { get; set; }
        
        public int UsuarioId { get; set; }

    }
}