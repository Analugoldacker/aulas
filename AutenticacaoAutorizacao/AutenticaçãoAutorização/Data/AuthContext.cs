
using AutenticacaoAutorizacao.Models;
using Microsoft.EntityFrameworkCore;

namespace AutenticacaoAutorizacao.Data
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
