using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    public class Esfera : FiguraTridimensional
    {
        public Esfera (double radio) 
            : base(radio)
        {
        }

        public override double CalcularArea()
        {
            return 4 * Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularVolumen()
        {
          return 4/3 * Math.PI * Math.Pow(radio,3);
        }
    }
    }
}
