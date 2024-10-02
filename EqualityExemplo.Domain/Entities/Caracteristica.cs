namespace EqualityExemplo.Domain.Entities
{
    public class Caracteristica(Guid id, string valor)
    {
        public Guid Id { get; set; } = id;
        public string Valor { get; set; } = valor;
    }
}