using CAppFiguraGeo;

namespace CAppFiguraGeometrica
{
    public class Triangulo : FiguraGeo
    {
        public Triangulo() { }

        public void CalculaArea()
        {
            this.Area = ((this.vlBase * this.Altura) / 2);
        }
    }
}
