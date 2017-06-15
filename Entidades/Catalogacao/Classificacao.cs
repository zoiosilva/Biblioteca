namespace Biblioteca.Entidades.Catalogacao
{
    public abstract class Classificacao
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }

    public abstract class Classificacao<T> : Classificacao
    {
        public T Grupo { get; set; }
    }
}
