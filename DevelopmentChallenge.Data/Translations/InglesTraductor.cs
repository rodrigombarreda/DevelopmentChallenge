namespace DevelopmentChallenge.Data.Classes
{
    public class InglesTraductor : IIdiomaTraductor
    {
        public string EncabezadoReporte() => "<h1>Shapes report</h1>";
        public string ListaVacia()         => "<h1>Empty list of shapes!</h1>";
        public string EtiquetaPerimetro()  => "Perimeter";
        public string EtiquetaFormas(int cantidad) => cantidad == 1 ? "shape" : "shapes";
    }
}
