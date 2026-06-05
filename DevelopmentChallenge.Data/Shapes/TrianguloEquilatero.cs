using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;
        public override string Nombre => "Triangulo Equilatero";

        public TrianguloEquilatero(decimal lado)
        {
            ValidarMedida(lado, nameof(lado));
            _lado = lado;
        }

        public override decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 3;

        public override string TraducirNombre(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano: return cantidad == 1 ? "Triángulo"  : "Triángulos";
                case Idioma.Ingles:     return cantidad == 1 ? "Triangle"   : "Triangles";
                case Idioma.Italiano:   return cantidad == 1 ? "Triangolo"  : "Triangoli";
                default:                return Nombre;
            }
        }
    }
}
