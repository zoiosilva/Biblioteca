 
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Biblioteca.Repositorio
{
    public partial class Contexto : DbContext
    {
        //ns: Biblioteca.Entidades:
        public DbSet<Biblioteca.Entidades.Documento> Documento { get; set; }
        public DbSet<Biblioteca.Entidades.Livro> Livro { get; set; }
        public DbSet<Biblioteca.Entidades.Autor> Autor { get; set; }
        public DbSet<Biblioteca.Entidades.Cdd> Cdd { get; set; }
        public DbSet<Biblioteca.Entidades.Cdu> Cdu { get; set; }
        public DbSet<Biblioteca.Entidades.Pha> Pha { get; set; }
        public DbSet<Biblioteca.Entidades.Cutter> Cutter { get; set; }

    }
}
