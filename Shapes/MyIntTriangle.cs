using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class MyIntTriangle: ShapesWIthSides
    {
        public MyIntTriangle() { }
        public MyIntTriangle(int n) : base(n) { }
        public override double Area()
        {
            double p = (filledArray[0] + filledArray[1] + filledArray[2]) / 2.0;
            return Math.Pow((p * (p - filledArray[0]) * (p - filledArray[1]) * (p - filledArray[2])), (1.0 / 2.0));
        }
    }
}
