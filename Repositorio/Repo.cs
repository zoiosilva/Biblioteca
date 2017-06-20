using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Repositorio
{
    public class Repo<T> : IRepo<T> where T : Entidades.EntidadeBase
    {
        internal readonly Contexto contexto;
        internal DbSet<T> entidades;

        public Repo(Contexto contexto)
        {
            this.contexto = contexto;
            entidades = contexto.Set<T>();
        }

        public IEnumerable<T> Todos()
        {
            return entidades.AsEnumerable();
        }

        public T Get(int id)
        {
            return entidades.SingleOrDefault(e => e.Id == id);
        }

        public void Delete(T entidade)
        {
            if (entidade == null)
                throw new ArgumentNullException(nameof(entidade));

            entidades.Remove(entidade);
            contexto.SaveChanges();
        }

        public void Save(T entidade)
        {
            if (entidade == null)
                throw new ArgumentNullException(nameof(entidade));

            entidades.Add(entidade);
            contexto.SaveChanges();
        }

        public void Save()
        {
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            if (contexto != null)
                contexto.Dispose();
        }
    }
}
