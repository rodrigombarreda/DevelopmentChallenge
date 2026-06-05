namespace DevelopmentChallenge.Data.Classes
{
    public class CastellanoTraductor : IIdiomaTraductor
    {
        public string EncabezadoReporte() => "<h1>Reporte de Formas</h1>";
        public string ListaVacia()         => "<h1>Lista vacía de formas!</h1>";
        public string EtiquetaPerimetro()  => "Perimetro";
        public string EtiquetaFormas(int cantidad) => cantidad == 1 ? "forma" : "formas";
    }
}
