using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositorio
{
    public partial class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //TODO: Enfiar aqui o mapeamento das entidades. Usar Reflection, ou algo assim para popular tudo de uma vez.
        }

        //TODO: Ainda vou ver como vou lidar com a string de conexão... provavelmente colocarei em um .config lá nas camadas de cima (quando houver).
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("ConnectionString aqui.");
        //}
    }
}
