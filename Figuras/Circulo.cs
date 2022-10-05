using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    public class Circulo : FiguraBidimensional
    {
        public Circulo(double radio) : base(radio)
        {
        }

        public override double CalcularArea() 
        {
            return Math.PI * (Math.Pow(radio, 2));
        }

        public override double CalcularPerimetro()
        {
            2 * Math.PI * radio;
        }
        
    }
    


}
