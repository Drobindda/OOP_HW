using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_HW_4_1
{
    public class Triangle
    {
        public Triangle(double AB, double BC, double CA)
        {
            bool existance = CheckExistance(AB, BC, CA);
            if (existance)
            {
                sideAB = AB;
                sideBC = BC;
                sideCA = CA;
                CalculateAngles();
            }
            else
            {
                throw new Exception();
            }
        }

        private double sideAB;
        private double sideBC;
        private double sideCA;

        public double SideAB 
        {
            get
            {
                return sideAB;
            }

            set
            {
                if (CheckExistance(value, SideBC, SideCA))
                {
                    sideAB = value;
                    CalculateAngles();
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public double SideBC
        {
            get
            {
                return sideBC;
            }

            set
            {
                if (CheckExistance(SideAB, value, SideCA))
                {
                    sideBC = value;
                    CalculateAngles();
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public double SideCA
        {
            get
            {
                return sideCA;
            }

            set
            {
                if (CheckExistance(SideAB, SideBC, value))
                {
                    sideCA = value;
                    CalculateAngles();
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private double angleAB_BC;
        private double angleBC_CA;
        private double angleCA_AB;

        public double AngleAB_BC { get { return angleAB_BC; } }
        public double AngleBC_CA { get { return angleBC_CA; } }
        public double AngleCA_AB { get { return angleCA_AB; } }

        public double Perimetr
        {
            get
            {
                return SideAB + SideBC + SideCA;
            }
        }

        private void CalculateAngles() // calculates angles of triangle by its sides
        {
            double cosAB_BC = (Math.Pow(SideAB, 2) + Math.Pow(SideBC, 2) - Math.Pow(SideCA, 2)) / (2 * SideAB * SideBC);
            angleAB_BC = (Math.Acos(cosAB_BC) / Math.PI) * 180;

            double cosBC_CA = (Math.Pow(SideBC, 2) + Math.Pow(SideCA, 2) - Math.Pow(SideAB, 2)) / (2 * SideBC * SideCA);
            angleBC_CA = ( Math.Acos(cosBC_CA) / Math.PI ) * 180;

            angleCA_AB = 180 - angleAB_BC - angleBC_CA;
        }
        
        protected static bool CheckExistance(double AB, double BC, double CA) // returns true if triangle with sides AB, BC, CA can be created, else returns false
        {
            if(AB > 0 && BC > 0 && CA > 0 && AB < BC+CA && BC < AB + CA && CA < AB + BC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class EquilateralTriangle : Triangle
    {

        public EquilateralTriangle(double side) : base(side, side, side)
        {
            CalculateSquare();
        }
        public EquilateralTriangle(double AB, double BC, double CA) : base(AB, BC, CA)
        {
            bool existance = CheckExistance(AB, BC, CA);
            if (existance)
            {
                CalculateSquare();
            }
            else
            {
                throw new Exception();
            }
        }

        private double square;
        public double Square { get { return square; } }

        public void CalculateSquare()
        {
            square = (Math.Pow(SideAB, 2) * Math.Sqrt(3)) / 4;
        }

        protected new static bool CheckExistance(double AB, double BC, double CA)
        {
            if(AB > 0 && AB == BC && BC == CA)
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
