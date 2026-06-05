namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Estrategia de traducción para los textos ESTRUCTURALES del reporte
    /// (encabezado, pie, etiquetas). La traducción de nombres de figuras
    /// es responsabilidad de cada <see cref="IFormaGeometrica"/>.
    /// Implementar esta interfaz para agregar soporte a un nuevo idioma.
    /// </summary>
    public interface IIdiomaTraductor
    {
        /// <summary>Encabezado del reporte cuando hay formas.</summary>
        string EncabezadoReporte();

        /// <summary>Mensaje cuando la lista de formas está vacía.</summary>
        string ListaVacia();

        /// <summary>Etiqueta de perímetro (ej: "Perimetro", "Perimeter").</summary>
        string EtiquetaPerimetro();

        /// <summary>
        /// Etiqueta de formas en el pie del reporte, en singular o plural según <paramref name="cantidad"/>.
        /// </summary>
        string EtiquetaFormas(int cantidad);
    }
}
