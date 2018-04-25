using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class MyDoubleHemisphere : ShapesWithRadius
    {
        public MyDoubleHemisphere(double radius) : base(radius) { }
        public MyDoubleHemisphere() { }
        public override double Volume() => (2.0 / 3.0) * PI * Radius * Radius * Radius;
    }
}
