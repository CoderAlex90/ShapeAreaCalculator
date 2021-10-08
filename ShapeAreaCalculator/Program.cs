using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float hight;
            float length;

            Console.WriteLine("Welcome to the shape area calculator.");
            Console.WriteLine("With this program you can calculate the area of a circle, triangle or rectangle");
            Console.WriteLine("Let us start.");

            Console.WriteLine("Please enter 'a' for the calculation of a triangle, 'b' for rectangle or 'c' for the calculation of a circle ");
            string input1 = Console.ReadLine();

            if (input1 == "a" || input1 == "b")
            {
                Console.WriteLine("Please enter the hight in cm of the shape");
                hight = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the length in cm of the shape");
                length = float.Parse(Console.ReadLine());

                if(input1 == "a")
                {
                    float shapeArea = 0.5f * hight * length;
                    Console.WriteLine("The shape area of your triangle is " + shapeArea);
                }
                else if (input1 == "b")
                {
                    float shapeArea = hight * length;
                    Console.WriteLine("The shape area of your rectangle is " + shapeArea);
                }

            }
            else if (input1 == "c")
            {
                Console.WriteLine("Please enter the radius in cm of the circle");
                float radius = float.Parse(Console.ReadLine());

                double pi = Math.PI;
                double shapeArea = (radius * radius) * pi;
                Console.WriteLine("The shape area of your circle is " + shapeArea);

            }
            else
            {
                Console.WriteLine("Input Error.");
            }


        }
    }
}
