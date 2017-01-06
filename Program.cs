using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x ");
            int x = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter y");
            int y = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            Console.WriteLine("\nThe product is {0}",p.multiply(x, y));
            //Console.Write("the quotient is {0}", p.divide(x, y));
            Console.ReadKey();
        }

        public int multiply(int x, int y)
        {
            int product = 0;
            if (x == 0 || y == 0)
                return 0;
            else if (x == 1 || y == 1)
                return 1;
            else
            {
                while (x > 1)
                {
                    if (x % 2 == 1)
                    {
                        product += y;
                        //y *= 2;
                        y += y;
                        x = (int)(x / 2);
                    }
                    else
                    {
                        x = (int)x / 2;
                        //y *= 2;
                        y += y;

                    }


                }
            }
            return product + y;
        }
       /* public double divide (int x, int y)
        {
            double quotient;
            double y1 = Convert.ToDouble(y);
            double x1 = Convert.ToDouble(x);
            if (x1 < y1)
                quotient = y1 / x1;
            else
                quotient =x1/ y1;

            return quotient;

        }*/
    }
}
