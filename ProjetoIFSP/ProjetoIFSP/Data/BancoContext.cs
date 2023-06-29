using Microsoft.EntityFrameworkCore;
using ProjetoIFSP.Models;

namespace ProjetoIFSP.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<ClienteModel> Clientes { get; set; }

    }
}
