using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    public class Tetraedro : FiguraTridimensional
    {
        public Tetraedro (double lado) : base(lado)
        {
        }

        public override double CalcularArea()
        {
            return Math.Pow(Lado, 2) * Math.Sqrt(3);
        }

        public override double CalcularVolumen()
        {
          return (Math.Pow(Lado, 3)/12) * Math.Sqrt(2);
        }
    }
}
