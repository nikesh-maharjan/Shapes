using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    class trycatch { 
        public static void tryCatch()
        {
            const int intMaxValue = 2147483647;
            int number1 = intMaxValue;
            int wontThrow;
            try
            {
                //unchecked
                //{
                //    wontThrow = number1++;
                //    Console.WriteLine(wontThrow);
                //}
                unchecked
                {
                    wontThrow = number1++;
                    Console.WriteLine(wontThrow);
                }
                Console.WriteLine(wontThrow);
            }
            catch (OverflowException)
            {
                Console.WriteLine("overflow exception");
            }
        }           
    }
}
