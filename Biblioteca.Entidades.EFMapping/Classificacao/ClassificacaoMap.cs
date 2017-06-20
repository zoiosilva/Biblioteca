using Biblioteca.Entidades.Catalogacao;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Entidades.EFMapping.Classificacao
{
    public abstract class ClassificacaoMap<T> : BaseMap<T> where T : Classificacao<T>
    {
        public ClassificacaoMap(EntityTypeBuilder<T> entidade) : base(entidade)
        {
            entidade.Property(t => t.Codigo);
            entidade.Property(t => t.Descricao);
            entidade.HasOne(t => t.Grupo).WithMany().HasForeignKey(e => e.Id); //TODO: Revisar e fazer certo o carregamento de FKS recursivas.
        }
    }
}
