namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseMayor, _baseMenor, _altura, _ladoIzquierdo, _ladoDerecho;
        public override string Nombre => "Trapecio";

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho)
        {
            ValidarMedida(baseMayor,     nameof(baseMayor));
            ValidarMedida(baseMenor,     nameof(baseMenor));
            ValidarMedida(altura,        nameof(altura));
            ValidarMedida(ladoIzquierdo, nameof(ladoIzquierdo));
            ValidarMedida(ladoDerecho,   nameof(ladoDerecho));

            _baseMayor     = baseMayor;
            _baseMenor     = baseMenor;
            _altura        = altura;
            _ladoIzquierdo = ladoIzquierdo;
            _ladoDerecho   = ladoDerecho;
        }

        public override decimal CalcularArea() => (_baseMayor + _baseMenor) / 2 * _altura;
        public override decimal CalcularPerimetro() => _baseMayor + _baseMenor + _ladoIzquierdo + _ladoDerecho;

        public override string TraducirNombre(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano: return cantidad == 1 ? "Trapecio"   : "Trapecios";
                case Idioma.Ingles:     return cantidad == 1 ? "Trapezoid"  : "Trapezoids";
                case Idioma.Italiano:   return cantidad == 1 ? "Trapezio"   : "Trapezi";
                default:                return Nombre;
            }
        }
    }
}
