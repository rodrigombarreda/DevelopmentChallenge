using System;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// se recibe un idioma y se devuelve el traductor correspondiente. Agregar un nuevo idioma implica:
    /// 1) Implementar un nuevo <see cref="IIdiomaTraductor"/> para el idioma.
    /// 2) Agregar un nuevo valor a <see cref="Idioma"/>.
    /// 3) Agregar un nuevo caso al switch de <see cref="Crear"/>.
    /// </summary>
    public static class TraductorFactory
    {
        public static IIdiomaTraductor Crear(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano: return new CastellanoTraductor();
                case Idioma.Ingles: return new InglesTraductor();
                case Idioma.Italiano: return new ItalianoTraductor();
                default: throw new ArgumentOutOfRangeException(nameof(idioma), $"Idioma no soportado: {idioma}");
            }
        }
    }
}
