using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    public static class TriangleSolver
    {
        /// <summary>
        /// Accepts 3 integers for sides of triangle and checks if triangle is formed or not
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string Analyze(int a, int b, int c)
        {
            //Rule to form triangle
            if((a+b> c) && (a+c > b) && (b+c > a))
            {
                Console.WriteLine("Triangle is formed");

                //Rule for equilateral triangle
                if(a == b && b == c)
                {
                    Console.WriteLine("It is an equilateral triangle");
                }
                //Rule for isosceles triangle
                else if(a==b || b==c || a == c)
                {
                    Console.WriteLine("It is an isosceles triangle");
                }
                //Rule for scalene triangle
                else
                {
                    Console.WriteLine("It is a scalene triangle");
                }
            }
            else
            {
                Console.WriteLine("Triangle cannot be formed");
            }
            return "-------------------------";
        }
    }
}
