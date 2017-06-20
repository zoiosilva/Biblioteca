using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Entidades.EFMapping
{
    public abstract class BaseMap<T> where T : EntidadeBase
    {
        protected BaseMap(EntityTypeBuilder<T> entidade)
        {
            entidade.HasKey(t => t.Id);
            entidade.Property(t => t.DataInclusao); //TODO: Default value generator.
            entidade.Property(t => t.DataModificacao);
        }
    }
}
