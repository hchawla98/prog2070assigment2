using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    
    class Program
    {
        public static int choice, a, b, c;
        static void Main(string[] args)
        {
            START:
            Menu();
            if(choice == 1)
            {
                sideone();
                sidetwo();
                sidethree();
                TriangleSolver.Analyze(a, b, c);
                goto START;
            }
            else
            {
                System.Environment.Exit(0);
            }
            Console.ReadLine();
        }

        public static void Menu()
        {
            Console.WriteLine("Enter the number corresponding to your choice and hit enter");
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid Input");
                Menu();
            }

            if(choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid choice");
                Menu();
            }
            

        }
        public static void sideone()
        {
            Console.WriteLine("Enter the value of first side");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter an integer value");
                sideone();
            }
            
            
        }
        public static void sidetwo()
        {
            Console.WriteLine("Enter the value of second side");
            try
            {
                b = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter an integer value");
                sidetwo();
            }


        }
        public static void sidethree()
        {
            Console.WriteLine("Enter the value of third side");
            try
            {
                c = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter an integer value");
                sidethree();
            }


        }
    }
}
