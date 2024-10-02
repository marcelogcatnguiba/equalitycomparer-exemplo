namespace EqualityExemplo.Domain.Interfaces
{
    public interface IValidaCaracteristicas
    {
        bool VerificarCompatibilidade(ICaracteritica objA, ICaracteritica objB);
    }
}