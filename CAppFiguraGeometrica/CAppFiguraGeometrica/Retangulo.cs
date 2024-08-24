using CAppFiguraGeo;

namespace CAppFiguraGeometrica
{
    public class Retangulo : FiguraGeo
    {

        public Retangulo() { }  

        public void CalculaArea()
        {
            this.Area = ((this.vlBase * this.Altura));
        }
    }
}
