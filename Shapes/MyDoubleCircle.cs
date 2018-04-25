using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class MyDoubleCircle : ShapesWithRadius
    {
        public MyDoubleCircle() { }
        public MyDoubleCircle(double radius) : base(radius) { }
        public override double Area() => PI * Radius * Radius;
        public override double Circumference() => 2 * PI * Radius;
        public void setRadius(double r)
        {
            Radius = r;
        }
    }
}