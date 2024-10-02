using System.Diagnostics.CodeAnalysis;
using EqualityExemplo.Domain.Entities;

namespace EqualityExemplo.Domain.Comparer
{
    public class ComparerCaracteristicas : IEqualityComparer<Caracteristica>
    {
        public bool Equals(Caracteristica? x, Caracteristica? y)
        {
            return x!.Id.Equals(y!.Id) && x.Valor.Equals(y.Valor);
        }

        public int GetHashCode([DisallowNull] Caracteristica obj)
        {
            var str = obj.Id.ToString() + obj.Valor.ToString();
            return str.GetHashCode();
        }
    }
}