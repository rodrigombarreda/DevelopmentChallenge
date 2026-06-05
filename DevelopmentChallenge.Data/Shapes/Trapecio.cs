namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _baseMayor, _baseMenor, _altura, _ladoIzquierdo, _ladoDerecho;
        public string Nombre => "Trapecio";

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _ladoIzquierdo = ladoIzquierdo;
            _ladoDerecho = ladoDerecho;
        }

        public decimal CalcularArea() => (_baseMayor + _baseMenor) / 2 * _altura;
        public decimal CalcularPerimetro() => _baseMayor + _baseMenor + _ladoIzquierdo + _ladoDerecho;
    }
}
