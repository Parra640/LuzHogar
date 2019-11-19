
namespace LuzHogar.Models
{
    public class Mueble
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Color { get; set; }

        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public int Stock { get; set; }

        public string Foto { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria{ get; set; }
    }
}