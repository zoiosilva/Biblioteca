using Biblioteca.Entidades.Catalogacao;

namespace Biblioteca.Entidades
{
    public class Autor : EntidadeBase
    {
        public string Sobrenome { get; set; }
        public string Nome { get; set; }
        public string NomeCompleto
        {
            get
            {
                return string.Concat(Nome, ' ', Sobrenome);
            }
        }
        public Pha Pha { get; set; }
        public Cutter Cutter { get; set; }
    }
}
