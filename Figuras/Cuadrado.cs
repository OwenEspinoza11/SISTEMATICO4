using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    public class Cuadrado : FiguraBidimensional
    {
               public Cuadrado (double lado) 
            : base(lado)
        {
        }


        public override double CalcularPerimetro()
        {
            return Math.Pow(lado);
        }

        public override double CalcularArea() 
        {
            return 4* lado;
        }
    }
}
