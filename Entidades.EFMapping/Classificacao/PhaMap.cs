using Biblioteca.Entidades.Catalogacao;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Entidades.EFMapping.Classificacao
{
    public class PhaMap : BaseMap<Pha>
    {
        public PhaMap(EntityTypeBuilder<Pha> entidade) : base(entidade)
        {
        }
    }
}
