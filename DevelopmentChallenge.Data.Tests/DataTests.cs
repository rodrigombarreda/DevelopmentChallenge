using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        // ── Lista vacía ─────────────────────────────────────────────────────

        [TestCase]
        public void TestListaVacia_Castellano()
        {
            var reporte = ReporteGeometrico.Para(Idioma.Castellano);
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", reporte.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestListaVacia_Ingles()
        {
            var reporte = ReporteGeometrico.Para(Idioma.Ingles);
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", reporte.Imprimir(new List<IFormaGeometrica>()));
        }

        [TestCase]
        public void TestListaVacia_Italiano()
        {
            var reporte = ReporteGeometrico.Para(Idioma.Italiano);
            Assert.AreEqual("<h1>Lista vuota di forme!</h1>", reporte.Imprimir(new List<IFormaGeometrica>()));
        }

        // ── Un solo tipo de forma ───────────────────────────────────────────

        [TestCase]
        public void TestUnCuadrado_Castellano()
        {
            var formas = new List<IFormaGeometrica> { new Cuadrado(5) };
            var reporte = ReporteGeometrico.Para(Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25",
                reporte.Imprimir(formas));
        }

        [TestCase]
        public void TestTresCuadrados_Ingles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            var reporte = ReporteGeometrico.Para(Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35",
                reporte.Imprimir(formas));
        }

        // ── Tipos mixtos ────────────────────────────────────────────────────

        [TestCase]
        public void TestMixFormas_Ingles()
        {
            // Circulo recibe radio: 1.5 equivale al diámetro=3 del test original
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(1.375m),
                new TrianguloEquilatero(4.2m)
            };
            var reporte = ReporteGeometrico.Para(Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                reporte.Imprimir(formas));
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(1.375m),
                new TrianguloEquilatero(4.2m)
            };
            var reporte = ReporteGeometrico.Para(Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                reporte.Imprimir(formas));
        }

        // ── Italiano ────────────────────────────────────────────────────────

        [TestCase]
        public void TestUnCuadrado_Italiano()
        {
            var formas = new List<IFormaGeometrica> { new Cuadrado(5) };
            var reporte = ReporteGeometrico.Para(Idioma.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25",
                reporte.Imprimir(formas));
        }

        [TestCase]
        public void TestResumenMasTiposEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(2),
                new Circulo(1.5m),
                new TrianguloEquilatero(4)
            };
            var reporte = ReporteGeometrico.Para(Idioma.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>1 Cerchio | Area 7,07 | Perimetro 9,42 <br/>1 Triangolo | Area 6,93 | Perimetro 12 <br/>TOTAL:<br/>4 forme Perimetro 49,42 Area 43",
                reporte.Imprimir(formas));
        }

        // ── Trapecio ────────────────────────────────────────────────────────

        [TestCase]
        public void TestResumenUnTrapecioEnCastellano()
        {
            // Area = (6+4)/2 * 3 = 15 | Perimetro = 6+4+5+5 = 20
            var formas = new List<IFormaGeometrica> { new Trapecio(6m, 4m, 3m, 5m, 5m) };
            var reporte = ReporteGeometrico.Para(Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>1 Trapecio | Area 15 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 15",
                reporte.Imprimir(formas));
        }

        [TestCase]
        public void TestResumenDosTrapeciosEnIngles()
        {
            // Area total = 30 | Perimetro total = 40
            var formas = new List<IFormaGeometrica>
            {
                new Trapecio(6m, 4m, 3m, 5m, 5m),
                new Trapecio(6m, 4m, 3m, 5m, 5m)
            };
            var reporte = ReporteGeometrico.Para(Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Trapezoids | Area 30 | Perimeter 40 <br/>TOTAL:<br/>2 shapes Perimeter 40 Area 30",
                reporte.Imprimir(formas));
        }

    }
}
