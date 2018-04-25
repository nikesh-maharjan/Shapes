using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesWIthSides : Shapes
    {
        static int n = 3;
        int[] array = new int[n];

        public ShapesWIthSides() { }
        public ShapesWIthSides(int n)
        {
            n = 0;
        }
        public int[] inputSides()
        {
            for (int items = 0; items < n; items++)
            {
                do
                {
                    Console.Write($"Enter side {items + 1} length : ");
                    try
                    {
                        checked
                        {
                            array[items] = Convert.ToInt32(Console.ReadLine());
                        }
                        if (array[items] <= 0)
                        {
                            throw new LessThanOrEqualToZeroException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"------------Error enter a number, other character are not valid-----");
                        array[items] = -1;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Checked and caught overflow because the entered value was too large");
                        array[items] = -1;
                    }
                    catch (LessThanOrEqualToZeroException)
                    {
                        Console.WriteLine("-------Invalid Input!! Number cannot be 0 or less than 0");
                    }
                } while (array[items] <= 0);
            }
            return array;
        }
        public override double Area()
        {
            throw new NotImplementedException();
        }
        public override double Area(int[] array)
        { throw new NotImplementedException(); }
        public override double Circumference()
        {
            throw new NotImplementedException();
        }
        public override double Volume()
        {
            throw new NotImplementedException();
        }
        public int[] filledArray
        {
            get { return array; }
            set
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = value[i];
                }
            }
        }
        public int noOfSides {
            get { return n; }
            set { n = value; }
        }
    }
}

