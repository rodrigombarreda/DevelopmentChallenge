using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        // ── Tests originales ────────────────────────────────────────────────

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), FormaGeometrica.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), FormaGeometrica.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 1),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
                new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        // ── Tests nuevos: Italiano ──────────────────────────────────────────

        [TestCase]
        public void TestResumenListaVaciaEnItaliano()
        {
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), FormaGeometrica.Italiano));
        }

        [TestCase]
        public void TestResumenUnCuadradoEnItaliano()
        {
            var formas = new List<FormaGeometrica> { new FormaGeometrica(FormaGeometrica.Cuadrado, 5) };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);

            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forme Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
            };

            var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>1 Cerchio | Area 7,07 | Perimetro 9,42 <br/>1 Triangolo | Area 6,93 | Perimetro 12 <br/>TOTAL:<br/>4 forme Perimetro 49,42 Area 43",
                resumen);
        }

        // ── Tests nuevos: Trapecio ──────────────────────────────────────────

        [TestCase]
        public void TestResumenUnTrapecioEnCastellano()
        {
            // baseMayor=6, baseMenor=4, altura=3, ladoIzq=5, ladoDer=5
            // Area = (6+4)/2 * 3 = 15 | Perimetro = 6+4+5+5 = 20
            var formas = new List<IFormaGeometrica> { new Trapecio(6m, 4m, 3m, 5m, 5m) };
            var servicio = new ReporteGeometrico(new CastellanoTraductor());

            var resumen = servicio.Imprimir(formas);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 15 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 15", resumen);
        }

        [TestCase]
        public void TestResumenDosTrapeciosEnIngles()
        {
            // 2x (baseMayor=6, baseMenor=4, altura=3, lados=5,5)
            // Area total = 30 | Perimetro total = 40
            var formas = new List<IFormaGeometrica>
            {
                new Trapecio(6m, 4m, 3m, 5m, 5m),
                new Trapecio(6m, 4m, 3m, 5m, 5m)
            };
            var servicio = new ReporteGeometrico(new InglesTraductor());

            var resumen = servicio.Imprimir(formas);

            Assert.AreEqual("<h1>Shapes report</h1>2 Trapezoids | Area 30 | Perimeter 40 <br/>TOTAL:<br/>2 shapes Perimeter 40 Area 30", resumen);
        }
    }
}
