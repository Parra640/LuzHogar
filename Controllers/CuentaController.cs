using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LuzHogar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace LuzHogar.Controllers
{
    public class CuentaController : Controller
    {
        private LuzHogarContext _context;
        private SignInManager<IdentityUser> _sim;
        private UserManager<IdentityUser> _um;
        private RoleManager<IdentityRole> _rm;
        public CuentaController(
            LuzHogarContext c,
            SignInManager<IdentityUser> s,
            UserManager<IdentityUser> um,
            RoleManager<IdentityRole> rm)
        {

            _context = c;
            _sim = s;
            _um = um;
            _rm = rm;
        }

        [Authorize(Roles="admin")]
        public IActionResult AsociarRol()
        {
            ViewBag.Usuarios = _um.Users.ToList();
            ViewBag.Roles = _rm.Roles.ToList();

            return View();
        }

        [Authorize(Roles="admin")]
        [HttpPost]
        public IActionResult AsociarRol(string usuario, string rol)
        {
            var user = _um.FindByIdAsync(usuario).Result;

            var resultado = _um.AddToRoleAsync(user, rol).Result;

            return RedirectToAction("index", "home");
        }

        [Authorize(Roles="admin")]
        public IActionResult CrearRol()
        {
            return View();
        }

        [Authorize(Roles="admin")]
        [HttpPost]
        public IActionResult CrearRol(string nombre)
        {
            var rol = new IdentityRole();
            rol.Name = nombre;

            var resultado = _rm.CreateAsync(rol).Result;

            return RedirectToAction("index", "home");
        }

        public IActionResult Crear()
        {
            return View();
        }

        public IActionResult AccesoDenegado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(CrearCuentaViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Guardar datos del modelo en la tabla usuarios
                var usuario = new IdentityUser();
                usuario.UserName = model.Correo;
                usuario.Email = model.Correo;

                IdentityResult resultado = _um.CreateAsync(usuario, model.Password1).Result;
                var r = _um.AddToRoleAsync(usuario, "Usuario").Result;


                if (resultado.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                else
                {
                    foreach (var item in resultado.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {


                var resultado = _sim.PasswordSignInAsync(model.Correo, model.Password, true, false).Result;

                if (resultado.Succeeded)
                {

                    return RedirectToAction("index", "home");
                }
                else
                {

                    ModelState.AddModelError("", "Datos incorrectos");
                }
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            _sim.SignOutAsync();

            return RedirectToAction("index", "home");
        }

        [Authorize]
        public IActionResult Perfil()
        {
            var usuario = (Usuario)_um.GetUserAsync(this.User).Result;
            var contratos = _context.Contratos.Include(x => x.Usuario)
                                   .Where(x => x.UsuarioId == int.Parse(usuario.Id))
                                   .ToList();
            
            //var usuario = _context.Usuarios.Where(x => x.Id == usuarioId).FirstOrDefaultAsync().Result;

            var viewModel = new PerfilViewModel();

            viewModel.Contratos = contratos;
            //viewModel.Usuario = usuario;

            return View(viewModel);
        }
    }
}