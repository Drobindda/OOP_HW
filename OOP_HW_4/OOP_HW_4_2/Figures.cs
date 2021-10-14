using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_HW_4_2
{
    abstract class Figure
    {

        private double perimetr;
        private double square;
        public double Perimetr { get { return perimetr; } }
        public double Square { get { return square; } }

        protected abstract double CalculatePerimetr();
        protected abstract double CalculateSquare();

        protected void Initialization()
        {
            perimetr = CalculatePerimetr();
            square = CalculateSquare();
        }
    }
    class Triangle : Figure
    {
        public Triangle(double _side1, double _side2, double _side3)
        {
            bool existance = CheckExistance(_side1, _side2, _side3);
            if (existance)
            {
                side1 = _side1;
                side2 = _side2;
                side3 = _side3;
                Initialization();
            }
            else
            {
                throw new Exception();
            }
        }
    
        private double side1;
        private double side2;
        private double side3;
        protected override double CalculatePerimetr()
        {
            return side1 + side2 + side3;
        }
        protected override double CalculateSquare()
        {
            double p = Perimetr / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        protected static bool CheckExistance(double AB, double BC, double CA) // returns true if triangle with sides AB, BC, CA can be created, else returns false
        {
            if (AB > 0 && BC > 0 && CA > 0 && AB < BC + CA && BC < AB + CA && CA < AB + BC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Circle : Figure
    {
        public Circle(double _radius)
        {
            radius = _radius;
            Initialization();
        }

        private double radius;

        protected override double CalculatePerimetr()
        {
            return 2 * Math.PI * radius;
        }
        protected override double CalculateSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(double _side1, double _side2)
        {
            side1 = _side1;
            side2 = _side2;
            Initialization();
        }
        private double side1;
        private double side2;

        protected override double CalculatePerimetr()
        {
            return 2 * side1 + 2 * side2;
        }
        protected override double CalculateSquare()
        {
            return side1 * side2;
        }
    }
    class Square : Figure
    {
        public Square(double _side)
        {
            side = _side;
            Initialization();
        }
        private double side;

        protected override double CalculatePerimetr()
        {
            return 4 * side;
        }
        protected override double CalculateSquare()
        {
            return Math.Pow(side, 2);
        }
    }
    class Rhombus : Figure
    {
        public Rhombus(double _diagonal1, double _diagonal2)
        {
            diagonal1 = _diagonal1;
            diagonal2 = _diagonal2;
            Initialization();
        }
        private double diagonal1;
        private double diagonal2;

        protected override double CalculatePerimetr()
        {
            return 2 * Math.Sqrt(Math.Pow(diagonal1, 2) + Math.Pow(diagonal2, 2));
        }
        protected override double CalculateSquare()
        {
            return (diagonal1 * diagonal2) / 2;
        }
    }
}
