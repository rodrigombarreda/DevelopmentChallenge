namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Estrategia de traducción para los textos del reporte
    /// (encabezado, pie, etiquetas). La traducción de nombres de figuras
    /// es responsabilidad de cada <see cref="IFormaGeometrica"/>.
    /// Implementar esta interfaz para agregar soporte a un nuevo idioma.
    /// </summary>
    public interface IIdiomaTraductor
    {
        string EncabezadoReporte();

        string ListaVacia();

        string EtiquetaPerimetro();

        string EtiquetaFormas(int cantidad);
    }
}
