using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositorio
{
    public partial class Contexto
    {
        public DbSet<Biblioteca.Entidades.Catalogacao.Cdd> Cdd { get; set; }
        public DbSet<Biblioteca.Entidades.Catalogacao.Cdu> Cdu { get; set; }
        public DbSet<Biblioteca.Entidades.Catalogacao.Cutter> Cutter { get; set; }
        public DbSet<Biblioteca.Entidades.Catalogacao.Pha> Pha { get; set; }
        public DbSet<Biblioteca.Entidades.Autor> Autor { get; set; }
        public DbSet<Biblioteca.Entidades.Documento> Documento { get; set; }
        public DbSet<Biblioteca.Entidades.Livro> Livro { get; set; }
    }
}
