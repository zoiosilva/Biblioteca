using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Entidades
{
    /*
     * Onde eu parei:
     * Eu ia fazer um codeGen para gerar as entidades estáticas da classe que herda do DbContext, pra não ter que que ficar digitando toda vez, ou usar reflection.
     * 
     * Eu acho que vou ter que fazer tudo nesta classe aqui, e não no infra. Não sei. Vou vendo conforme for digitando.
     * 
     */
    public class Documento
    {
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public Cdd Cdd { get; set; }
        public Cdu Cdu { get; set; }
    }

    public class Livro : Documento
    {
        public Autor Autor { get; set; }
    }

    public class Autor
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

    public abstract class Classificacao<T> : Classificacao
    {
        public T Grupo { get; set; }
    }

    public abstract class Classificacao
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }

    public class Cdd : Classificacao<Cdd>
    {
    }

    public class Cdu : Classificacao<Cdu>
    {
    }

    public class Pha : Classificacao
    {

    }

    public class Cutter : Classificacao
    {

    }
}
