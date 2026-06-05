using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _radio;
        public override string Nombre => "Circulo";

        public Circulo(decimal radio)
        {
            ValidarMedida(radio, nameof(radio));
            _radio = radio;
        }

        public override decimal CalcularArea() => (decimal)Math.PI * _radio * _radio;
        public override decimal CalcularPerimetro() => 2 * (decimal)Math.PI * _radio;

        public override string TraducirNombre(Idioma idioma, int cantidad)
        {
            switch (idioma)
            {
                case Idioma.Castellano: return cantidad == 1 ? "Círculo"   : "Círculos";
                case Idioma.Ingles:     return cantidad == 1 ? "Circle"    : "Circles";
                case Idioma.Italiano:   return cantidad == 1 ? "Cerchio"   : "Cerchi";
                default:                return Nombre;
            }
        }
    }
}
