using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Triangle
    {
        public double a, b, c;
        public double PI = 22.0 / 7.0;

        public Triangle()
        {
        }
        public Triangle(double s1, double s2, double s3)
        {
            a = s1;
            b = s2;
            c = s3;
        }

        public double side1
        {
            get
            {
                return this.a;
            }

            set
            {
                this.a = value;
            }
        }

        public double side2
        {
            get
            {
                return this.b;
            }

            set
            {
                this.b = value;
            }
        }

        public double side3
        {
            get
            {
                return this.c;
            }

            set
            {
                this.c = value;
            }
        }

        public double areaOfTriangle()
        {
            double p = (a + b + c) / 2.0;
            return Math.Pow((p * (p - a) * (p - b) * (p - c)), (1.0 / 2.0));
        }
    }
}
