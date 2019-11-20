using System.Linq;
using LuzHogar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace LuzHogar.Controllers
{
    public class MuebleController : Controller
    {
        private LuzHogarContext _context;
        private UserManager<Usuario> _um;
        public MuebleController(LuzHogarContext c, UserManager<Usuario> um)
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

        public IActionResult Mueble(int id)
        {
            var mueble = _context.Muebles
                            .Include(x => x.Categoria)
                            .Where(x => x.Id == id)
                            .FirstOrDefault();
            var usuario = _um.GetUserAsync(this.User).Result;

            return View(mueble);
        }

        [Authorize(Roles="admin")]
        public IActionResult AgregarMueble()
        {
            var categorias=_context.Categorias.OrderBy(x => x.Nombre).ToList();
            ViewBag.Categorias=categorias;
            return View();
        }


        [Authorize(Roles="admin")]
        [HttpPost]
        public IActionResult AgregarMueble(Mueble x)
        {
            var categorias=_context.Categorias.OrderBy(c => c.Nombre).ToList();
            ViewBag.Categorias=categorias;
            if (ModelState.IsValid)
            {
                
                _context.Add(x);
                _context.SaveChanges();
                TempData["mensaje"]="Mueble agregado con éxito";
                TempData["tipoTexto"]="text-success";
                
                return RedirectToAction("AgregarMueble");
            }
            
            TempData["mensaje"]="Error. No se pudo agregar el mueble";
            TempData["tipoTexto"]="text-danger";
            return View(x);
        }

        [Authorize(Roles="admin")]
        public IActionResult ModificarMueble()
        {
            var muebles=_context.Muebles
                        .Include(x => x.Categoria)
                        .ToList();
            return View(muebles);
        }


        [Authorize(Roles="admin")]
        public IActionResult ActualizarMueble(int muebleId)
        {
            var mueble=_context.Muebles
                        .Include(x => x.Categoria)
                        .Where(x => x.Id==muebleId)
                        .FirstOrDefault();
            var categorias=_context.Categorias.OrderBy(c => c.Nombre).ToList();
            ViewBag.Categorias=categorias;
            
            return View(mueble);
        }

        [Authorize(Roles="admin")]
        [HttpPost]
        public IActionResult ActualizarMueble(Mueble x)
        {
            var categorias=_context.Categorias.OrderBy(c => c.Nombre).ToList();
            ViewBag.Categorias=categorias;

            if (ModelState.IsValid)
            {
                 var mueble=_context.Muebles
                        .Include(x => x.Categoria)
                        .Where(x => x.Id==muebleId)
                        .FirstOrDefault();
                TryUpdateModel(x);

                
                //_context.Update(x);
                _context.SaveChanges();
                TempData["mensaje"]="Mueble modificado con éxito";
                TempData["tipoTexto"]="text-success";
                
                return RedirectToAction("ModificarMueble");
            }
            
            TempData["mensaje"]="Error. No se pudo modificar el mueble";
            TempData["tipoTexto"]="text-danger";
            return RedirectToAction("ModificarMueble");
        }

        

    }


}