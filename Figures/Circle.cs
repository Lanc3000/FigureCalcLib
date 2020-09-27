using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalcLib.Figures
{
    class Circle: Figure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        internal override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
