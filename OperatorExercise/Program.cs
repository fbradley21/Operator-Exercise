using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //explicit typing 
            string variableName = "Hello";

            //inferred typing
            var varName = "Hello";

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;


            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            //allow user to input radius

            Console.WriteLine("What is the radius of your circle?");
     
            var radius = double.Parse(Console.ReadLine());


            //Calculate area of the circle

            var areaOfCircle = CalculateArea(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {areaOfCircle}\n");



            Console.WriteLine("Press any key to continue...");
        }

        public static double CalculateArea(double radius)
        {

            return Math.PI * (radius * radius);

            
        }

    }
}
