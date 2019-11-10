using System.Linq;
using LuzHogar.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuzHogar.Controllers
{
    public class UsuarioController : Controller
    {
        private LuzHogarContext _context;
        public UsuarioController(LuzHogarContext c) {
            _context = c;
        }
        public IActionResult Index()
        {
            var lista = _context.Usuarios.ToList();
            return View(lista);
        }
        public IActionResult Registro()
        {
            ViewBag.Contratos = _context.Contratos.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Usuario x)
        {
            if (ModelState.IsValid) {
                _context.Add(x);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Contratos = _context.Contratos.ToList();
            return View(x);
        }        
    }
}