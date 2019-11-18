using System.Linq;
using LuzHogar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LuzHogar.Controllers
{
    public class ContratoController : Controller
    {
        private LuzHogarContext _context;
        private UserManager<Usuario> _um;
        public ContratoController(LuzHogarContext c, UserManager<Usuario> um)
        {
            _context = c;
            _um=um;
        }

        [Authorize]
        public IActionResult RegistrarContrato(int id)
        {
            var usuario = _um.GetUserAsync(this.User).Result;
            Contrato x= new Contrato();
            x.MuebleId=id;
            x.Mueble=_context.Muebles.Where(m => m.Id==id).FirstOrDefault();
            x.UsuarioId=usuario.Id;
            x.Usuario=usuario;
            return View(x);
            
        }

        [Authorize]
        [HttpPost]
        public IActionResult RegistrarContrato(Contrato x)
        {
            if (ModelState.IsValid)
            {
                Mueble mueble=_context.Muebles.Where(m => m.Id == x.MuebleId).FirstOrDefault();
                mueble.Stock=mueble.Stock-1;
                _context.Update(mueble);
                x.mueble=mueble;
                _context.Add(x);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View("Index","Home");
            
        }

        [Authorize]
        public IActionResult RegistrarPedidoEspecial()
        {
            var usuario = _um.GetUserAsync(this.User).Result;
            ViewBag.Usuario=usuario;
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