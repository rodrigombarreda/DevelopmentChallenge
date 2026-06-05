namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;
        public override string Nombre => "Cuadrado";

        public Cuadrado(decimal lado)
        {
            ValidarMedida(lado, nameof(lado));
            _lado = lado;
        }

        public override decimal CalcularArea() => _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 4;

        public override string TraducirNombre(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano: return cantidad == 1 ? "Cuadrado"  : "Cuadrados";
                case Idioma.Ingles:     return cantidad == 1 ? "Square"    : "Squares";
                case Idioma.Italiano:   return cantidad == 1 ? "Quadrato"  : "Quadrati";
                default:                return Nombre;
            }
        }
    }
}
