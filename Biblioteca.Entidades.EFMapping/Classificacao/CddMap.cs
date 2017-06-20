using Biblioteca.Entidades.Catalogacao;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Entidades.EFMapping.Classificacao
{
    public class CddMap : ClassificacaoMap<Cdd>
    {
        public CddMap(EntityTypeBuilder<Cdd> entidade) : base(entidade)
        {
        }
    }
}
