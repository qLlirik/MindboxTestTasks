using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Area of triangle.
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            var perimeter = a + b + c;
            var halfOfPeriment = perimeter / 2;
            return Math.Sqrt(halfOfPeriment * (halfOfPeriment - a) * (halfOfPeriment - b) * (halfOfPeriment - c));
        }
    }
}
