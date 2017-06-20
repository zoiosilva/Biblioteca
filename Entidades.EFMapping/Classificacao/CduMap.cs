using Biblioteca.Entidades.Catalogacao;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Entidades.EFMapping.Classificacao
{
    public class CduMap : ClassificacaoMap<Cdu>
    {
        public CduMap(EntityTypeBuilder<Cdu> entidade) : base(entidade)
        {
        }
    }
}
