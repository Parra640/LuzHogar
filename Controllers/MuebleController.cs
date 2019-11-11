using System.Linq;
using LuzHogar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LuzHogar.Controllers
{
    public class MuebleController : Controller
    {
        private LuzHogarContext _context;
        private UserManager<IdentityUser> _um;
        public MuebleController(LuzHogarContext c, UserManager<IdentityUser> um)
        {
            _um = um;
            _context = c;
        }
        public IActionResult Galeria()
        {
            var lista = _context.Muebles.ToList();
            return View(lista);
        }

        //este es pa los pedidos especiales o personalizados
        [HttpGet("{id}")]
        public IActionResult Mueble(int id)
        {
            var mueble = _context.Muebles.Where(x => x.Id == id).FirstOrDefault();
            var usuario=(Usuario)_um.GetUserAsync(this.User).Result;

            ViewBag.Usuario=usuario;
            
            return View(mueble);
        }

    }
}