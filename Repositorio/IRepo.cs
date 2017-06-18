using System;
using System.Collections.Generic;

namespace Biblioteca.Repositorio
{
    public interface IRepo<T> : IDisposable where T : Entidades.EntidadeBase
    {
        IEnumerable<T> Todos();
        T Get(int id);
        void Delete(T entidade);
        void Save(T entidade);
        void Save();
    }
}
