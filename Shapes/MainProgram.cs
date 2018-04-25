using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Area and Circumference of circle----------");
            MyDoubleCircle circle1 = new MyDoubleCircle();
            circle1.inputRadius();
            Console.WriteLine("AREA = {0:f2}",circle1.Area());
            Console.WriteLine("CIRCUMFERENCE = {0:f2}\n", circle1.Circumference());

            Console.WriteLine("--------Volume of Hemisphere----------");
            MyDoubleHemisphere hemisphere = new MyDoubleHemisphere();
            hemisphere.inputRadius();
            Console.WriteLine("VOLUME = {0:f2}\n", hemisphere.Volume());

            Console.WriteLine("--------Area of triangle given the length of the sides----------");
            MyIntTriangle triangle = new MyIntTriangle();
            triangle.inputSides();
            Console.WriteLine("AREA: {0:f2}.", triangle.Area());

            Console.WriteLine("--------Quadratic Equation----------");
            MyIntEquation equation1 = new MyIntEquation();
            equation1.myQuadraticEquation();
            double[] value = new double[2];
            value[0] = equation1.valueOfx1();
            value[1] = equation1.valueOfx2();
            Console.WriteLine("X1 = {0:f2}", Convert.ToString(value[0]));
            Console.WriteLine("X2 = {0:f2}", Convert.ToString(value[1]));
           
            Console.ReadLine();
        }
    }
}
