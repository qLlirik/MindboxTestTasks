using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Figure //Example of comment from task - Легкость добавления других фигур
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Area()
        {
            return a * b;
        }
    }
}
