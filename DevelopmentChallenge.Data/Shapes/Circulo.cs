using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _radio;
        public string Nombre => "Circulo";

        public Circulo(decimal radio) { _radio = radio; }

        public decimal CalcularArea() => (decimal)Math.PI * _radio * _radio;
        public decimal CalcularPerimetro() => 2 * (decimal)Math.PI * _radio;
    }
}
