using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsInterfaceOOP
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;
        public int alpha;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double H)
        {
            a = A;
            h = H;
        }
        public Triangle(double A, double B, int An)
        {
            a = A;
            b = B;
            alpha = An;
        }
        public Triangle()
        {
            a = 3;
            b = 4;
            c = 5;
        }

        public string output(double a)
        {
            return Convert.ToString(a);
        }
        public double Perimeter()
        {
            return (a + b + c);
        }
        public double Surface()
        {
            double p = Perimeter()/2;
            return  Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }
        public double Surface_H()
        {
            return (a * h) / 2;
        }
        public double Surface_Sin()
        {
            return (a * b * Math.Sin(alpha)) / 2;
        }
        public double Pifa(double a, double b)
        {
            return Math.Round(Math.Sqrt(a*a+b*b));
        }
        public double GetSetA
        {
            get{return a;}
            set{a = value;}
        }
        public double GetSetB
        {
            get{return b;}
            set{b = value;}
        }
        public double GetSetC
        {
            get{return c;}
            set{c = value;}
           
        }
        public bool ExistTriange
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))  return true;
                else return false;
            }
        }
        public bool EqualTriangle
        {
            get
            {
                if ((a == b || c == a || c == b) && a + b + c != 0) return true;
                else return false;
            }
        }
    }
}
