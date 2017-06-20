using Biblioteca.Entidades.Catalogacao;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Entidades.EFMapping.Classificacao
{
    public class CutterMap : BaseMap<Cutter>
    {
        public CutterMap(EntityTypeBuilder<Cutter> entidade) : base(entidade)
        {
        }
    }
}
