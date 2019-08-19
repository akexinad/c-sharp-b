using System;

namespace Section5
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // 43. EXERCISES
            // =============


            // EXERCISE 1

            var number = 11;

            if (number == 10)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }


            // EXERCISE 2

            var num1 = 5;
            var num2 = 4;

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }


            // EXERCISE 3

            var dim1 = 4;
            var dim2 = 5;

            if (dim1 > dim2)
            {
                Console.WriteLine("portrait");
            }
            else
            {
                Console.WriteLine("landscape");
            }


            // EXERCISE 4

            Console.Write("Your Speed: ");
            var speed = Convert.ToInt32(Console.ReadLine());

            Console.Write("The Speed Limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            if (speed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var kmPerDemeritPoint = 5;
                var demeritPoints = (speed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints >= 12)
                {
                    Console.WriteLine("SUSPENDED");
                }
                else
                {
                    Console.WriteLine($"You have lost { demeritPoints } demerit points.");
                }
            }
        }
    }
}
