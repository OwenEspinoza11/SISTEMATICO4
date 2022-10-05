using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    public class Cubo : FiguraTridimensional
    {
        public Cubo(double lado) 
            : base(lado)
        {
        }

        public override double CalcularArea()
        {
            return 6 * Math.Pow(Lado, 2);
        }

        public override double CalcularVolumen()
        {
          return Math.Pow(Lado , 3);
        }




    }
}
