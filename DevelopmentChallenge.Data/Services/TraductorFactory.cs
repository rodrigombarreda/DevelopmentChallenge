using System;

namespace DevelopmentChallenge.Data.Classes
{
    public static class TraductorFactory
    {
        public static IIdiomaTraductor Crear(int idioma)
        {
            switch (idioma)
            {
                case FormaGeometrica.Castellano: return new CastellanoTraductor();
                case FormaGeometrica.Ingles:     return new InglesTraductor();
                case FormaGeometrica.Italiano:   return new ItalianoTraductor();
                default: throw new ArgumentOutOfRangeException(nameof(idioma), "Idioma no soportado");
            }
        }
    }
}
