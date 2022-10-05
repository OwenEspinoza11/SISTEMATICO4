using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    public abstract class Figuras
    {
        private double lado;
        private double radio;
        private double basee;
        private double altura;

        public Figuras(double lado, double radio, double basee, double altura)
        {
            this.lado = lado;
            this.radio = radio;
            this.basee = basee;
            this.altura = altura;
        }

        public double Lado
        {
            get { return lado; }

            set { lado = value; }
        }

        public double Radio
        {
            get { return radio; }
            set { lado = value; }
        }

        public double Basee
        {
            get { return basee; }
            set
            {
                basee = value;
            }
        }

        public double Altura
        {
            get { return altura; }
            set
            {
                altura = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\nnúmero de seguro social: {2}",
                lado, basee, altura, radio);
        }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public abstract double CalcularVolumen();


    }






}
