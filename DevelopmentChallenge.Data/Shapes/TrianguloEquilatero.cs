using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal _lado;
        public string Nombre => "Triangulo Equilatero";

        public TrianguloEquilatero(decimal lado) { _lado = lado; }

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        public decimal CalcularPerimetro() => _lado * 3;
    }
}
