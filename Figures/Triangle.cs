using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalcLib.Figures
{
    public class Triangle: Figure
    {
        private readonly double firstSide;
        private readonly double secondSide;
        private readonly double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        internal override double CalculateArea()
        {
            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide)
                                           * (halfPerimeter - secondSide)
                                           * (halfPerimeter - thirdSide));
        }

        public bool isRightTriangle(Triangle triangle) {
            if (triangle.maxSide() != 0)
            {
                if (triangle.maxSide() == triangle.firstSide &
                                    isSquareEqualsSides(triangle.firstSide, triangle.secondSide, triangle.thirdSide))
                    return true;
                else if (triangle.maxSide() == triangle.secondSide &
                                    isSquareEqualsSides(triangle.secondSide, triangle.firstSide, triangle.thirdSide))
                    return true;
                else if (triangle.maxSide() == triangle.thirdSide &
                                    isSquareEqualsSides(triangle.thirdSide, triangle.firstSide, triangle.secondSide))
                    return true;
                else
                    return false;
            }
            else 
                return false;
        }
        public double maxSide() {
            double max;
            if (firstSide > secondSide & firstSide > secondSide)
                max = firstSide;
            else if (secondSide > thirdSide & secondSide > firstSide)
                max = secondSide;
            else if (thirdSide > firstSide & thirdSide > secondSide)
                max = thirdSide;
            else
                max = 0;
            return max;
        }
        public bool isPositiveSides(Triangle triangle) {
            if(triangle.firstSide != 0 & triangle.secondSide != 0 & triangle.thirdSide != 0)
                return true;
            return false;
        }

        public bool isSquareEqualsSides(double hyp, double a, double b) {
            double hypSquare = Math.Pow(hyp, 2);
            double twoSidesSumSquare = Math.Pow(a, 2) + Math.Pow(b, 2);
            if (hypSquare == twoSidesSumSquare)
                return true;
            else
                return false;
        }
    }
}
