using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class MyIntEquation
    {
        private double a;
        private double b;
        private double c;
        private double determinant1;
        private double x1;
        private double x2;
        public MyIntEquation()
        {
        }
        public MyIntEquation(double m, double n, double o)
        {
            a = m;
            b = n;
            c = o;
        }

        public double seta
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

        public double setb
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

        public double setc
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

        public double setx1
        {
            get
            {
                return this.x1;
            }

            set
            {
                this.x1 = value;
            }
        }

        public double setx2
        {
            get
            {
                return this.x2;
            }

            set
            {
                this.x2 = value;
            }
        }

        public double valueOfX1 { get; set; }

        public double valueOfx1()
        {
            if (determinant1 > 0)
            {
                x1 = ((-b) + Math.Pow((Math.Pow(b, 2)) - (4.0 * a * c), (1.0 / 2.0))) / (2.0 * a);
            }
            return x1;
        }

        public double valueOfx2()
        {
            if (determinant1 > 0)
            {
                x2 = ((-b) - Math.Pow((Math.Pow(b, 2)) - (4.0 * a * c), (1.0 / 2.0))) / (2.0 * a);
            }
            return x2;
        }

        public double[] myQuadraticEquation()
        {
            try
            {
                do
                {
                    a = userAValue();
                    b = userBValue();
                    c = userCValue();
                    if (!doesDeterminantExist())
                        Console.WriteLine("Determinant cannot be negative!!!!!!!!!");
                } while (!doesDeterminantExist());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Checked and caught overflow because the entered value was too large");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("cannot be less than 0");
            }
            double[] result = new double[2];
            result[0] = valueOfx1();
            result[1] = valueOfx2();
            return result;
        }

        public double userAValue()
        {
            do
            {
                Console.Write("Enter coefficient a : ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a <= 0)
                        throw new LessThanOrEqualToZeroException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("------------Error!!! enter a number >= 0. Other character are not valid-----");
                    a = -1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Checked and caught overflow because the entered value was too large");
                    a = -1;
                }
                catch (LessThanOrEqualToZeroException)
                {
                    Console.WriteLine("-------Invalid Input. a cannot be 0 or less than 0 ");
                }
            } while (a <= 0);
            return a;
        }

        public double userBValue()
        {
            bool loop;
            do
            {
                loop = false;
                Console.Write("Enter coefficient b : ");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    //if (b < 0)
                    //    throw new LessThanOrEqualToZeroException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("------------Error!!! enter a number, other character are not valid-----");
                    loop = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Checked and caught overflow because the entered value was too large");
                    loop = true;
                }
                //catch (LessThanOrEqualToZeroException)
                //{
                //    Console.WriteLine("-------Ivalid input: b cannot be less than 0.");
                //}

            } while (loop);
            return b;
        }

        public double userCValue()
        {
            bool loop;
            do
            {
                loop = false;
                Console.Write("Enter coefficient c : ");
                try
                {
                    c = Convert.ToInt32(Console.ReadLine());
                    //if (c < 0)
                    //    throw new LessThanOrEqualToZeroException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("------------Error!!! enter a number, other character are not valid-----");
                    loop = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Checked and caught overflow because the entered value was too large");
                    loop = true;
                }
                //catch (LessThanOrEqualToZeroException)
                //{
                //    Console.WriteLine("-------Ivalid input: c cannot be less than 0. ------");
                //}
            } while (loop);
            return c;
        }

        public double determinant()
        {
            try
            {
                checked
                {
                    determinant1 = (Math.Pow(b, 2) - (4.0 * a * c));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("------------Error!!! enter a number >= 0. Other character are not valid-----");
            }
            catch (LessThanOrEqualToZeroException)
            {
                Console.WriteLine("-------Invalid Input. a cannot be 0 or less than 0 ");
            }
            return determinant1;
        }
        public Boolean doesDeterminantExist()
        {
            determinant1 = determinant();
            if (determinant1 >= 0)
                return true;
            return false;
        }
    }
}
