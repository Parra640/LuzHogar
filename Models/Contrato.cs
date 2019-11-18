namespace LuzHogar.Models
{
    public class Contrato
    {
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        public string UsuarioId { get; set; }

        public Mueble Mueble { get; set; }

        public int MuebleId { get; set; }

        public string Progreso { get; set; }

        public int Cantidad { get; set; }
    }
}