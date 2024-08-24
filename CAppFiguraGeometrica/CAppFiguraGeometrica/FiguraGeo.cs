namespace CAppFiguraGeo 
{ 
    public class FiguraGeo
    {
        protected double vlBase;
        public double Altura { get; set; }
        public double Area { get; protected set; }


        public double VlBase
        {
            get { return vlBase; }
            set { vlBase = value; }
        }

        public FiguraGeo() { }

        public FiguraGeo(double altura, double vlBase)
        {
            Altura = altura;
            VlBase = vlBase;
        }
    }
}
