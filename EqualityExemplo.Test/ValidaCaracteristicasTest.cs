using EqualityExemplo.Domain.Entities;
using EqualityExemplo.Domain.Implementation;
using EqualityExemplo.Domain.Interfaces;
using FluentAssertions;

namespace EqualityExemplo.Test
{
    public class ValidaCaracteristicasTest
    {
        private readonly Validador _validador = new();

        [Fact]
        public void DeveRetornarTrue_UmaCaracteristica_Igual()
        {
            Guid caracteristicaId = Guid.NewGuid();

            ICaracteritica objA = new Maquina()
            {
                Caracteristicas = 
                [
                    new(caracteristicaId, "1")
                ]
            };
            
            ICaracteritica objB = new FichaTecnica()
            {
                Caracteristicas = 
                [
                    new(caracteristicaId, "1")
                ]
            };
        
            var result = _validador.VerificarCompatibilidade(objA, objB);

            result.Should().BeTrue();
        }
        
        [Fact]
        public void DeveRetornarFalse_UmaCaracteristica_Diferente()
        {
            Guid caracteristicaId = Guid.NewGuid();

            ICaracteritica objA = new Maquina()
            {
                Caracteristicas = 
                [
                    new(caracteristicaId, "1")
                ]
            };
            
            ICaracteritica objB = new FichaTecnica()
            {
                Caracteristicas = 
                [
                    new(caracteristicaId, "2")
                ]
            };
        
            var result = _validador.VerificarCompatibilidade(objA, objB);

            result.Should().BeFalse();
        }
        
        [Fact]
        public void DeveRetornarTrue_DuasCaracteristica_Igual()
        {
            Guid caracteristicaId = Guid.NewGuid();

            ICaracteritica objA = new Maquina()
            {
                Caracteristicas = 
                [
                    new(caracteristicaId, "1"),
                    new(caracteristicaId, "2")
                ]
            };
            
            ICaracteritica objB = new FichaTecnica()
            {
                Caracteristicas = 
                [
                    new(caracteristicaId, "1")
                ]
            };

            var result = _validador.VerificarCompatibilidade(objA, objB);

            result.Should().BeTrue();
        }
    }
}