using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class InglesTraductor : IIdiomaTraductor
    {
        private static readonly Dictionary<string, (string singular, string plural)> _nombres =
            new Dictionary<string, (string, string)>
            {
                { "Cuadrado",             ("Square",            "Squares")   },
                { "Circulo",              ("Circle",            "Circles")   },
                { "Triangulo Equilatero", ("Triangle",          "Triangles") },
                { "Trapecio",             ("Trapezoid",         "Trapezoids") },
            };

        public string EncabezadoReporte() => "<h1>Shapes report</h1>";
        public string ListaVacia() => "<h1>Empty list of shapes!</h1>";
        public string EtiquetaPerimetro() => "Perimeter";
        public string EtiquetaFormas() => "shapes";

        public string NombreForma(string nombre, int cantidad)
        {
            var (singular, plural) = _nombres[nombre];
            return cantidad == 1 ? singular : plural;
        }
    }
}
