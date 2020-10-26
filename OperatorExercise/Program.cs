using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine($"{a}*{b} is {product}");
            Console.WriteLine($"{a}+{b} is {sum}");
            Console.WriteLine($"{a}-{b} is {difference}");

            Console.WriteLine("enter radius");

            double pi = 3.14159;
            double r = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(pi, r);

            Console.WriteLine($"The area of your circle is {area}.");
        }
    
        
            public static double AreaOfCircle(double pi, double r)
        {
            return pi * (r * r);
        }
            

        }
    }

