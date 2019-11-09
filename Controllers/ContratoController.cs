
using System.Linq;
using LuzHogar.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuzHogar.Controllers
{
    public class ContratoController : Controller
    {
        private LuzHogarContext _context;
        public ContratoController(LuzHogarContext c) {
            _context = c;
        }
        public IActionResult Index()
        {
            var lista = _context.Contratos.ToList();
            return View(lista);
        }
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Contrato x)
        {
            if (ModelState.IsValid) {
                _context.Add(x);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(x);
        }
    }
}