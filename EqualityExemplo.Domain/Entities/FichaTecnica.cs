using EqualityExemplo.Domain.Interfaces;

namespace EqualityExemplo.Domain.Entities
{
    public class FichaTecnica : ICaracteritica
    {
        public List<Caracteristica> Caracteristicas { get; set; } = [];
    }
}