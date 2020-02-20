using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    public static class TriangleSolver
    {
        
        public static string Analyze(int a, int b, int c)
        {
            if((a+b> c) && (a+c > b) && (b+c > a))
            {
                Console.WriteLine("Triangle is formed");

                if(a == b && b == c)
                {
                    Console.WriteLine("It is an equilateral triangle");
                }
                else if(a==b || b==c || a == c)
                {
                    Console.WriteLine("It is an isosceles triangle");
                }
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
