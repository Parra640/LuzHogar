using System.ComponentModel.DataAnnotations;

namespace LuzHogar.Models
{
    public class RegistrarContratoViewModel
    {

        public int MuebleId { get; set; }

        public Mueble Mueble { get; set; }

        public string Progreso { get; set; }

        public int Cantidad { get; set; }
    }
}