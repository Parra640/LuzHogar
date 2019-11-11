
using System.Linq;
using LuzHogar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LuzHogar.Controllers
{
    public class ContratoController : Controller
    {
        private LuzHogarContext _context;
        public ContratoController(LuzHogarContext c)
        {
            _context = c;
        }


        [Authorize]
        [HttpPost]
        public IActionResult RegistrarContrato(Contrato x)
        {
            if (ModelState.IsValid)
            {
                _context.Add(x);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View("Index","Home");
            
        }

        [Authorize]
        public IActionResult RegistrarPedidoEspecial()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult RegistrarPedidoEspecial(PedidoEspecial x)
        {
            if (ModelState.IsValid)
            {
                _context.Add(x);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(x);
        }
    }
}