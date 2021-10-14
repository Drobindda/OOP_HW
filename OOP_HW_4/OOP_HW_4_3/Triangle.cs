using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_HW_4_3
{
    abstract class Triangle
    {
        protected Triangle(double side1, double side2, double angle)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.angle = angle;
        }

        private double side1;
        private double side2;
        private double angle;

        protected double Side1 { get { return side1; } }
        protected double Side2 { get { return side2; } }
        protected double Angle { get { return (angle * Math.PI) / 180; } }

        public virtual double GetPerimetr()
        {
            return Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2) - (2 * Side1 * Side2 * Math.Cos(Angle))) + Side1 + Side2;
        }
        public virtual double GetSquare()
        {
            return Side1 * Side2 * Math.Sin(Angle) / 2;
        }

    }

    class RightTriangle : Triangle
    {
        public RightTriangle(double side1, double side2) : base(side1, side2, 90)
        {

        }
        public override double GetPerimetr()
        {
            return Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2)) + Side1 + Side2;
        }
        public override double GetSquare()
        {
            return Side1 * Side2 / 2;
        }
    }

    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double side, double angle) : base(side, side, angle)
        {

        }
        public override double GetPerimetr()
        {
            return Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2) - (2 * Side1 * Side2 * Math.Cos(Angle))) + Side1 + Side2;
        }
        public override double GetSquare()
        {
            return Side1 * Side2 * Math.Sin(Angle) / 2;
        }
    }
}
