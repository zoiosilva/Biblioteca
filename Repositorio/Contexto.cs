using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositorio
{
    public partial class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("ConnectionString aqui.");
        }
    }
}
