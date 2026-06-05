namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Contrato para cualquier forma geométrica.
    /// Cada implementación es responsable de sus cálculos Y de su propia traducción,
    /// de modo que agregar una nueva forma no requiere modificar ninguna clase existente.
    /// </summary>
    public interface IFormaGeometrica
    {
        decimal CalcularArea();

        decimal CalcularPerimetro();

        string Nombre { get; }

        string TraducirNombre(Idioma idioma, int cantidad);
    }
}
