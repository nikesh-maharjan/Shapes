using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class MyIntCircle
    {
         public double inputRadius()
        {
            int radius = -1;
            do
            {
                Console.Write("Enter Radius : ");
                try
                {
                    radius = checked(Convert.ToInt32(Console.ReadLine()));
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
            } while (radius <= 0);
            return radius;
        }
    }
}
