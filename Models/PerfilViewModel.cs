using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LuzHogar.Models
{
    public class PerfilViewModel
    {

        public List<Contrato> Contratos { get; set; }
        public List<PedidoEspecial> PedidosEspeciales { get; set; }

        public Usuario Usuario { get; set; }



    }
}