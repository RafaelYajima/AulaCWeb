using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPApp_aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string retorno = TestaPoint(); 
            Console.WriteLine(retorno);
        }

        public string TestaPoint()
        {
            Point p;
            p.x = 10;
            p.y = 20;
            //Console.WriteLine(p);
            return p.ToString();
        }
    }
}
