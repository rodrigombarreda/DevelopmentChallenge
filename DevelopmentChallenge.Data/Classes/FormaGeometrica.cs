using System;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase base abstracta para todas las formas geométricas.
    /// Implementa <see cref="IFormaGeometrica"/> 
    /// </summary>
    public abstract class FormaGeometrica : IFormaGeometrica
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string Nombre { get; }
        public abstract string TraducirNombre(Idioma idioma, int cantidad);

        /// <summary>
        /// Valida que una medida sea positiva.
        /// </summary>
        protected static void ValidarMedida(decimal medida, string parametro)
        {
            if (medida <= 0)
                throw new ArgumentOutOfRangeException(parametro, "La medida debe ser mayor que cero.");
        }
    }
}
