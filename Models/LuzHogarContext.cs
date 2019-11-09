using Microsoft.EntityFrameworkCore;

namespace LuzHogar.Models
{
    public class LuzHogarContext: DbContext
    {
        public DbSet<Cliente> Clientes {get;set;}

        public DbSet<Mueble> Muebles {get;set;}
        public DbSet<Contrato> Contratos {get;set;}
        
        public LuzHogarContext(DbContextOptions<LuzHogarContext>o):base(o){}
    }
}