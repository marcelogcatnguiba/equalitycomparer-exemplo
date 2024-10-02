using EqualityExemplo.Domain.Interfaces;

namespace EqualityExemplo.Domain.Entities
{
    public class Maquina : ICaracteritica
    {
        public List<Caracteristica> Caracteristicas { get; set; } = [];
    }
}