using System;

namespace Biblioteca.Entidades
{
    public abstract class EntidadeBase
    {
        public long Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataModificacao { get; set; }
    }
}
