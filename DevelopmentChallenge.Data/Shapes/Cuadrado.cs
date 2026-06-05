namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal _lado;
        public string Nombre => "Cuadrado";

        public Cuadrado(decimal lado) { _lado = lado; }

        public decimal CalcularArea() => _lado * _lado;
        public decimal CalcularPerimetro() => _lado * 4;
    }
}
