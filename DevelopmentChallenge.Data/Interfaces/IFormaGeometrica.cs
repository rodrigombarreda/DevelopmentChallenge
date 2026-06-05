namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Contrato para cualquier forma geométrica.
    /// Cada implementación es responsable de sus cálculos Y de su propia traducción,
    /// de modo que agregar una nueva forma no requiere modificar ninguna clase existente.
    /// </summary>
    public interface IFormaGeometrica
    {
        /// <summary>Calcula el área de la forma.</summary>
        decimal CalcularArea();

        /// <summary>Calcula el perímetro de la forma.</summary>
        decimal CalcularPerimetro();

        /// <summary>Nombre canónico interno de la forma (usado para agrupar en el reporte).</summary>
        string Nombre { get; }

        /// <summary>
        /// Retorna el nombre de la forma traducido al <paramref name="idioma"/> dado,
        /// en singular o plural según <paramref name="cantidad"/>.
        /// </summary>
        string TraducirNombre(Idioma idioma, int cantidad);
    }
}
