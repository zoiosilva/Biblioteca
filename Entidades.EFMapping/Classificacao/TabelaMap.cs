using Biblioteca.Entidades.Catalogacao;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Entidades.EFMapping.Classificacao
{
    public abstract class TabelaMap<T> : BaseMap<T> where T : Tabela
    {
        protected TabelaMap(EntityTypeBuilder<T> entidade) : base(entidade)
        {
            entidade.Property(t => t.Codigo);
            entidade.Property(t => t.Descricao);
        }
    }
}
