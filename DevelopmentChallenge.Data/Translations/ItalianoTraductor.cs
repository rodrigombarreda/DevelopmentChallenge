namespace DevelopmentChallenge.Data.Classes
{
    public class ItalianoTraductor : IIdiomaTraductor
    {
        public string EncabezadoReporte() => "<h1>Rapporto sulle forme</h1>";
        public string ListaVacia()         => "<h1>Lista vuota di forme!</h1>";
        public string EtiquetaPerimetro()  => "Perimetro";
        public string EtiquetaFormas(int cantidad) => cantidad == 1 ? "forma" : "forme";
    }
}
