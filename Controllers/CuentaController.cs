using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LuzHogar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace LuzHogar.Controllers
{
    public class CuentaController : Controller
    {
        private LuzHogarContext _context;
        private SignInManager<Usuario> _sim;
        private UserManager<Usuario> _um;
        private RoleManager<IdentityRole> _rm;
        public CuentaController(
            LuzHogarContext c,
            SignInManager<Usuario> s,
            UserManager<Usuario> um,
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
            
            TempData["mensaje"]="Categoria asociada con éxito";
            TempData["tipoTexto"]="text-success";
            ViewBag.Usuarios = _um.Users.ToList();
            ViewBag.Roles = _rm.Roles.ToList();
            return View();
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

            if(resultado.Succeeded){
                TempData["mensaje"]="Rol creado con éxito";
                TempData["tipoTexto"]="text-success";
            }else{
                TempData["mensaje"]="No se pudo crear el rol";
                TempData["tipoTexto"]="text-danger";
            }
            return View();
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
                var usuario = new Usuario();
                usuario.UserName = model.Correo;
                usuario.Nombre = model.Nombre;
                usuario.ApePaterno = model.ApePaterno;
                usuario.ApeMaterno = model.ApeMaterno;
                usuario.Direccion = model.Direccion;
                usuario.Referencia = model.Referencia;
                usuario.Telefono = model.Telefono;
                usuario.Dni = model.Dni;
                usuario.Correo = model.Correo;

                IdentityResult resultado = _um.CreateAsync(usuario, model.Password1).Result;
                var r = _um.AddToRoleAsync(usuario, "usuario").Result;

                if (resultado.Succeeded)
                {
                    TempData["mensaje"]="Cuenta creada con éxito";
                    TempData["tipoTexto"]="text-success";
                    return View();
                }
                else
                {
                    TempData["mensaje"]="Error. No se pudo crear a cuenta";
                    TempData["tipoTexto"]="text-danger";
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
                    TempData["mensaje"]="Error. Datos incorrectos";
                    TempData["tipoTexto"]="text-danger";
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
            var usuario = _um.GetUserAsync(this.User).Result;
            
            

            return View(usuario);
        }

        [Authorize]
        public IActionResult ActualizarPerfil(Usuario x)
        {
            
                var usuario = _um.GetUserAsync(this.User).Result;
                usuario.Nombre=x.Nombre;
                usuario.ApePaterno=x.ApePaterno;
                usuario.ApeMaterno=x.ApeMaterno;
                usuario.Direccion=x.Direccion;
                usuario.Dni=x.Dni;
                usuario.Referencia=x.Referencia;
                usuario.Telefono=x.Telefono;
                _context.Update(usuario);
                _context.SaveChanges();
                TempData["mensaje"]="Datos actualizados con éxito";
                TempData["tipoTexto"]="text-success";
            return RedirectToAction("perfil");
        }

        [Authorize]
        public IActionResult ListaContratos(){
            var usuario = _um.GetUserAsync(this.User).Result;
            var contratos = _context.Contratos
                                    .Include(x => x.Mueble)
                                    .Include(x => x.Usuario)
                                   .Where(x => x.UsuarioId == usuario.Id)
                                   .OrderByDescending(x => x.Id)
                                   .ToList();
            return View(contratos);
        }

        [Authorize]
        public IActionResult ListaPedidos(){
            var usuario = _um.GetUserAsync(this.User).Result;
            var pedidos = _context.PedidosEspeciales.Include(x => x.Usuario)
                                   .Where(x => x.UsuarioId == usuario.Id)
                                   .OrderByDescending(x => x.Id)
                                   .ToList();
            return View(pedidos);
        }

        [Authorize]
        public IActionResult ActualizarPedido(int id, int acepta){
            var pedido = _context.PedidosEspeciales
                                   .Where(x => x.Id == id)
                                   .FirstOrDefault();
            if(acepta==1){
                pedido.Estado="Fabricando el mueble";
                _context.Update(pedido);
            }else if(acepta==0){
                _context.Remove(pedido);
            }else{
                return RedirectToAction("ListaPedidos","Cuenta");
            }
            _context.SaveChanges();
            
            return RedirectToAction("ListaPedidos","Cuenta");
        }

        
        [Authorize]
        public IActionResult AtenderPedidos(){
            var pedidos = _context.PedidosEspeciales
                                   .OrderByDescending(x => x.Id)
                                   .ToList();
            return View(pedidos);
        }

        [Authorize]
        public IActionResult ColocarPrecioAlPedido(int id, float precio){
            var pedido = _context.PedidosEspeciales
                                   .Where(x => x.Id == id)
                                   .FirstOrDefault();
            pedido.Estado="Esperando respuesta cliente";
            pedido.Precio=precio;
            _context.Update(pedido);
            _context.SaveChanges();
            return RedirectToAction("AtenderPedidos");
        }

        [Authorize]
        public IActionResult ColocarEstadoAlPedido(int id, string estado){
            var pedido = _context.PedidosEspeciales
                                   .Where(x => x.Id == id)
                                   .FirstOrDefault();
            pedido.Estado=estado;
            _context.Update(pedido);
            _context.SaveChanges();
            return RedirectToAction("AtenderPedidos");
        }

        [Authorize]
        public IActionResult CancelarPedido(int id){
            var pedido = _context.PedidosEspeciales
                                   .Where(x => x.Id == id)
                                   .FirstOrDefault();

            _context.Remove(pedido);
            _context.SaveChanges();
            return RedirectToAction("AtenderPedidos");
        }


        [Authorize]
        public IActionResult AtenderContratos(){
            var contratos = _context.Contratos
                                    .Include(x => x.Usuario)
                                    .Include(x => x.Mueble)
                                   .OrderByDescending(x => x.Id)
                                   .ToList();
            return View(contratos);
        }

        [Authorize]
        public IActionResult CambiarProgresoAlContrato(int id, string progreso){
            var contrato = _context.Contratos
                                    .Include(x => x.Usuario)
                                    .Include(x => x.Mueble)
                                    .Where(x => x.Id==id)
                                   .FirstOrDefault();

            contrato.Progreso=progreso;
            _context.Update(contrato);
            _context.SaveChanges();
            return RedirectToAction("AtenderContratos");
        }

        [Authorize(Roles="admin")]
        public IActionResult CrearCategoria()
        {
            return View();
        }

        [Authorize(Roles="admin")]
        [HttpPost]
        public IActionResult CrearCategoria(string nombre)
        {
            var categoria = new Categoria();
            categoria.Nombre = nombre;

            _context.Update(categoria);
            _context.SaveChanges();
            TempData["mensaje"]="Categoria creada con éxito";
            TempData["tipoTexto"]="text-success";
            return View();
        }

        [Authorize(Roles="admin")]
        public IActionResult ModificarCategoria()
        {
            ViewBag.Muebles = _context.Muebles.OrderBy(x => x.Nombre).ToList();
            ViewBag.Categorias = _context.Categorias.OrderBy(x => x.Nombre).ToList();
            
            return View();
        }

        [Authorize(Roles="admin")]
        [HttpPost]
        public IActionResult ModificarCategoria(int muebleId, int catId)
        {
            var mueble=_context.Muebles
                                    .Include(x => x.Categoria)
                                    .Where(x => x.Id == muebleId).FirstOrDefault();

            var categoria=_context.Categorias.Where(x => x.Id==catId).FirstOrDefault();

            mueble.CategoriaId=categoria.Id;
            mueble.Categoria=categoria;
            
            ViewBag.Muebles = _context.Muebles.OrderBy(x => x.Nombre).ToList();
            ViewBag.Categorias = _context.Categorias.OrderBy(x => x.Nombre).ToList();
            
            _context.Update(mueble);
            _context.SaveChanges();
            TempData["mensaje"]="Categoria modificada con éxito";
            TempData["tipoTexto"]="text-success";
            return View();
        }
    }
}