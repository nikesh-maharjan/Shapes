using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesWithRadius : Shapes
    {
        private double radius;
        public const double PI = 22.0 / 7.0;
        public ShapesWithRadius() { }
        public ShapesWithRadius(double rad)
        {
            this.radius = rad;
        }
        public override double Area()
        {
            throw new NotImplementedException();
        }
        public override double Area(int[] array)
        {
            throw new NotImplementedException();
        }
        public override double Volume()
        {
            throw new NotImplementedException();
        }
        public override double Circumference()
        {
            throw new NotImplementedException();
        }
        public double inputRadius()
        {
            do
            {
                Console.Write("Enter Radius : ");
                try
                {
                    radius = checked(Convert.ToDouble(Console.ReadLine()));
                    if (radius <= 0)
                        throw new LessThanOrEqualToZeroException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("------------Error enter a number, other character are not valid-----");
                    radius = -1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Checked and caught overflow because the entered value was too large");
                    radius = -1;
                }
                catch (LessThanOrEqualToZeroException)
                {
                    Console.WriteLine("-------Number cannot be 0 or less than 0");
                }
                //finally
                //{
                //    Console.WriteLine("This program has finally terminated.");
                //}
            } while (radius <= 0);
            return radius;
        }
        public double Radius
        {
            get { return radius; }
            set { this.radius = value; }
        }
    }
}
