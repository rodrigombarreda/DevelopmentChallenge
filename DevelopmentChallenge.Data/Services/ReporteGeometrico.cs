using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Servicio que genera reportes HTML para una colección de formas geométricas.
    /// Recibe el <see cref="Idioma"/> y un <see cref="IIdiomaTraductor"/> por constructor.
    /// El idioma se pasa a cada forma para que traduzca su propio nombre (OCP: agregar
    /// una forma nueva no requiere tocar ningún traductor).
    /// </summary>
    public class ReporteGeometrico
    {
        private readonly Idioma _idioma;
        private readonly IIdiomaTraductor _traductor;

        public ReporteGeometrico(Idioma idioma, IIdiomaTraductor traductor)
        {
            _idioma    = idioma;
            _traductor = traductor ?? throw new ArgumentNullException(nameof(traductor));
        }

        /// <summary>
        /// Factory method de conveniencia: crea un <see cref="ReporteGeometrico"/>
        /// resolviendo el traductor adecuado a partir del <paramref name="idioma"/>.
        /// </summary>
        public static ReporteGeometrico Para(Idioma idioma) =>
            new ReporteGeometrico(idioma, TraductorFactory.Crear(idioma));

        public string Imprimir(List<IFormaGeometrica> formas)
        {
            if (!formas.Any())
                return _traductor.ListaVacia();

            var sb = new StringBuilder();
            sb.Append(_traductor.EncabezadoReporte());

            foreach (var grupo in formas.GroupBy(f => f.Nombre))
            {
                var cantidad  = grupo.Count();
                var forma     = grupo.First();
                var nombre    = forma.TraducirNombre(_idioma, cantidad);
                var area      = grupo.Sum(f => f.CalcularArea());
                var perimetro = grupo.Sum(f => f.CalcularPerimetro());

                sb.Append($"{cantidad} {nombre} | Area {area:#.##} | {_traductor.EtiquetaPerimetro()} {perimetro:#.##} <br/>");
            }

            var totalFormas    = formas.Count;
            var totalPerimetro = formas.Sum(f => f.CalcularPerimetro());
            var totalArea      = formas.Sum(f => f.CalcularArea());

            sb.Append("TOTAL:<br/>");
            sb.Append($"{totalFormas} {_traductor.EtiquetaFormas(totalFormas)} ");
            sb.Append($"{_traductor.EtiquetaPerimetro()} {totalPerimetro:#.##} ");
            sb.Append($"Area {totalArea:#.##}");

            return sb.ToString();
        }
    }
}
