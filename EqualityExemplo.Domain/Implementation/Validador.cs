using EqualityExemplo.Domain.Comparer;
using EqualityExemplo.Domain.Interfaces;

namespace EqualityExemplo.Domain.Implementation
{
    public class Validador : IValidaCaracteristicas
    {
        public bool VerificarCompatibilidade(ICaracteritica objA, ICaracteritica objB)
        {
            // var dict = new Dictionary<Guid, bool>();

            // foreach(var fc in objA.Caracteristicas)
            // {
            //     foreach(var mc in objB.Caracteristicas)
            //     {
            //         if(fc.Id.Equals(mc.Id))
            //         {
            //             if(fc.Valor.Equals(mc.Valor))
            //             {
            //                 dict.Add(fc.Id, true);
            //                 continue;
            //             }

            //             dict.Add(fc.Id, false);
            //             break;
            //         }
            //     }
            // }

            // if(dict.Count > 0)
            // {
            //     return !dict.Values.Any(x => x.Equals(false));
            // }
            
            // return false;

            var result = objA.Caracteristicas.Intersect(objB.Caracteristicas, new ComparerCaracteristicas());
            return result.ToList().Count > 0;
        }
    }
}
