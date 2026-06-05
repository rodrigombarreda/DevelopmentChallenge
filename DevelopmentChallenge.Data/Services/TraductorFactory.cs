using System;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Fábrica que resuelve el <see cref="IIdiomaTraductor"/> concreto para un <see cref="Idioma"/>.
    /// Agregar soporte a un nuevo idioma requiere únicamente crear una nueva implementación de
    /// <see cref="IIdiomaTraductor"/> y registrarla aquí.
    /// </summary>
    public static class TraductorFactory
    {
        public static IIdiomaTraductor Crear(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano: return new CastellanoTraductor();
                case Idioma.Ingles:     return new InglesTraductor();
                case Idioma.Italiano:   return new ItalianoTraductor();
                default: throw new ArgumentOutOfRangeException(nameof(idioma), $"Idioma no soportado: {idioma}");
            }
        }
    }
}
