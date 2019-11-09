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
            var lista = _context.Clientes.ToList();
            return View(lista);
        }
        public IActionResult Registro()
        {
            ViewBag.Contratos = _context.Contratos.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Cliente x)
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