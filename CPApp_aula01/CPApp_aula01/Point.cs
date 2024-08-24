using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPApp_aula01
{
    struct Point
    {
        public double x, y;
        /*
        public override string ToString()
        {
            return base.ToString();
        }
        */

       
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
        
    }
}
