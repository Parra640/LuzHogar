using System.Linq;
using LuzHogar.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuzHogar.Controllers
{
    public class MuebleController : Controller
    {
        private LuzHogarContext _context;
        public MuebleController(LuzHogarContext c) {
            _context = c;
        }
        public IActionResult Index()
        {
            var lista = _context.Muebles.ToList();
            return View(lista);
        }

        //este es pa los pedidos especiales o personalizados
        public IActionResult Pedido()
        {
            
            return View();
        }

    }
}