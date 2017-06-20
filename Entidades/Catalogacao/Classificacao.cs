namespace Biblioteca.Entidades.Catalogacao
{

    public abstract class Classificacao<T> : Tabela where T : class
    {
        public T Grupo { get; set; }
    }
}
