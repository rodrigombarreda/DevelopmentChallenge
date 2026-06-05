using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class ItalianoTraductor : IIdiomaTraductor
    {
        private static readonly Dictionary<string, (string singular, string plural)> _nombres =
            new Dictionary<string, (string, string)>
            {
                { "Cuadrado",             ("Quadrato",          "Quadrati")  },
                { "Circulo",              ("Cerchio",           "Cerchi")    },
                { "Triangulo Equilatero", ("Triangolo",         "Triangoli") },
                { "Trapecio",             ("Trapezio",          "Trapezi")   },
            };

        public string EncabezadoReporte() => "<h1>Rapporto sulle forme</h1>";
        public string ListaVacia() => "<h1>Lista vuota di forme!</h1>";
        public string EtiquetaPerimetro() => "Perimetro";
        public string EtiquetaFormas() => "forme";

        public string NombreForma(string nombre, int cantidad)
        {
            var (singular, plural) = _nombres[nombre];
            return cantidad == 1 ? singular : plural;
        }
    }
}
