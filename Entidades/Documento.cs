using Biblioteca.Entidades.Catalogacao;

namespace Biblioteca.Entidades
{
    public class Documento
    {
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public Cdd Cdd { get; set; }
        public Cdu Cdu { get; set; }
    }
}
