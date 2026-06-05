using System;
using System.Collections.Generic;
using System.Linq;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica : IFormaGeometrica
    {
        #region Formas

        public const int Cuadrado = 1;
        public const int TrianguloEquilatero = 2;
        public const int Circulo = 3;
        public const int Trapecio = 4;

        #endregion

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Italiano = 3;

        #endregion

        private readonly decimal _lado;

        public int Tipo { get; set; }

        public string Nombre
        {
            get
            {
                switch (Tipo)
                {
                    case Cuadrado:            return "Cuadrado";
                    case Circulo:             return "Circulo";
                    case TrianguloEquilatero: return "Triangulo Equilatero";
                    case Trapecio:            return "Trapecio";
                    default: throw new ArgumentOutOfRangeException("Tipo de forma desconocido");
                }
            }
        }

        public FormaGeometrica(int tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var traductor = TraductorFactory.Crear(idioma);
            var servicio = new ReporteGeometrico(traductor);
            return servicio.Imprimir(formas.Cast<IFormaGeometrica>().ToList());
        }

        public decimal CalcularArea()
        {
            switch (Tipo)
            {
                case Cuadrado:            return _lado * _lado;
                case Circulo:             return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
                case TrianguloEquilatero: return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
                default: throw new ArgumentOutOfRangeException("Forma desconocida");
            }
        }

        public decimal CalcularPerimetro()
        {
            switch (Tipo)
            {
                case Cuadrado:            return _lado * 4;
                case Circulo:             return (decimal)Math.PI * _lado;
                case TrianguloEquilatero: return _lado * 3;
                default: throw new ArgumentOutOfRangeException("Forma desconocida");
            }
        }
    }
}
