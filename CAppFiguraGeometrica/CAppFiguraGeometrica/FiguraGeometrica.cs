namespace CAppFiguraGeometrica_Entity
{
    public class FiguraGeometrica
    {
        private double vlBase;
        public double Altura { get; set; }
        //public double Altura { get; private set; }  // Alteravel apenas na classe
        private double areaTriangulo;
        private double areaRetangulo;

        public double VlBase 
        {
            get {  return vlBase; }
            set { vlBase = value; }
        }

        public FiguraGeometrica() { }

        public FiguraGeometrica(double altura, double vlBase)
        {
            Altura = altura;
            VlBase = vlBase;
        }



        /*
        public void SetAltura(double altura)
        {
            this.vlAltura = altura;   
        }

        public double GetAltura() 
        { 
            return this.vlAltura; 
        }
        */

        public double GetAreaTriangulo()
        {
            return (double)this.areaTriangulo;
        }
        public double GetAreaRetangulo()
        {
            return (double)this.areaRetangulo;
        }

        public void CalculaAreaTriangulo()
        {
            this.areaTriangulo = ((this.vlBase * this.Altura) / 2);
        }
        public void CalculaAreaRetangulo()
        {
            this.areaRetangulo = ((this.vlBase * this.Altura));
        }
    }
}
