using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class CastellanoTraductor : IIdiomaTraductor
    {
        private static readonly Dictionary<string, (string singular, string plural)> _nombres =
            new Dictionary<string, (string, string)>
            {
                { "Cuadrado",             ("Cuadrado",             "Cuadrados")  },
                { "Circulo",              ("Círculo",              "Círculos")   },
                { "Triangulo Equilatero", ("Triángulo",            "Triángulos") },
                { "Trapecio",             ("Trapecio",             "Trapecios")  },
            };

        public string EncabezadoReporte() => "<h1>Reporte de Formas</h1>";
        public string ListaVacia() => "<h1>Lista vacía de formas!</h1>";
        public string EtiquetaPerimetro() => "Perimetro";
        public string EtiquetaFormas() => "formas";

        public string NombreForma(string nombre, int cantidad)
        {
            var (singular, plural) = _nombres[nombre];
            return cantidad == 1 ? singular : plural;
        }
    }
}
