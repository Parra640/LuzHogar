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

            RegistrarContratoViewModel viewModel=new RegistrarContratoViewModel();
            var mueble=_context.Muebles.Where(m => m.Id==id).FirstOrDefault();
            viewModel.MuebleId=id;
            viewModel.Mueble=mueble;
            viewModel.Progreso="";
            viewModel.Cantidad=0;
            return View(viewModel);
            
        }

        [Authorize]
        [HttpPost]
        public IActionResult RegistrarContrato(RegistrarContratoViewModel x)
        {
            if (ModelState.IsValid)
            {
                var usuario = _um.GetUserAsync(this.User).Result;
                var mueble=_context.Muebles.Where(m => m.Id==x.MuebleId).FirstOrDefault();
                mueble.Stock=mueble.Stock-x.Cantidad;
                _context.Update(mueble);
                _context.SaveChanges();

                Contrato contrato= new Contrato();
                contrato.MuebleId=mueble.Id;
                contrato.Mueble=_context.Muebles.Where(m => m.Id==x.MuebleId).FirstOrDefault();
                contrato.UsuarioId=usuario.Id;
                contrato.Usuario=usuario;
                contrato.Progreso=x.Progreso;
                contrato.Cantidad=x.Cantidad;

                _context.Add(contrato);
                _context.SaveChanges();

                return RedirectToAction("listacontratos", "cuenta");
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
        public IActionResult RegistrarPedidoEspecial(RegistrarPedidoViewModel x)
        {
            if(ModelState.IsValid){
                var usuario = _um.GetUserAsync(this.User).Result;
                PedidoEspecial pedido=new PedidoEspecial();
                pedido.Nombre=x.Nombre;
                pedido.Color=x.Color;
                pedido.Descripcion=x.Descripcion;
                pedido.Cantidad=x.Cantidad;
                pedido.Precio=x.Precio;
                pedido.Foto=x.Foto;
                pedido.Estado=x.Estado;
                pedido.UsuarioId=usuario.Id;
                pedido.Usuario=usuario;

                _context.Add(pedido);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(x);
        }

    }
}