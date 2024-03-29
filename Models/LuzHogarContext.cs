using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LuzHogar.Models
{
    public class LuzHogarContext : IdentityDbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Mueble> Muebles { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<PedidoEspecial> PedidosEspeciales { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public LuzHogarContext(DbContextOptions<LuzHogarContext> o) : base(o) { }
    }
}