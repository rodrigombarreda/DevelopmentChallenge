using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReporteGeometrico
    {
        private readonly IIdiomaTraductor _traductor;

        public ReporteGeometrico(IIdiomaTraductor traductor)
        {
            _traductor = traductor;
        }

        public string Imprimir(List<IFormaGeometrica> formas)
        {
            if (!formas.Any())
                return _traductor.ListaVacia();

            var sb = new StringBuilder();
            sb.Append(_traductor.EncabezadoReporte());

            foreach (var grupo in formas.GroupBy(f => f.Nombre))
            {
                var cantidad = grupo.Count();
                var area = grupo.Sum(f => f.CalcularArea());
                var perimetro = grupo.Sum(f => f.CalcularPerimetro());
                sb.Append($"{cantidad} {_traductor.NombreForma(grupo.Key, cantidad)} | Area {area:#.##} | {_traductor.EtiquetaPerimetro()} {perimetro:#.##} <br/>");
            }

            sb.Append("TOTAL:<br/>");
            sb.Append($"{formas.Count} {_traductor.EtiquetaFormas()} ");
            sb.Append($"{_traductor.EtiquetaPerimetro()} {formas.Sum(f => f.CalcularPerimetro()):#.##} ");
            sb.Append($"Area {formas.Sum(f => f.CalcularArea()):#.##}");

            return sb.ToString();
        }
    }
}
