using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursProject
{
    public class Circle : Figure
    {
        public double R { get; set; }
        public Circle(double r)
        {
            R = r;
        }
        public override double H()
        {
            return Math.PI*Math.Pow(R,2);
        }
    }
}
