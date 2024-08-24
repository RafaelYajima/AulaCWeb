using CAppFiguraGeometrica_Entity;
using CAppFiguraGeo;
using System;

namespace CAppFiguraGeometrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Teste FiguraGeometrica
             * 
            FiguraGeometrica figuraGm_01 = new FiguraGeometrica();
            figuraGm_01.VlBase = 10.0;
            //Console.WriteLine(figuraGm_01.VlBase);
            figuraGm_01.Altura = 35.5;
            figuraGm_01.CalculaAreaTriangulo();

            FiguraGeometrica figuraGm_02 = new FiguraGeometrica(10.5,56.0);
            //figuraGm_02.VlBase = 56.0;
            //figuraGm_02.Altura = 10.5;
            figuraGm_02.CalculaAreaRetangulo();

            Console.WriteLine("Área Triangulo = " + figuraGm_01.GetAreaTriangulo());
            Console.WriteLine("Área Retângulo = " + figuraGm_02.GetAreaRetangulo());
            */

            /* 
             * Teste FiguraGeo
             *
            */

            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 35;
            triangulo.VlBase = 10;
            triangulo.CalculaArea();
            Console.WriteLine(triangulo.Area);

            Retangulo retangulo = new Retangulo();
            retangulo.Altura = 35;
            retangulo.VlBase = 10;
            retangulo.CalculaArea();
            Console.WriteLine(retangulo.Area);

        }
    }
}
