using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigursProject
{
    public class Triagle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triagle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double H()
        {
            return (A + B + C) / 2;
        }
        public bool IsRegtangular()
        {
            if ((A * A) == (B * B) + (C * C) || (B * B) == (A * A) + (C * C) || (C * C) == (A * A) + (B * B))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
