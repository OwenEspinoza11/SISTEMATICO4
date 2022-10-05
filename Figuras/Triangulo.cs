using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    public class Triangulo : FiguraBidimensional
    {
        public Triangulo (double basee, double altura) : base(basee, altura)
        {
        }

        public override double CalcularPerimetro()
        {
            return basee + (2*altura);
        }

        public override double CalcularArea() 
        {
            return (basee* altura) /2;
        }
    }
}
